msbuild "TestStack.ConventionTests.Tests\TestStack.ConventionTests.Tests.xproj"
cp tools\xunit.abstractions.2.0.0\lib\portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS\xunit.abstractions.dll artifacts\bin\TestStack.ConventionTests.Tests\Debug\dotnet
cp tools\xunit.core.2.1.0\build\_desktop\xunit.execution.desktop.dll artifacts\bin\TestStack.ConventionTests.Tests\Debug\dotnet
cp tools\xunit.extensibility.core.2.1.0\lib\portable-net45+win8+wp8+wpa81\xunit.core.dll artifacts\bin\TestStack.ConventionTests.Tests\Debug\dotnet

. "tools\xunit.runner.console.2.1.0\tools\xunit.console.exe" artifacts\bin\TestStack.ConventionTests.Tests\Debug\dotnet\TestStack.ConventionTests.Tests.dll