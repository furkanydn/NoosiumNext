namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community.Generate
{
    using Resources.Log;
    using ObjectFactory.PageObject;
    using static Resources.Util.DriverMethods.BasicDriverInterface;
    using ObjectFactory.Component.TextShortcut;

    public static class CommunityMissionGenerateCase
    {
        public static void CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected()
        {
            new TestLog().Debug($"{GetDriverUrlWithOutSplit()} opening.");
            SideBar.SideBarMethod();
        }

        public static void CheckTheStages_ShouldSuccessfullyGeneralDefinitions_WhenTheMissionDefinitionsTyped()
        {
            GeneralDefinitionsMethodsForLimitless();
        }

        #region General Definitions - LTS (Limitless)


        /// <summary>
        /// General description of the mission operations, type, schedule, listing, etc.
        /// </summary>
        private static void GeneralDefinitionsMethodsForLimitless()
        {
            CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton();
            CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
            CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
            CheckHaveFilled_ShouldMissionRequiredConditionsMetRight_WhenTypeTheTextFieldsInTheQlEditor();
            CheckImageSelect_ShouldChooseTheRightImage_WhenImageSelectedFromTheImageSelector();
        }

        #endregion

        #region Startup

        /// <summary>
        /// When it comes to testing the mission mechanics, the first step is to decide which mechanic to use.
        /// </summary>
        private static void CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton()
        {
            Generate.Mechanism(GenerateMechanism.Lts);
        }

        /// <summary>
        /// The technique will be used to test the mission's name.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            Generate.QlEditorMissionName();
        }

        /// <summary>
        /// The technique will be used to test the mission's description.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            Generate.QlEditorMissionDescription();
        }

        /// <summary>
        /// The scope and conditions that should be stated in the fourth step are written in this method tests.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionRequiredConditionsMetRight_WhenTypeTheTextFieldsInTheQlEditor()
        {
            Generate.QlBlankRequiredConditions();
        }

        /// <summary>
        /// Checks that the image selection component has selected the right image.
        /// </summary>
        private static void CheckImageSelect_ShouldChooseTheRightImage_WhenImageSelectedFromTheImageSelector()
        {
            Generate.VisualIllustratesTheStoryOfTheMission();
        }

        #endregion
    }
}

