namespace Noosium.WebDriver.TestCases.Desktop.Auth
{
    using NUnit.Framework;
    using Resources.Common.Private;
    using Resources.Log;
    using Resources.Util;
    using System.Threading;
    using OpenQA.Selenium;
    using static Resources.Util.DriverMethods.BasicDriverInterface;

    public static class LoginTests
    {
        public static void CheckResponse_ShouldNavigateToMissionPage_WhenValidIdPasswordEntered()
        {
            NavigateToUrl(JsonSoft.GetUri(ElementSetting.BaseUrl));
            new TestLog().Information($"{JsonSoft.GetUri(ElementSetting.BaseUrl)} opening in other tab /window as per requirement.");
            
            ClickOnElement(By.Id(LNameSt.Username));
            new TestLog().Information($"{LNameSt.Username} Clicked.");
            SendKeys(By.Id(LNameSt.Username),JsonSoft.GetContext(LValueSt.UserName));
            new TestLog().Information($"{JsonSoft.GetContext(LValueSt.UserName)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.Password));
            new TestLog().Information($"{LNameSt.Password} Clicked.");
            SendKeys(By.Id(LNameSt.Password), JsonSoft.GetContext(LValueSt.Password));
            new TestLog().Information($"{JsonSoft.GetContext(LValueSt.Password)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.CaptchaCode));
            new TestLog().Information($"{LNameSt.CaptchaCode} Clicked.");
            SendKeys(By.Id(LNameSt.CaptchaCode), JsonSoft.GetContext(LValueSt.Captcha));
            new TestLog().Information($"{JsonSoft.GetContext(LValueSt.Captcha)} Sent.");
            
            ClickOnElement(By.Name(LNameSt.Button));
            new TestLog().Information($"{LNameSt.Button} Clicked.");
            
            Thread.Sleep(10000);
            Assert.That(GetDriverUrl(),Is.EqualTo(JsonSoft.GetUri("BaseUrl")+JsonSoft.GetUri("AdminMissionCom")));
        }
        public static void CheckResponse_ShouldDisplayAlertComponent_WhenInvalidIdPasswordEntered_()
        {
            NavigateToUrl(JsonSoft.GetUri(ElementSetting.BaseUrl));
            new TestLog().Debug($"{JsonSoft.GetUri(ElementSetting.BaseUrl)} opening in other tab /window as per requirement.");
            
            ClickOnElement(By.Id(LNameSt.Username));
            new TestLog().Debug($"{LNameSt.Username} Clicked.");
            SendKeys(By.Id(LNameSt.Username),JsonSoft.GetContext(LValueSt.InvalidUserName));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.InvalidUserName)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.Password));
            new TestLog().Debug($"{LNameSt.Password} Clicked.");
            SendKeys(By.Id(LNameSt.Password), JsonSoft.GetContext(LValueSt.InvalidPassword));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.InvalidPassword)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.CaptchaCode));
            new TestLog().Debug($"{LNameSt.CaptchaCode} Clicked.");
            SendKeys(By.Id(LNameSt.CaptchaCode), JsonSoft.GetContext(LValueSt.Captcha));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.Captcha)} Sent.");
            
            ClickOnElement(By.Name(LNameSt.Button));
            new TestLog().Debug($"{LNameSt.Button} Clicked.");
            
            Assert.That(GetText(By.CssSelector(LNameSt.AlertStrong)),Is.EqualTo(ElementMessages.AccountDoesNotExist));
        }
        public static void CheckResponse_ShouldDisplayFormMessageError_WhenInvalidCaptcha()
        {
            NavigateToUrl(JsonSoft.GetUri(ElementSetting.BaseUrl));
            new TestLog().Debug($"{JsonSoft.GetUri(ElementSetting.BaseUrl)} opening in other tab /window as per requirement.");
            
            ClickOnElement(By.Id(LNameSt.Username));
            new TestLog().Debug($"{LNameSt.Username} Clicked.");
            SendKeys(By.Id(LNameSt.Username),JsonSoft.GetContext(LValueSt.UserName));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.UserName)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.Password));
            new TestLog().Debug($"{LNameSt.Password} Clicked.");
            SendKeys(By.Id(LNameSt.Password), JsonSoft.GetContext(LValueSt.Password));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.Password)} Sent.");
            
            ClickOnElement(By.Id(LNameSt.CaptchaCode));
            new TestLog().Debug($"{LNameSt.CaptchaCode} Clicked.");
            SendKeys(By.Id(LNameSt.CaptchaCode), JsonSoft.GetContext(LValueSt.InvalidCaptcha));
            new TestLog().Debug($"{JsonSoft.GetContext(LValueSt.InvalidCaptcha)} Sent.");
            
            ClickOnElement(By.Name(LNameSt.Button));
            new TestLog().Debug($"{LNameSt.Button} Clicked.");
            
            Assert.That(GetText(By.Id(LNameSt.FormMessages)),Is.EqualTo(ElementMessages.FormMessagesText));
        }
    }

    /// <summary>
    /// Login Values Struct
    /// </summary>
    internal struct LValueSt
    {
        public const string UserName = "Username";
        public const string InvalidUserName = "IUsername";
        public const string Password = "Password";
        public const string InvalidPassword = "IPassword";
        public const string Captcha = "Captcha";
        public const string InvalidCaptcha = "ICaptcha";
    }

    /// <summary>
    /// Login Name Struct
    /// </summary>
    internal struct LNameSt
    {
        public const string Username = "username";
        public const string Password = "password";
        public const string CaptchaCode = "captchaCode";
        public const string Button = "button";
        public const string FormMessages = "form-messages";
        public const string AlertStrong = "strong";
    }
}

