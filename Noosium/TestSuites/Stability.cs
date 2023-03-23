using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Noosium.TestSuites;

[TestFixture]
public class Stability
{
    private IWebDriver _webDriver;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        TestContext.WriteLine("The tests were started by the IWebDriver.");
        new DriverManager().SetUpDriver(new ChromeConfig());
        _webDriver = new ChromeDriver();
        TestContext.WriteLine("The ChromeDriver was installed.");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _webDriver.Quit();
    }

    [Test]
    [Order(0)]
    [Description("Test Name: Login")]
    public void LoginTest()
    {
        StartTestCase("https://test.motivist.com/");
        ClickAndSendKeys(By.Id("username"),"furkan.aydin");
        ClickAndSendKeys(By.Id("password"),"NOOS25.");
        ClickAndSendKeys(By.Id("captchaCode"),"NOOSN");
        _webDriver.FindElement(By.Name("button")).Click();
    }

    [Test]
    [Order(1)]
    [Description("Test Name: Missions")]
    public void Missions()
    {
        // Community Missions
        _webDriver.FindElement(By.CssSelector(".item:nth-child(1) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".list:nth-child(2) > .item:nth-child(1) > .content:nth-child(1)")).Click();
        _webDriver.FindElement(By.CssSelector(".item:nth-child(1) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".list:nth-child(2) > .item:nth-child(2) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".fluid:nth-child(3) > .center")).Click();
        _webDriver.FindElement(By.CssSelector(".item:nth-child(1) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".list:nth-child(2) > .item:nth-child(3) > .content:nth-child(1)")).Click();
        if (_webDriver.FindElement(By.CssSelector(".oo-container:nth-child(2) .cog")).Displayed)
            Assert.Pass("Community missions is OK!");
        // Individual Missions
        _webDriver.FindElement(By.CssSelector(".list:nth-child(4) > .item:nth-child(1)")).Click();
        _webDriver.FindElement(By.CssSelector(".item:nth-child(1) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".list:nth-child(4) > .item:nth-child(2) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".item:nth-child(1) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".list:nth-child(4) > .item:nth-child(3) > .content")).Click();
        _webDriver.FindElement(By.CssSelector(".button:nth-child(1)")).Click();
    }

    private void StartTestCase([Values("Expected website address")] string text)
    {
        if (_webDriver == null) throw new WebDriverException("Web Driver not found!");
        _webDriver.Navigate().GoToUrl("https://test.motivist.com/");
        _webDriver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
    }
    private void ClickAndSendKeys(By locator, string text)
    {
        if (!_webDriver.FindElement(locator).Displayed) throw new NoSuchElementException($@"By.Id('{locator}') is not found");
        _webDriver.FindElement(locator).Click();
        _webDriver.FindElement(locator).SendKeys(text);
        TestContext.WriteLine($@"{locator} nesnesine tıklandı ve {text} değeri gönderildi.");
    }
}