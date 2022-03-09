namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community
{
    using OpenQA.Selenium;
    using Resources.Common.Private;
    using Resources.Log;
    using Resources.Util;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    
    public static class MissionGenerateCommunityLts
    {
        public static void CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            if (GetElementCountOn(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission))))
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSideBarTopBarButton)));
            }
            else
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)));
                new TestLog().Information($"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)))} Clicked.");
            }


            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMissionGenerateCom)));
            new TestLog().Information($"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMissionGenerateCom)))} Clicked.");
        }
    }
}

