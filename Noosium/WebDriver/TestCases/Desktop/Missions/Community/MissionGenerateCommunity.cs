namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using Resources.Common.Private;
    using Resources.Log;
    using Resources.Util.ActionBuilder;
    using Resources.Util.JSFunctions;
    using Resources.Util;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    
    public static class MissionGenerateCommunity
    {
        public static void CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            ClickTheMissionGenerateButtonInTheSideBar();
            GeneralDefinitionsMethods();
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
        private static void GeneralDefinitionsMethods()
        {
            CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton();
            CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
            CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
        }

        #region Startup
        private static void CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton()
        {
            // If the auto save button is not checked, click the button
            /* This method,a little buggy, because it doesn't recognize the selected return value.
             if (CheckBoxElementIsChecked(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupAutoSaveLabel))) == false)
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupAutoSaveLabel)));
            */
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
            // Asserts
            Assert.That(
                GetText(By.CssSelector(
                    JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsInfoAreaContext))),
                Is.EqualTo(ElementMessages.LtsInfoBoxText));
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupTopAreaHeaderText))),
                Is.EqualTo(ElementMessages.MissionGenerateHeader));
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(ElementValues.DataZero));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
        }
        private static void CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelTwoInput)));
            new TestLog().Information($"{ElementNames.MissionStartupLevelTwoInput} Clicked.");
            SendKeys(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelTwoInput)),
                ElementValues.MissionGenerateName);
            new TestLog().Information($"{ElementValues.MissionGenerateName} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(ElementValues.DataSix));
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupTopAreaLargeHeader))),
                Is.EqualTo(ElementValues.MissionGenerateName));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{ElementNames.MissionStartupMissionMechanicsLtsButton} Clicked.");
        }

        private static void CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreePurposeInput)));
            new TestLog().Information($"{ElementNames.MissionStartupLevelThreePurposeInput} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreePurposeInput)),
                ElementValues.MissionGeneratePurpose);
            new TestLog().Information(
                $"{ElementNames.MissionStartupLevelThreePurposeInput} object {ElementValues.MissionGeneratePurpose} Sent.");
            
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeDescriptionInput)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorFirstText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeDescriptionInput} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorFirstText} Sent.");
            JavaScriptFunctions.JavaScriptTillEnd();
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorBold)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorSecondText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorBold} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorSecondText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorPickerLabelThr)),
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorThirdText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorPickerLabelThr} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorThirdText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorItalic)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorFourthText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorItalic} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorFourthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorPickerLabelTwo)),
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorFifthText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorPickerLabelTwo} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorFifthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorUnderline)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorSixthText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorUnderline} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorSixthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorListItemOne)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorSevenText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorListItemOne} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorSevenText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorListItemTwo)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorEighthText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorListItemTwo} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorEighthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditorClean)),
                null,
                By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupLevelThreeQlEditor)),
                ElementValues.QlEditorNineText);
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditorClean} Clicked.");
            new TestLog().Information( $"{ElementNames.MissionStartupLevelThreeQlEditor} Object. {ElementValues.QlEditorNineText} Sent.");
        }

        #endregion
        

        #endregion
        
    }
}

