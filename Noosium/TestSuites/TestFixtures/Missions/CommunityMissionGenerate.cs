namespace Noosium.TestSuites.TestFixtures.Missions
{
    using Resources.Common.Attribute;
    using WebDriver.Mock;
    using Noosium.WebDriver.TestCases.Desktop.Missions.Community.Generate;
    using NUnit.Framework;

    [Author(FixtureAuthor.Admin),
     Category(CategoryName.Regression),
     Description(FixtureDesc.AdminMgComLts),
     NonParallelizable,
     Order(2),
     Platform(Exclude = FixtureExclude.Exclude),
     TestFixture]
    public class CommunityMissionGenerate : BaseMockDriver
    {
        public void TF_CommunityMissionGenerate()
        {
            TC_CorrectMissionOpened_ClickedMenuItem();
            TC_CheckRightDefinitionOptions_ShouldBeCorrectGeneralDefinitions_WhenFillingComponentsWithGivenValues();
        }

        [Test, Order(0), Property(CaseSeverity.Severity,CaseSeverity.Cosmetic)]
        public void TC_CorrectMissionOpened_ClickedMenuItem()
        {
            CommunityMissionGenerateCase.CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected();
        }
        
        [Test, Order(1), Property(CaseSeverity.Severity,CaseSeverity.Cosmetic)]
        public void TC_CheckRightDefinitionOptions_ShouldBeCorrectGeneralDefinitions_WhenFillingComponentsWithGivenValues()
        {
            CommunityMissionGenerateCase.CheckTheStages_ShouldSuccessfullyGeneralDefinitions_WhenTheMissionDefinitionsTyped();
        }
    }
}

