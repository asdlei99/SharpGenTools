﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using SharpGen.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp;
using System.Linq;
using Microsoft.CodeAnalysis;
using SharpGen.Transform;

namespace SharpGen.Generator
{
    class StructCodeGenerator : MemberCodeGeneratorBase<CsStruct>
    {
        public StructCodeGenerator(IGeneratorRegistry generators, IDocumentationAggregator documentation) : base(documentation)
        {
            Generators = generators;
        }

        public IGeneratorRegistry Generators { get; }

        public override IEnumerable<MemberDeclarationSyntax> GenerateCode(CsStruct csElement)
        {
            var documentationTrivia = GenerateDocumentationTrivia(csElement);
            var layoutKind = csElement.ExplicitLayout ? "Explicit" : "Sequential";
            var structLayoutAttribute = Attribute(ParseName("System.Runtime.InteropServices.StructLayoutAttribute"))
                    .WithArgumentList(
                        AttributeArgumentList(SeparatedList(
                            new []
                            {
                                AttributeArgument(ParseName($"System.Runtime.InteropServices.LayoutKind.{layoutKind}")),
                                AttributeArgument(
                                    LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(csElement.Align)))
                                    .WithNameEquals(NameEquals(IdentifierName("Pack")))
                            }
                        )
                    )
                );

            var innerStructs = csElement.InnerStructs.Select(GenerateCode).Cast<MemberDeclarationSyntax>();

            var constants = csElement.Variables.SelectMany(var => Generators.Constant.GenerateCode(var));

            var fields = csElement.Fields.SelectMany(field =>
            {
                var explicitLayout = !csElement.HasMarshalType && csElement.ExplicitLayout;
                var generator = explicitLayout ? Generators.ExplicitOffsetField : Generators.AutoLayoutField;
                return generator.GenerateCode(field);
            });

            var marshallingStructAndConversions = Generators.NativeStruct.GenerateCode(csElement);

            yield return (csElement.GenerateAsClass ?
                (MemberDeclarationSyntax)ClassDeclaration(
                    !csElement.HasMarshalType ? SingletonList(AttributeList(SingletonSeparatedList(structLayoutAttribute))) : default,
                    TokenList(ParseTokens(csElement.VisibilityName)),
                    Identifier(csElement.Name),
                    default,
                    default,
                    default,
                    List(innerStructs.Concat(constants).Concat(fields).Concat(marshallingStructAndConversions)))
                .WithLeadingTrivia(Trivia(documentationTrivia))
                    :
                StructDeclaration(
                    !csElement.HasMarshalType ? SingletonList(AttributeList(SingletonSeparatedList(structLayoutAttribute))) : default,
                    TokenList(ParseTokens(csElement.VisibilityName)),
                    Identifier(csElement.Name),
                    default,
                    default,
                    default,
                    List(innerStructs.Concat(constants).Concat(fields).Concat(marshallingStructAndConversions))))
                .WithLeadingTrivia(Trivia(documentationTrivia));
        }
    }
}