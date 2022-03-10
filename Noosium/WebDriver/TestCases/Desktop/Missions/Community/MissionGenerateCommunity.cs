using NUnit.Framework;

namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community
{
    using OpenQA.Selenium;
    using Resources.Common.Private;
    using Resources.Log;
    using Resources.Util;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    
    public static class MissionGenerateCommunity
    {
        public static void CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            ClickTheMissionGenerateButtonInTheSideBar();
            CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton();
        }

        /// <summary>
        /// It was created click the menu in the sidebar and opens the mission generate page.
        /// </summary>
        private static void ClickTheMissionGenerateButtonInTheSideBar()
        {
            if (GetElementCountOn(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission))))
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSideBarTopBarButton)));
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)));
                new TestLog().Information(
                    $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)))} Clicked.");
            }
            else
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)));
                new TestLog().Information(
                    $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMission)))} Clicked.");
            }
            
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMissionGenerateCom)));
            new TestLog().Information($"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.PageSidebarMenuMissionGenerateCom)))} Clicked.");
        }

        #region General Definitions - LTS (Limitless)

        /// <summary>
        /// General description of the mission operations, type, schedule, listing, etc.
        /// </summary>
        private static void CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton()
        {
            // If the auto save button is not checked, click the button
            if (CheckBoxElementIsChecked(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupAutoSaveLabel)))==false)
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupAutoSaveLabel)));
            
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
            Assert.That(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsInfoAreaContext)),
                Is.EqualTo(ElementMessages.LtsInfoBoxText));
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupContinueTheNextStep)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
        }

        #endregion
        
    }
}

