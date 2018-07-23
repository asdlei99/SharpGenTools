﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using SharpGen.Logging;
using SharpGen.Model;
using SharpGen.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpGen.Generator
{
    public class RoslynGenerator
    {
        private readonly GlobalNamespaceProvider globalNamespace;

        public IGeneratorRegistry Generators { get; }

        public RoslynGenerator(Logger logger, GlobalNamespaceProvider globalNamespace, IDocumentationLinker documentation, ExternalDocCommentsReader docReader)
        {
            Logger = logger;
            this.globalNamespace = globalNamespace;
            Generators = new DefaultGenerators(globalNamespace, documentation, docReader, logger);
        }

        public Logger Logger { get; }

        public static IDictionary<string, IList<string>> GetFilePathsForGeneratedFiles(CsSolution solution, string rootDirectory, string generatedCodeFolder, bool includeAssemblyNameFolder)
        {
            var results = new Dictionary<string, IList<string>>();
            foreach (var assembly in solution.Assemblies)
            {
                var directory = GetAssemblyDirectory(assembly, rootDirectory, generatedCodeFolder, includeAssemblyNameFolder);
                results.Add(assembly.Name, new List<string> { Path.Combine(directory, "LocalInterop.cs")});
                foreach (var nameSpace in assembly.Namespaces)
                {
                    var namespaceDirectory = GetNamespaceDirectory(directory, nameSpace);
                    results[assembly.Name].Add(Path.Combine(namespaceDirectory, "Enumerations.cs"));
                    results[assembly.Name].Add(Path.Combine(namespaceDirectory, "Structures.cs"));
                    results[assembly.Name].Add(Path.Combine(namespaceDirectory, "Interfaces.cs"));
                    results[assembly.Name].Add(Path.Combine(namespaceDirectory, "Functions.cs"));
                }
            }

            return results;
        }

        public void Run(CsSolution solution, string rootDirectory, string generatedCodeFolder, bool includeAssemblyNameFolder)
        {
            var trees = new List<SyntaxTree>();

            // Iterates on assemblies
            foreach (var csAssembly in solution.Assemblies.Where(assembly => assembly.NeedsToBeUpdated))
            {
                string generatedDirectoryForAssembly = GetAssemblyDirectory(csAssembly, rootDirectory, generatedCodeFolder, includeAssemblyNameFolder);
                var directoryToCreate = new HashSet<string>(StringComparer.CurrentCulture);

                // Remove the generated directory before creating it
                if (!directoryToCreate.Contains(generatedDirectoryForAssembly))
                {
                    directoryToCreate.Add(generatedDirectoryForAssembly);
                    if (Directory.Exists(generatedDirectoryForAssembly))
                    {
                        foreach (var oldGeneratedFile in Directory.EnumerateFiles(generatedDirectoryForAssembly, "*.cs", SearchOption.AllDirectories))
                        {
                            try
                            {
                                File.Delete(oldGeneratedFile);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }

                if (!Directory.Exists(generatedDirectoryForAssembly))
                    Directory.CreateDirectory(generatedDirectoryForAssembly);

                Logger.Message("Process Assembly {0} => {1}", csAssembly.Name, generatedDirectoryForAssembly);

                // LocalInterop is once generated per assembly
                trees.Add(
                    CSharpSyntaxTree.Create(
                        CompilationUnit().WithMembers(
                            SingletonList<MemberDeclarationSyntax>(
                                Generators.LocalInterop.GenerateCode(csAssembly))
                            )
                            .NormalizeWhitespace(elasticTrivia: true))
                        .WithFilePath(Path.Combine(generatedDirectoryForAssembly, "LocalInterop.cs")));

                foreach (var csNamespace in csAssembly.Namespaces)
                {
                    var nameSpaceDirectory = GetNamespaceDirectory(generatedDirectoryForAssembly, csNamespace);
                    if (!Directory.Exists(nameSpaceDirectory))
                        Directory.CreateDirectory(nameSpaceDirectory);

                    trees.Add(
                        CSharpSyntaxTree.Create(
                            GenerateCompilationUnit(csNamespace.Name, csNamespace.Enums.OrderBy(element => element.Name), Generators.Enum))
                            .WithFilePath(Path.Combine(nameSpaceDirectory, "Enumerations.cs")));
                    trees.Add(
                        CSharpSyntaxTree.Create(
                            GenerateCompilationUnit(csNamespace.Name, csNamespace.Structs.OrderBy(element => element.Name), Generators.Struct))
                            .WithFilePath(Path.Combine(nameSpaceDirectory, "Structures.cs")));
                    trees.Add(
                        CSharpSyntaxTree.Create(
                            GenerateCompilationUnit(csNamespace.Name, csNamespace.Classes.OrderBy(element => element.Name), Generators.Group))
                            .WithFilePath(Path.Combine(nameSpaceDirectory, "Functions.cs")));
                    trees.Add(
                        CSharpSyntaxTree.Create(
                            GenerateCompilationUnit(csNamespace.Name, csNamespace.Interfaces.OrderBy(element => element.Name), Generators.Interface))
                            .WithFilePath(Path.Combine(nameSpaceDirectory, "Interfaces.cs")));
                }
            }

            foreach (var tree in trees)
            {
                File.WriteAllText(tree.FilePath, tree.GetCompilationUnitRoot().ToFullString());
            }
        }

        private static string GetNamespaceDirectory(string generatedDirectoryForAssembly, CsNamespace csNamespace)
        {
            var subDirectory = csNamespace.OutputDirectory ?? ".";

            var nameSpaceDirectory = Path.Combine(generatedDirectoryForAssembly, subDirectory);
            return nameSpaceDirectory;
        }

        private static string GetAssemblyDirectory(CsAssembly csAssembly, string rootDirectory, string generatedCodeFolder, bool includeAssemblyNameFolder)
        {
            var assemblyRootDirectory = includeAssemblyNameFolder ? Path.Combine(rootDirectory, csAssembly.Name) : rootDirectory;

            var generatedDirectoryForAssembly = Path.Combine(assemblyRootDirectory, generatedCodeFolder ?? "Generated");
            return generatedDirectoryForAssembly;
        }

        private static CompilationUnitSyntax GenerateCompilationUnit<T>(
            string csNamespace,
            IEnumerable<T> elements,
            IMultiCodeGenerator<T, MemberDeclarationSyntax> generator)
        {
            return CompilationUnit()
                .WithMembers(
                    SingletonList<MemberDeclarationSyntax>(
                        NamespaceDeclaration(ParseName(csNamespace))
                            .WithMembers(List(elements.SelectMany(element => generator.GenerateCode(element))))
                    ))
                .NormalizeWhitespace(elasticTrivia: true);
        }
    }
}
