using System;
using Noosium.Resources.Common.Private;
using Noosium.Resources.Log;
using Noosium.Resources.Util;
using Noosium.Resources.Util.ActionBuilder;
using NUnit.Framework;
using OpenQA.Selenium;
using static Noosium.Resources.Util.DriverMethods.BasicDriverInterface;

namespace Noosium.WebDriver.ObjectFactory.Component.TextShortcut
{
    public static class Generate
    {
        public static void Mechanism(GenerateMechanism generateMechanism)
        {
            switch (generateMechanism)
            {
                case GenerateMechanism.Lts:
                    ClickOnElement(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)));
                    new TestLog().Information(
                        $"{GetText(By.CssSelector(JsonSoft.GetElement(ElementNames.MissionStartupMissionMechanicsLtsButton)))} Clicked.");
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
        public static void QlEditor()
        {
            
        }
    }

    public enum GenerateMechanism
    {
        Lts, //(Limitless),
        Ltd, //(Limited)
        Rec, //(Recursive)
        Seq, //(Sequential)
        Rat, //(Ratio)
    }
}

