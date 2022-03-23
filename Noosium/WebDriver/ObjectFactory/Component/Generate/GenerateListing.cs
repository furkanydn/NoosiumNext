using Noosium.Resources.Util.ActionBuilder;

namespace Noosium.WebDriver.ObjectFactory.Component.Generate
{
    using Resources.Util;
    using OpenQA.Selenium;
    using Resources.Log;
    using static Resources.Util.DriverMethods.BasicDriverInterface;

    public static class GenerateListing
    {
        public static void MissionGenerateListing()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentOne)));
            new TestLog().Information($"{ListingStruct.MissionListingComponentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentCardInput)));
            new TestLog().Information($"{ListingStruct.MissionListingComponentCardInput} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentCardInput)),
                ListingStruct.MissionListingText);
            new TestLog().Information(
                $"{ListingStruct.MissionListingComponentCardInput} object {ListingStruct.MissionListingText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentRightRequired)));
            new TestLog().Information($"{ListingStruct.MissionListingComponentRightRequired} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingBasicContentHeaderChildTwo)));
            new TestLog().Information($"{ListingStruct.MissionListingBasicContentHeaderChildTwo} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingBasicHeader)));
            new TestLog().Information($"{ListingStruct.MissionListingBasicHeader} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingBasicContentHeaderChildOne)));
            new TestLog().Information($"{ListingStruct.MissionListingBasicContentHeaderChildOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentRequiredChildOne)));
            new TestLog().Information($"{ListingStruct.MissionListingComponentRequiredChildOne} Clicked.");
            for (var i = 2; i >= 0; i--)
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentRequiredUp)));
                new TestLog().Information($"{ListingStruct.MissionListingComponentRequiredUp} Clicked.");
            }
            for (var i = 3; i >= 0; i--)
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingComponentRequiredDown)));
                new TestLog().Information($"{ListingStruct.MissionListingComponentRequiredDown} Clicked.");
            }
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionListingChildOneChildTwo)));
            new TestLog().Information($"{ListingStruct.MissionListingChildOneChildTwo} Clicked.");
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(ListingStruct.MissionStartupContinueTheNextStep))));
            new TestLog().Information(
                $"{ListingStruct.MissionStartupContinueTheNextStep} Clicked.");
        }

        private struct ListingStruct
        {
            internal const string MissionListingComponentOne = "mission-listing-component-one";
            internal const string MissionListingComponentCardInput = "mission-listing-component-card-input";
            internal const string MissionListingComponentRightRequired = "mission-listing-component-right-required";
            internal const string MissionListingBasicContentHeaderChildTwo =
                "mission-listing-basic-content-header-child-two";
            internal const string MissionListingBasicHeader = "mission-listing-basic-header";
            internal const string MissionListingBasicContentHeaderChildOne =
                "mission-listing-basic-content-header-child-one";
            internal const string MissionListingComponentRequiredChildOne =
                "mission-listing-component-required-child-one";
            internal const string MissionListingComponentRequiredUp = "mission-listing-component-required-up";
            internal const string MissionListingComponentRequiredDown = "mission-listing-component-required-down";
            internal const string MissionListingChildOneChildTwo = "mission-listing-child-one-child-two";
            internal const string MissionListingText = "Görev Arama";
            internal const string MissionStartupContinueTheNextStep = "mission-startup-continue-the-next-step";
        }
    }
}

