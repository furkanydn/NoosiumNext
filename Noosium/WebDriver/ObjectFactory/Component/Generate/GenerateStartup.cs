namespace Noosium.WebDriver.ObjectFactory.Component.Generate
{
    using System;
    using Resources.Log;
    using Resources.Util;
    using Resources.Util.ActionBuilder;
    using Resources.Util.JSFunctions;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    public static class GenerateStartup
    {
        public static void Mechanism(GenerateMechanism generateMechanism)
        {
            switch (generateMechanism)
            {
                case GenerateMechanism.Lts:
                    ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupMissionMechanicsLtsButton)));
                    new TestLog().Information(
                        $"{GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupMissionMechanicsLtsButton)))} Clicked.");
                    Assert.That(
                        GetText(By.CssSelector(
                            JsonSoft.GetElement(EStruct.StartupMissionMechanicsLtsInfoAreaContext))),
                        Is.EqualTo(EStruct.LtsInfoBoxText));
                    Assert.That(
                        GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderText))),
                        Is.EqualTo(EStruct.GenerateHeader));
                    Assert.That(
                        GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderValue))),
                        Is.EqualTo(EStruct.DataZero));
                    ActionBuilders.SetFocusAndClickOnIWebElement(
                        GetElementWithByStrategy(
                            By.CssSelector(JsonSoft.GetElement(EStruct.StartupContinueTheNextStep))));
                    new TestLog().Information(
                        $"{GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupMissionMechanicsLtsButton)))} Clicked.");
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
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelTwoInput)));
            new TestLog().Information($"{EStruct.StartupLevelTwoInput} Clicked.");
            SendKeys(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelTwoInput)),
                EStruct.GenerateName);
            new TestLog().Information($"{EStruct.GenerateName} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataSix));
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaLargeHeader))),
                Is.EqualTo(EStruct.GenerateName));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.StartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.StartupMissionMechanicsLtsButton} Clicked.");
        }
        public static void QlEditorMissionDescription()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreePurposeInput)));
            new TestLog().Information($"{EStruct.StartupLevelThreePurposeInput} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreePurposeInput)),
                EStruct.GeneratePurpose);
            new TestLog().Information(
                $"{EStruct.StartupLevelThreePurposeInput} object {EStruct.GeneratePurpose} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeDescriptionInput)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorFirstText);
            new TestLog().Information($"{EStruct.StartupLevelThreeDescriptionInput} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorFirstText} Sent.");
            JavaScriptFunctions.JavaScriptTillEnd();
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorBold)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorSecondText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorBold} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorSecondText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorPickerLabelThr)),
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorThirdText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorPickerLabelThr} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorThirdText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorItalic)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorFourthText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorItalic} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorFourthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorPickerLabel)),
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorPickerLabelTwo)),
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorFifthText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorPickerLabel} Clicked.");
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorPickerLabelTwo} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorFifthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorUnderline)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorSixthText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorUnderline} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorSixthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorListItemOne)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorSevenText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorListItemOne} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorSevenText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorListItemTwo)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorEighthText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorListItemTwo} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorEighthText} Sent.");
            MultiActionForEditor(
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditorClean)),
                null,
                By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelThreeQlEditor)),
                EStruct.QlEditorNineText);
            new TestLog().Information($"{EStruct.StartupLevelThreeQlEditorClean} Clicked.");
            new TestLog().Information(
                $"{EStruct.StartupLevelThreeQlEditor} Object. {EStruct.QlEditorNineText} Sent.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataTwelve));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.StartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.StartupMissionMechanicsLtsButton} Clicked.");
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
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataEighteen));
            Assert.That(GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFourQuestion))),Is.EqualTo(EStruct.StartupLevelFourQuestionText));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.StartupContinueTheNextStep))));
            new TestLog().Information(
                $"{EStruct.StartupContinueTheNextStep} Clicked.");
        }
        public static void VisualIllustratesTheStoryOfTheMission()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveCircular)));
            new TestLog().Information($"{EStruct.StartupLevelFiveCircular} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveContentOne)));
            new TestLog().Information($"{EStruct.StartupLevelFiveContentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveAcceptButton)));
            new TestLog().Information($"{EStruct.StartupLevelFiveAcceptButton} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveDelete)));
            new TestLog().Information($"{EStruct.StartupLevelFiveDelete} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveCircular)));
            new TestLog().Information($"{EStruct.StartupLevelFiveCircular} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveContentTwo)));
            new TestLog().Information($"{EStruct.StartupLevelFiveContentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveAcceptButton)));
            new TestLog().Information($"{EStruct.StartupLevelFiveAcceptButton} Clicked.");
            Assert.That(
                GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupTopAreaHeaderValue))),
                Is.EqualTo(EStruct.DataTwentyFour));
            Assert.That(GetText(By.CssSelector(JsonSoft.GetElement(EStruct.StartupLevelFiveQuestion))),Is.EqualTo(EStruct.StartupLevelFiveQuestionText));
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(EStruct.StartupContinueTheNextStep))));
            new TestLog().Information($"{EStruct.StartupContinueTheNextStep} Clicked.");
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
        internal const string GenerateName = "testmissiongenerateselenium";
        internal const string StartupLevelTwoInput = "mission-startup-level-two-input";
        internal const string StartupTopAreaHeaderValue= "mission-startup-top-area-header-value";
        internal const string StartupTopAreaLargeHeader ="mission-startup-top-area-large-header";
        internal const string StartupContinueTheNextStep = "mission-startup-continue-the-next-step";
        internal const string DataZero = "0%";
        internal const string DataSix = "6%";
        internal const string StartupMissionMechanicsLtsButton = "mission-startup-mission-mechanics-lts-button";
        internal const string StartupMissionMechanicsLtsInfoAreaContext = "mission-startup-mission-mechanics-lts-info-area-context";
        internal const string StartupTopAreaHeaderText = "mission-startup-top-area-header-text";
        internal const string StartupLevelThreePurposeInput = "mission-startup-level-three-purpose-input";
        internal const string StartupLevelThreeDescriptionInput ="mission-startup-level-three-description-input";
        internal const string StartupLevelThreeQlEditor = "mission-startup-level-three-ql-editor";
        internal const string StartupLevelThreeQlEditorBold = "mission-startup-level-three-ql-editor-bold";
        internal const string StartupLevelThreeQlEditorPickerLabel =
            "mission-startup-level-three-ql-editor-picker-label";
        internal const string StartupLevelThreeQlEditorPickerLabelTwo =
            "mission-startup-level-three-ql-editor-picker-label-tw";
        internal const string StartupLevelThreeQlEditorPickerLabelThr =
            "mission-startup-level-three-ql-editor-picker-label-th";
        internal const string StartupLevelThreeQlEditorItalic = "mission-startup-level-three-ql-editor-italic";
        internal const string StartupLevelThreeQlEditorUnderline = "mission-startup-level-three-ql-editor-underline";
        internal const string StartupLevelThreeQlEditorListItemOne =
            "mission-startup-level-three-ql-editor-list-item-one";
        internal const string StartupLevelThreeQlEditorListItemTwo =
            "mission-startup-level-three-ql-editor-list-item-two";
        internal const string StartupLevelThreeQlEditorClean = "mission-startup-level-three-ql-editor-clean";
        internal const string GeneratePurpose = "Esas amacı anlatan özlü bir söz kullanabilirsin.";
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
        internal const string StartupLevelFourQuestion = "mission-startup-level-four-question";
        internal const string StartupLevelFourQuestionText =
            "Görev için sağlanması gereken şartlar nelerdir?\nYapılması gerekenlerin kapsam ve koşullarını madde madde yazman faydalı olacaktır.";
        internal const string StartupLevelFiveCircular = "mission-startup-level-five-circular";
        internal const string StartupLevelFiveContentOne = "mission-startup-level-five-content-one";
        internal const string StartupLevelFiveAcceptButton = "mission-startup-level-five-accept-button";
        internal const string StartupLevelFiveContentTwo = "mission-startup-level-five-content-two";
        internal const string StartupLevelFiveDelete = "mission-startup-level-five-delete";
        internal const string DataTwentyFour = "24%";
        internal const string StartupLevelFiveQuestion = "mission-startup-level-five-question";
        internal const string StartupLevelFiveQuestionText =
            "Görevi anlatan bir resim seçer misin?\nSeçeceğin resim bir film yada bir oyun sahnesi olabilir.";
        // Messages
        internal const string LtsInfoBoxText =
            "Limitsiz\nKatılımcılar herhangi bir limite ulaşmaya çalışmadan en iyiyi yapmayı hedeflemeli.";
        internal const string GenerateHeader = "Görev Oluştur";
    }
}

