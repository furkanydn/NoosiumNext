namespace Noosium.TestSuites.TestFixtures.Missions
{
    using Resources.Common.Attribute;
    using Noosium.WebDriver.TestCases.Desktop.Missions.Community.List;
    using NUnit.Framework;

    [Author(FixtureAuthor.Admin),
     Category(CategoryName.Regression),
     Description(FixtureDesc.AdminMCom),
     NonParallelizable,
     Order(1),
     Platform(Exclude = FixtureExclude.Exclude),
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

        [Test, Order(0), Property(CaseSeverity.Severity,CaseSeverity.Critical)]
        public void CorrectMissionDisplayed_When_SwitchTheMenus()
        {
            CommunityList.CheckComponent_ShouldGetUserMissionList_WhenPrimaryMenuClicked();

            CommunityList.CheckComponent_ShouldGetMissionListDetails_WhenSecondaryMenuClicked();

            CommunityList.CheckComponent_ShouldGetActiveMenuMissionCount_WhenSecondaryMenuFirstClicked();
        }
    }
}

