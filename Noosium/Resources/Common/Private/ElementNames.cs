namespace Noosium.Resources.Common.Private
{
    /// <summary>
    /// It's a file that stores the names that the Dom Element can access in Selenium's Web Interface.
    /// </summary>
    internal struct ElementNames
    {
        // Web Login
        public const string Username = "username";
        public const string Password = "password";
        public const string CaptchaCode = "captchaCode";
        public const string Button = "button";
        public const string FormMessages = "form-messages";
        public const string AlertStrong = "strong";
        // Mission Community
        public const string SessionUsername = "session-username";
        public const string SessionLogOut = "session-logout";
        
        public const string PrimaryMenuFirst = "primary-menu-first";
        public const string PrimaryMenuSecond = "primary-menu-second";
        public const string PrimaryMenuThird = "primary-menu-third";
        public const string SecondaryMenuFirst = "secondary-menu-child-first";
        public const string SecondaryMenuFirstCircular = "secondary-menu-child-first-circular";
        public const string SecondaryMenuSecond = "secondary-menu-child-second";
        public const string SecondaryMenuThird = "secondary-menu-child-third";
        public const string SecondaryMenuFour = "secondary-menu-child-four";
        public const string Missions = ".middle > .item:nth-child(1)";
        public const string PageSideBarTopBarButton = "side-bar-top-bar-button";
        public const string PageSidebarMenuMission = "menu-item-nth-child(1)";
        public const string PageSidebarMenuMissionGenerateCom = "menu-item-active-nth-child(2)";
        // Mission Generate Startup Elements - Level One
        public const string MissionStartupMissionMechanicsLtsButton = "mission-startup-mission-mechanics-lts-button";
        public const string MissionStartupContinueTheNextStep = "mission-startup-continue-the-next-step";
        public const string MissionStartupMissionMechanicsLtsInfoAreaHeader = "mission-startup-mission-mechanics-lts-info-area-header";
        public const string MissionStartupMissionMechanicsLtsInfoAreaContext = "mission-startup-mission-mechanics-lts-info-area-context";
        public const string MissionStartupAutoSaveLabel = "mission-startup-auto-save-label";
        public const string MissionStartupTopAreaHeaderText = "mission-startup-top-area-header-text";
        public const string MissionStartupTopAreaHeaderValue= "mission-startup-top-area-header-value";
        // Mission Generate Startup Elements - Level Two
        public const string MissionStartupLevelTwoInput = "mission-startup-level-two-input";
        public const string MissionStartupTopAreaLargeHeader ="mission-startup-top-area-large-header";
        // Mission Generate Startup Elements - Level Three
        public const string MissionStartupLevelThreePurposeInput = "mission-startup-level-three-purpose-input";
        public const string MissionStartupLevelThreeDescriptionInput ="mission-startup-level-three-description-input";
        public const string MissionStartupLevelThreeQlEditor = "mission-startup-level-three-ql-editor";
        public const string MissionStartupLevelThreeQlEditorBold = "mission-startup-level-three-ql-editor-bold";
        
    }
}

