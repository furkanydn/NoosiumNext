using Noosium.Resources.Log;

namespace Noosium.WebDriver.ObjectFactory.Component.Generate
{
    using Resources.Util;
    using OpenQA.Selenium;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    
    public static class GenerateTiming
    {
        public static void MissionGenerateTimingOneTimeTask()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelOneChildTwo)));
            new TestLog().Information($"{TimingStruct.TimingLevelOneChildTwo} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelOneChildOne)));
            new TestLog().Information($"{TimingStruct.TimingLevelOneChildOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.StartupContinueTheNextStep)));
            new TestLog().Information($"{TimingStruct.StartupContinueTheNextStep} Clicked.");
        }

        public static void GenerateTimingCalendar()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarDefault)));
            new TestLog().Information($"{TimingStruct.TimingLevelTwoCalendarDefault} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarLeft)));
            new TestLog().Information($"{TimingStruct.TimingLevelTwoCalendarLeft} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarLeft)),TimingStruct.TimingLevelTwoCalendarLeftText);
            new TestLog().Information(
                $"{TimingStruct.TimingLevelTwoCalendarLeft} object {TimingStruct.TimingLevelTwoCalendarLeftText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarRight)));
            new TestLog().Information($"{TimingStruct.TimingLevelTwoCalendarRight} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarRight)),TimingStruct.TimingLevelTwoCalendarRightText);
            new TestLog().Information(
                $"{TimingStruct.TimingLevelTwoCalendarRight} object {TimingStruct.TimingLevelTwoCalendarRightText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.TimingLevelTwoCalendarOkBtn)));
            new TestLog().Information($"{TimingStruct.TimingLevelTwoCalendarOkBtn} Clicked.");
        }

        private struct TimingStruct
        {
            internal const string TimingLevelOneChildTwo = "mission-timing-level-one-child-two";
            internal const string TimingLevelOneChildOne = "mission-timing-level-one-child-one";
            internal const string StartupContinueTheNextStep = "mission-startup-continue-the-next-step";
            internal const string TimingLevelTwoCalendarDefault = "mission-timing-level-two-calendar-default";
            internal const string TimingLevelTwoCalendarLeft = "mission-timing-level-two-calendar-left";
            internal const string TimingLevelTwoCalendarRight = "mission-timing-level-two-calendar-default";
            internal const string TimingLevelTwoCalendarOkBtn = "mission-timing-level-two-calendar-ok-btn";
            internal const string TimingLevelTwoCalendarLeftText = "10.03.2022 12:30";
            internal const string TimingLevelTwoCalendarRightText = "30.03.2022 00:00";
        }
    }
}

