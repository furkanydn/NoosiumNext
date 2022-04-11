using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Noosium.TestSuites;

[TestFixture]
[NonParallelizable]
public class Sanity
{
    private IWebDriver _webDriver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor _executor;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        TestContext.WriteLine("The tests were started by the IWebDriver.");
        new DriverManager().SetUpDriver(new ChromeConfig());
        _webDriver = new ChromeDriver();
        TestContext.WriteLine("The ChromeDriver was installed.");
        _executor = (IJavaScriptExecutor) _webDriver;
        vars = new Dictionary<string, object>();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _webDriver.Quit();
    }
    
    [Test]
    [Order(0)]
    [Description("Test Name: Login - Step # | name | target | value")]
    public void LoginTest()
    {
        
    }
}