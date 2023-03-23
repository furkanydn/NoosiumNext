using Noosium.WebDriver.ObjectFactory.Component.Generate;

namespace Noosium.WebDriver.TestCases.Desktop.Missions.Community.Generate
{
    using Resources.Log;
    using ObjectFactory.PageObject;
    using static Resources.Util.DriverMethods.BasicDriverInterface;

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
            //Startup
            CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton();
            CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
            CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor();
            CheckHaveFilled_ShouldMissionRequiredConditionsMetRight_WhenTypeTheTextFieldsInTheQlEditor();
            CheckImageSelect_ShouldChooseTheRightImage_WhenImageSelectedFromTheImageSelector();
            //Listing
            CheckListingStage_ShouldListingComponentsRightResponse_WhenNecessaryInfoIsEnteredInTheComponents();
            //Timing
            CheckTimingStage_ShouldTimingComponentsRightValues_WhenTimingComponentsSendValues();
            CheckTimingStage_ShouldTimingCalendarComponentValue_WhenCalendarComponentSendValues();
            //Calculation
        }

        #endregion

        #region Startup

        /// <summary>
        /// When it comes to testing the mission mechanics, the first step is to decide which mechanic to use.
        /// </summary>
        private static void CheckMechanism_ShouldGenerateLimitlessMission_WhenClickedLimitlessButton()
        {
            GenerateStartup.Mechanism(GenerateMechanism.Lts);
        }

        /// <summary>
        /// The technique will be used to test the mission's name.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionNameTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            GenerateStartup.QlEditorMissionName();
        }

        /// <summary>
        /// The technique will be used to test the mission's description.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionDescriptionTypedCorrectly_WhenTypeTheTextFieldsInTheQlEditor()
        {
            GenerateStartup.QlEditorMissionDescription();
        }

        /// <summary>
        /// The scope and conditions that should be stated in the fourth step are written in this method tests.
        /// </summary>
        private static void CheckHaveFilled_ShouldMissionRequiredConditionsMetRight_WhenTypeTheTextFieldsInTheQlEditor()
        {
            GenerateStartup.QlBlankRequiredConditions();
        }

        /// <summary>
        /// Checks that the image selection component has selected the right image.
        /// </summary>
        private static void CheckImageSelect_ShouldChooseTheRightImage_WhenImageSelectedFromTheImageSelector()
        {
            GenerateStartup.VisualIllustratesTheStoryOfTheMission();
        }

        #endregion

        #region Listing

        /// <summary>
        /// It is a test method with task mechanics listing functions under general definitions on the mission generate page.
        /// </summary>
        private static void
            CheckListingStage_ShouldListingComponentsRightResponse_WhenNecessaryInfoIsEnteredInTheComponents()
        {
            GenerateListing.MGenerateListing();
        }

        #endregion

        #region Timing

        /// <summary>
        /// This test method evaluates whether or not to use a single-time calculation, which is the default option during the scheduling stage.
        /// </summary>
        private static void CheckTimingStage_ShouldTimingComponentsRightValues_WhenTimingComponentsSendValues()
        {
            GenerateTiming.MissionGenerateTimingOneTimeTask();
        }

        /// <summary>
        /// During the scheduling phase, this test method examines the tests of the task's calendar entry field.
        /// </summary>
        private static void CheckTimingStage_ShouldTimingCalendarComponentValue_WhenCalendarComponentSendValues()
        {
            GenerateTiming.GenerateTimingCalendar();
        }

        #endregion

        #region Calculation

        #endregion
    }
}

