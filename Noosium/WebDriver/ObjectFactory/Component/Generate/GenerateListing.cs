using Noosium.Resources.Util.ActionBuilder;

namespace Noosium.WebDriver.ObjectFactory.Component.Generate
{
    using Resources.Util;
    using OpenQA.Selenium;
    using Resources.Log;
    using static Resources.Util.DriverMethods.BasicDriverInterface;

    public static class GenerateListing
    {
        public static void MGenerateListing()
        {
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentOne)));
            new TestLog().Information($"{ListingStruct.ListingComponentOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentCardInput)));
            new TestLog().Information($"{ListingStruct.ListingComponentCardInput} Clicked.");
            SendKeys(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentCardInput)),
                ListingStruct.ListingText);
            new TestLog().Information(
                $"{ListingStruct.ListingComponentCardInput} object {ListingStruct.ListingText} Sent.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentRightRequired)));
            new TestLog().Information($"{ListingStruct.ListingComponentRightRequired} Clicked.");
            //
            if (GetElementsSize(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentCardSize)))>0)
            {
                for (var i = 1; i < GetElementsSize(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentCardSize))); i++)
                {
                    ClickOnElement(By.CssSelector(JsonSoft.GetElement(
                        ListingStruct.ListingBasicContentHeaderBase +
                        i +
                        ListingStruct.ListingBasicContentHeaderExtension)));
                    new TestLog().Information($"{ListingStruct.ListingBasicContentHeaderBase}" 
                                              + i +
                                              $"{ListingStruct.ListingBasicContentHeaderExtension}");
                }
            }
            //
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingBasicContentHeaderChildTwo)));
            new TestLog().Information($"{ListingStruct.ListingBasicContentHeaderChildTwo} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingBasicHeader)));
            new TestLog().Information($"{ListingStruct.ListingBasicHeader} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingBasicContentHeaderChildOne)));
            new TestLog().Information($"{ListingStruct.ListingBasicContentHeaderChildOne} Clicked.");
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentRequiredChildOne)));
            new TestLog().Information($"{ListingStruct.ListingComponentRequiredChildOne} Clicked.");
            for (var i = 2; i >= 0; i--)
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentRequiredUp)));
                new TestLog().Information($"{ListingStruct.ListingComponentRequiredUp} Clicked.");
            }
            for (var i = 3; i >= 0; i--)
            {
                ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingComponentRequiredDown)));
                new TestLog().Information($"{ListingStruct.ListingComponentRequiredDown} Clicked.");
            }
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(ListingStruct.ListingChildOneChildTwo)));
            new TestLog().Information($"{ListingStruct.ListingChildOneChildTwo} Clicked.");
            ActionBuilders.SetFocusAndClickOnIWebElement(
                GetElementWithByStrategy(
                    By.CssSelector(JsonSoft.GetElement(ListingStruct.StartupContinueTheNextStep))));
            new TestLog().Information(
                $"{ListingStruct.StartupContinueTheNextStep} Clicked.");
        }

        private struct ListingStruct
        {
            internal const string ListingComponentOne = "mission-listing-component-one";
            internal const string ListingComponentCardInput = "mission-listing-component-card-input";
            internal const string ListingComponentRightRequired = "mission-listing-component-right-required";
            internal const string ListingComponentCardSize = "mission-listing-component-card-size";
            internal const string ListingBasicContentHeaderBase = "mission-listing-basic-content-header-base";
            internal const string ListingBasicContentHeaderExtension = "mission-listing-basic-content-header-extension";
            internal const string ListingBasicContentHeaderChildTwo =
                "mission-listing-basic-content-header-child-two";
            internal const string ListingBasicHeader = "mission-listing-basic-header";
            internal const string ListingBasicContentHeaderChildOne =
                "mission-listing-basic-content-header-child-one";
            internal const string ListingComponentRequiredChildOne =
                "mission-listing-component-required-child-one";
            internal const string ListingComponentRequiredUp = "mission-listing-component-required-up";
            internal const string ListingComponentRequiredDown = "mission-listing-component-required-down";
            internal const string ListingChildOneChildTwo = "mission-listing-child-one-child-two";
            internal const string ListingText = "Görev Arama";
            internal const string StartupContinueTheNextStep = "mission-startup-continue-the-next-step";
        }
    }
}

