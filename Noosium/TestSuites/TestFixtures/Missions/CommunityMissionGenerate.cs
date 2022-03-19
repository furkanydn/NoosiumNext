namespace Noosium.TestSuites.TestFixtures.Missions
{
    using Resources.Common.Attribute;
    using WebDriver.Mock;
    using Noosium.WebDriver.TestCases.Desktop.Missions.Community.Generate;
    using NUnit.Framework;

    [Author(IFixtureAuthorAttr.Admin),
     Category(ICategoryName.AdminM),
     Description(IFixtureDesc.AdminMgComLts),
     NonParallelizable,
     Order(2),
     Platform(Exclude = IFixtureE.Exclude),
     TestFixture]
    public class CommunityMissionGenerate : BaseMockDriver
    {
        public void TF_CommunityMissionGenerate()
        {
            TC_CorrectMissionOpened_ClickedMenuItem();
        }

        [Test, Order(0)]
        public void TC_CorrectMissionOpened_ClickedMenuItem()
        {
            CommunityMissionGenerateCase.CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected();
        }
        
        [Test, Order(1)]
        public void TC_CheckRightDefinitionOptions_ShouldBeCorrectGeneralDefinitions_WhenFillingComponentsWithGivenValues()
        {
            CommunityMissionGenerateCase.CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected();
        }
    }
}

