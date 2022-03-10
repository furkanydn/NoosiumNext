namespace Noosium.TestSuites.TestFixtures
{
    using Resources.Common.Attribute;
    using WebDriver.Mock;
    using WebDriver.TestCases.Desktop.Missions.Community;
    using NUnit.Framework;

    [Author(IFixtureAuthorAttr.Admin),
     Category(ICategoryName.AdminM),
     Description(IFixtureDesc.AdminMgComLts),
     NonParallelizable,
     Order(2),
     Platform(Exclude = IFixtureE.Exclude),
     TestFixture]
    public class MissionGenerateComLts : BaseMockDriver
    {
        public MissionGenerateComLts()
        {
            CorrectMissionOpened_ClickedMenuItem();
        }
        
        [Test, Order(0)]
        public void CorrectMissionOpened_ClickedMenuItem()
        {
            MissionGenerateCommunity.CheckTheStages_ShouldSuccessfulMissionGenerate_WhenTheMissionMechanismIsSelected();
        }
    }
}
