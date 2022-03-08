namespace Noosium.TestSuites.TestFixtures
{
    using Resources.Common.Attribute;
    using WebDriver.TestCases.Desktop.Missions.Community;
    using NUnit.Framework;

    [Author(IFixtureAuthorAttr.Admin),
     Category(ICategoryName.AdminM),
     Description(IFixtureDesc.AdminMCom),
     NonParallelizable,
     Order(1),
     Platform(Exclude = IFixtureE.Exclude),
     TestFixture]
    public class MissionListCom
    {

        /// <summary>
        /// It's the approach for making it globally available in an externally accessible form.
        /// </summary>
        public MissionListCom()
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

