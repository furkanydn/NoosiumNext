namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community.List
{
    using Resources.Log;
    using Resources.Util;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using static Resources.Util.DriverMethods.BasicDriverInterface;

    public static class CommunityList
    {
        public static void CheckComponent_ShouldGetUserMissionList_WhenPrimaryMenuClicked()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuSecond)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuSecond))).Split('\n')[0]} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuThird)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuThird))).Split('\n')[0]} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuFirst)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.PrimaryMenuFirst))).Split('\n')[0]} Clicked.");
        }

        public static void CheckComponent_ShouldGetMissionListDetails_WhenSecondaryMenuClicked()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuSecond)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuSecond))).Split('\n')[0]} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuThird)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuThird))).Split('\n')[0]} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuFour)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuFour))).Split('\n')[0]} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuFirst)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuFirst))).Split('\n')[0]} Clicked.");
        }

        public static void CheckComponent_ShouldGetActiveMenuMissionCount_WhenSecondaryMenuFirstClicked()
        {
            Assert.That(GetText(By.CssSelector(JsonSoft.GetElement(MNameSt.SecondaryMenuFirstCircular))),
                Is.Not.EqualTo(0));
        }
    }

    /// <summary>
    /// Mission Community List Struct
    /// </summary>
    internal struct MNameSt
    {
        public const string PrimaryMenuFirst = "primary-menu-first";
        public const string PrimaryMenuSecond = "primary-menu-second";
        public const string PrimaryMenuThird = "primary-menu-third";
        public const string SecondaryMenuFirst = "secondary-menu-child-first";
        public const string SecondaryMenuFirstCircular = "secondary-menu-child-first-circular";
        public const string SecondaryMenuSecond = "secondary-menu-child-second";
        public const string SecondaryMenuThird = "secondary-menu-child-third";
        public const string SecondaryMenuFour = "secondary-menu-child-four";
    }
}

