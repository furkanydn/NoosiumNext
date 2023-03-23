# Introduction
NUnit 3 is preinstalled on a test application written in.NET Core 6 Edition. It is created and positioned as an executable for use in operating systems such as Windows, Linux, and MacOS, as well as browsers such as Chrome, Firefox, Opera, and Safari. Its main goal is to test the Motivist product's web interface.
# Getting Started
You must first download an IDE that can execute C# apps, such as Rider or Visual Studio, on your computer before you can use it.
1. Installation process
    1. [Visual Studio](https://visualstudio.microsoft.com/) - [Rider](https://www.jetbrains.com/rider/)
    2. The project's required NuGet packages must be downloaded. [NuGet](https://www.nuget.org/)
2. Software dependencies
    1. [Coverlet.Collector](https://www.nuget.org/packages/coverlet.collector/)
    2. [Microsoft.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk)
    3. [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json)
    4. [NUnit](https://www.nuget.org/packages/NUnit)
    5. [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter)
    6. [Selenium.Support](https://www.nuget.org/packages/Selenium.Support)
    7. [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver)
    8. [WebDriverManager](https://www.nuget.org/packages/WebDriverManager)
3. API reference
    1. [Selenium-Webdriver](https://www.selenium.dev/)

# Build and Test
###[Visual Studio](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022) 
- (MacOS & Linux): The Unit Tests window is used to run unit tests and is opened using the View > Tests menu. Unit tests in your solution are automatically discovered and shown in this window, where you can run all of the tests or a set of tests that you've selected.


- (Windows): When you build the test project, the tests appear in Test Explorer. If Test Explorer is not visible, choose Test on the Visual Studio menu, choose Windows, and then choose Test Explorer (or press Ctrl + E, T).

###[Rider](https://www.jetbrains.com/help/rider/Unit_Testing__Index.html) 

- (MacOS & Linux): To enable VSTest adapters support, select the corresponding checkbox on the Build, Execution, Deployment | Unit Testing | VSTest page of JetBrains Rider settings ⌃ ⌥ S.

- (Windows): To enable VSTest adapters support, select the corresponding checkbox on the Build, Execution, Deployment | Unit Testing | VSTest page of JetBrains Rider settings ⌃ ⌥ S.# Motivist.Test
