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
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelOneChildTwo)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelOneChildTwo} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelOneChildOne)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelOneChildOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionStartupContinueTheNextStep)));
            new TestLog().Information($"{TimingStruct.MissionStartupContinueTheNextStep} Clicked.");
        }

        public static void MissionGenerateTimingCalendar()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarDefault)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelTwoCalendarDefault} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarLeft)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelTwoCalendarLeft} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarLeft)),TimingStruct.MissionTimingLevelTwoCalendarLeftText);
            new TestLog().Information(
                $"{TimingStruct.MissionTimingLevelTwoCalendarLeft} object {TimingStruct.MissionTimingLevelTwoCalendarLeftText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarRight)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelTwoCalendarRight} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarRight)),TimingStruct.MissionTimingLevelTwoCalendarRightText);
            new TestLog().Information(
                $"{TimingStruct.MissionTimingLevelTwoCalendarRight} object {TimingStruct.MissionTimingLevelTwoCalendarRightText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(TimingStruct.MissionTimingLevelTwoCalendarOkBtn)));
            new TestLog().Information($"{TimingStruct.MissionTimingLevelTwoCalendarOkBtn} Clicked.");
        }

        private struct TimingStruct
        {
            internal const string MissionTimingLevelOneChildTwo = "mission-timing-level-one-child-two";
            internal const string MissionTimingLevelOneChildOne = "mission-timing-level-one-child-one";
            internal const string MissionStartupContinueTheNextStep = "mission-startup-continue-the-next-step";
            internal const string MissionTimingLevelTwoCalendarDefault = "mission-timing-level-two-calendar-default";
            internal const string MissionTimingLevelTwoCalendarLeft = "mission-timing-level-two-calendar-left";
            internal const string MissionTimingLevelTwoCalendarRight = "mission-timing-level-two-calendar-default";
            internal const string MissionTimingLevelTwoCalendarOkBtn = "mission-timing-level-two-calendar-ok-btn";
            internal const string MissionTimingLevelTwoCalendarLeftText = "10.03.2022 12:30";
            internal const string MissionTimingLevelTwoCalendarRightText = "30.03.2022 00:00";
        }
    }
}

