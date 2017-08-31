pushd SharpGen.E2ETests
dotnet xunit
if ($LastExitCode -ne 0) {
    exit 1
}
popd

rm -r -Force SdkTests/LocalPackages/ SdkTests/RestoredPackages/
mkdir SdkTests/LocalPackages
mv SharpGenTools.Sdk/bin/Release/*.nupkg SdkTests/LocalPackages/

pushd .\SdkTests
msbuild /t:Restore
msbuild /p:Configuration=Release /m

if ($LastExitCode -ne 0) {
    exit 1
}

cd SharpGen.Runtime
msbuild /t:Pack /p:Configuration=Release
popd
