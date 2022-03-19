namespace Noosium.TestSuites.TestFixtures.Missions
{
    using Resources.Common.Attribute;
    using Noosium.WebDriver.TestCases.Desktop.Missions.Community.List;
    using NUnit.Framework;

    [Author(IFixtureAuthorAttr.Admin),
     Category(ICategoryName.AdminM),
     Description(IFixtureDesc.AdminMCom),
     NonParallelizable,
     Order(1),
     Platform(Exclude = IFixtureE.Exclude),
     TestFixture]
    public class CommunityMissionList
    {

        /// <summary>
        /// It's the approach for making it globally available in an externally accessible form.
        /// </summary>
        public void TF_CommunityMissionList()
        {
            CorrectMissionDisplayed_When_SwitchTheMenus();
        }

        [Test, Order(0)]
        public void CorrectMissionDisplayed_When_SwitchTheMenus()
        {
            MissionCommunityList.CheckComponent_ShouldGetUserMissionList_WhenPrimaryMenuClicked();

            MissionCommunityList.CheckComponent_ShouldGetMissionListDetails_WhenSecondaryMenuClicked();

            MissionCommunityList.CheckComponent_ShouldGetActiveMenuMissionCount_WhenSecondaryMenuFirstClicked();
        }
    }
}

