namespace Noosium.WebDriver.ObjectFactory.Component.TextShortcut
{
    using System;
    using Resources.Log;
    using Resources.Util;
    using Resources.Util.ActionBuilder;
    using Resources.Util.JSFunctions;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    public static class Generate
    {
        public static void Mechanism(GenerateMechanism generateMechanism)
        {
            switch (generateMechanism)
            {
                case GenerateMechanism.Lts:
                    ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupMissionMechanicsLtsButton)));
                    new TestLog().Information(
                        $"{GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
                    Assert.That(
                        GetText(By.CssSelector(
                            JsonSoft.GetElement(EStruct.MissionStartupMissionMechanicsLtsInfoAreaContext))),
                        Is.EqualTo(EStruct.LtsInfoBoxText));
                    Assert.That(
                        GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderText))),
                        Is.EqualTo(EStruct.MissionGenerateHeader));
                    Assert.That(
                        GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderValue))),
                        Is.EqualTo(EStruct.DataZero));
                    ActionBuilders.SetFocusAndClickOnIWebElement(
                        GetElementWithByStrategy(
                            By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupContinueTheNextStep))));
                    new TestLog().Information(
                        $"{GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
                    break;
                case GenerateMechanism.Ltd:
                    break;
                case GenerateMechanism.Rec:
                    break;
                case GenerateMechanism.Seq:
                    break;
                case GenerateMechanism.Rat:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(generateMechanism), generateMechanism, null);
            }
        }
        public static void QlEditorMissionName()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelTwoInput)));
            new TestLog().Information($"{EStruct.MissionStartupLevelTwoInput} Clicked.");
            SendKeys(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelTwoInput)),
                EStruct.MissionGenerateName);
            new TestLog().Information($"{EStruct.MissionGenerateName} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataSix));
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaLargeHeader))),
                Is.EqualTo(EStruct.MissionGenerateName));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.MissionStartupMissionMechanicsLtsButton} Clicked.");
        }
        public static void QlEditorMissionDescription()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreePurposeInput)));
            new TestLog().Information($"{EStruct.MissionStartupLevelThreePurposeInput} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreePurposeInput)),
                EStruct.MissionGeneratePurpose);
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreePurposeInput} object {EStruct.MissionGeneratePurpose} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeDescriptionInput)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorFirstText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeDescriptionInput} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorFirstText} Sent.");
            JavaScriptFunctions.JavaScriptTillEnd();
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorBold)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorSecondText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorBold} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorSecondText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorPickerLabelThr)),
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorThirdText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorPickerLabelThr} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorThirdText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorItalic)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorFourthText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorItalic} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorFourthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorPickerLabelTwo)),
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorFifthText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorPickerLabelTwo} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorFifthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorUnderline)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorSixthText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorUnderline} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorSixthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorListItemOne)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorSevenText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorListItemOne} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorSevenText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorListItemTwo)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorEighthText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorListItemTwo} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorEighthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditorClean)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelThreeQlEditor)),
                EStruct.QlEditorNineText);
            new TestLog().Information($"{EStruct.MissionStartupLevelThreeQlEditorClean} Clicked.");
            new TestLog().Information(
                $"{EStruct.MissionStartupLevelThreeQlEditor} Object. {EStruct.QlEditorNineText} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataTwelve));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.MissionStartupMissionMechanicsLtsButton} Clicked.");
        }
        public static void QlBlankRequiredConditions()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.QlBlank)));
            new TestLog().Information($"{EStruct.QlBlank} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(EStruct.QlBlank)),
                EStruct.QlBlankText);
            new TestLog().Information(
                $"{EStruct.QlBlank} object {EStruct.QlBlankText} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataEighteen));
            Assert.That(GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFourQuestion))),Is.EqualTo(EStruct.MissionStartupLevelFourQuestionText));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.MissionStartupContinueTheNextStep} Clicked.");
        }
        public static void VisualIllustratesTheStoryOfTheMission()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveCircular)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveCircular} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveContentOne)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveContentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveAcceptButton)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveAcceptButton} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveDelete)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveDelete} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveCircular)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveCircular} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveContentTwo)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveContentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveAcceptButton)));
            new TestLog().Information($"{EStruct.MissionStartupLevelFiveAcceptButton} Clicked.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataTwentyFour));
            Assert.That(GetText(By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupLevelFiveQuestion))),Is.EqualTo(EStruct.MissionStartupLevelFiveQuestionText));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.MissionStartupContinueTheNextStep))));
            new TestLog().Information($"{EStruct.MissionStartupContinueTheNextStep} Clicked.");
        }
    }

    /// <summary>
    /// The mission mechanics are defined here as enum.
    /// </summary>
    public enum GenerateMechanism
    {
        Lts, //(Limitless),
        Ltd, //(Limited)
        Rec, //(Recursive)
        Seq, //(Sequential)
        Rat, //(Ratio)
    }
    
    internal struct EStruct
    {
        internal const string MissionGenerateName = "testmissiongenerateselenium";
        internal const string MissionStartupLevelTwoInput = "mission-startup-level-two-input";
        internal const string MissionStartupTopAreaHeaderValue= "mission-startup-top-area-header-value";
        internal const string MissionStartupTopAreaLargeHeader ="mission-startup-top-area-large-header";
        internal const string MissionStartupContinueTheNextStep = "mission-startup-continue-the-next-step";
        internal const string DataZero = "0%";
        internal const string DataSix = "6%";
        internal const string MissionStartupMissionMechanicsLtsButton = "mission-startup-mission-mechanics-lts-button";
        internal const string MissionStartupMissionMechanicsLtsInfoAreaContext = "mission-startup-mission-mechanics-lts-info-area-context";
        internal const string MissionStartupTopAreaHeaderText = "mission-startup-top-area-header-text";
        internal const string MissionStartupLevelThreePurposeInput = "mission-startup-level-three-purpose-input";
        internal const string MissionStartupLevelThreeDescriptionInput ="mission-startup-level-three-description-input";
        internal const string MissionStartupLevelThreeQlEditor = "mission-startup-level-three-ql-editor";
        internal const string MissionStartupLevelThreeQlEditorBold = "mission-startup-level-three-ql-editor-bold";
        internal const string MissionStartupLevelThreeQlEditorPickerLabel =
            "mission-startup-level-three-ql-editor-picker-label";
        internal const string MissionStartupLevelThreeQlEditorPickerLabelTwo =
            "mission-startup-level-three-ql-editor-picker-label-tw";
        internal const string MissionStartupLevelThreeQlEditorPickerLabelThr =
            "mission-startup-level-three-ql-editor-picker-label-th";
        internal const string MissionStartupLevelThreeQlEditorItalic = "mission-startup-level-three-ql-editor-italic";
        internal const string MissionStartupLevelThreeQlEditorUnderline = "mission-startup-level-three-ql-editor-underline";
        internal const string MissionStartupLevelThreeQlEditorListItemOne =
            "mission-startup-level-three-ql-editor-list-item-one";
        internal const string MissionStartupLevelThreeQlEditorListItemTwo =
            "mission-startup-level-three-ql-editor-list-item-two";
        internal const string MissionStartupLevelThreeQlEditorClean = "mission-startup-level-three-ql-editor-clean";
        internal const string MissionGeneratePurpose = "Esas amacı anlatan özlü bir söz kullanabilirsin.";
        // Ql Editor Contexts
        internal const string QlEditorFirstText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = 'Bu görevin anlaşılması için hikaye yazabilirsin.'}";
        internal const string QlEditorSecondText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = 'Bu görevin anlaşılması için hikaye <strong>yazabilirsin.</strong>'}";
        internal const string QlEditorThirdText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h3>bur bir görevin anlaşılması için hikaye <strong>yazabilirsin.</strong></h3>'}";
        internal const string QlEditorFourthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h3>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h3>'}";
        internal const string QlEditorFifthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h2>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h2>'}";
        internal const string QlEditorSixthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<h2><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></h2>'}";
        internal const string QlEditorSevenText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<ol><li><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></li></ol>'}";
        internal const string QlEditorEighthText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<ul><li><u>bur</u> bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></li></ul>'}";
        internal const string QlEditorNineText =
            "if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<p>bur bir görevin anlaşılması için hikaye <strong><em>yazabilirsin.</em></strong></p>'}";
        internal const string DataTwelve = "12%";
        internal const string QlBlank = "mission-startup-level-four-ql-blank";
        internal const string QlBlankText =
            "It would be useful to write down the scope and conditions of what needs to be done, item by item.";
        internal const string DataEighteen = "18%";
        internal const string MissionStartupLevelFourQuestion = "mission-startup-level-four-question";
        internal const string MissionStartupLevelFourQuestionText =
            "Görev için sağlanması gereken şartlar nelerdir?\nYapılması gerekenlerin kapsam ve koşullarını madde madde yazman faydalı olacaktır.";
        internal const string MissionStartupLevelFiveCircular = "mission-startup-level-five-circular";
        internal const string MissionStartupLevelFiveContentOne = "mission-startup-level-five-content-one";
        internal const string MissionStartupLevelFiveAcceptButton = "mission-startup-level-five-accept-button";
        internal const string MissionStartupLevelFiveContentTwo = "mission-startup-level-five-content-two";
        internal const string MissionStartupLevelFiveDelete = "mission-startup-level-five-delete";
        internal const string DataTwentyFour = "24%";
        internal const string MissionStartupLevelFiveQuestion = "mission-startup-level-five-question";
        internal const string MissionStartupLevelFiveQuestionText =
            "Görevi anlatan bir resim seçer misin?\nSeçeceğin resim bir film yada bir oyun sahnesi olabilir.";
        // Messages
        internal const string LtsInfoBoxText =
            "Limitsiz\nKatılımcılar herhangi bir limite ulaşmaya çalışmadan en iyiyi yapmayı hedeflemeli.";
        internal const string MissionGenerateHeader = "Görev Oluştur";
    }
}

