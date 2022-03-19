using Noosium.Resources.Common.Private;
using Noosium.Resources.Log;
using Noosium.Resources.Util;
using OpenQA.Selenium;
using static Noosium.Resources.Util.DriverMethods.BasicDriverInterface;

namespace Noosium.WebDriver.ObjectFactory.PageObject
{
    
    public static class SideBar
    {
        /// <summary>
        /// This method can be used to handle the activities in the menu located in the left field on low-resolution devices.
        /// </summary>
        public static void SideBarMethod()
        {
            CheckMenuIsOpen();
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSidebarMenuMission)));
                new TestLog().Information(
                    $"{GetText(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSidebarMenuMission)))} Clicked.");

            ClickOnElement(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSidebarMenuMissionGenerateCom)));
            new TestLog().Information(
                $"{GetText(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSidebarMenuMissionGenerateCom)))} Clicked.");
        }

        /// <summary>
        /// This method checks whether the menu located in the left field on the devices is open.
        /// </summary>
        private static void CheckMenuIsOpen()
        {
            if (!GetElementCountOn(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSidebarMenuMission)))) return;
            ClickOnElement(By.CssSelector(JsonSoft.GetElement(SNameSt.PageSideBarTopBarButton)));
        }
    }

    /// <summary>
    /// Side Bar Name Struct
    /// </summary>
    internal struct SNameSt
    {
        public const string PageSideBarTopBarButton = "side-bar-top-bar-button";
        public const string PageSidebarMenuMission = "menu-item-nth-child(1)";
        public const string PageSidebarMenuMissionGenerateCom = "menu-item-active-nth-child(2)";
    }
}

