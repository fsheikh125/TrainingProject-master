using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    public class AddLocationSteps
    {
        ShareStateObjects _sso;

        public AddLocationSteps(ShareStateObjects sso)
        {
            this._sso = sso;
        }

        [Given(@"User is logged on")]
        public void GivenUserIsLoggedOn()
        {
            new LoginPage(_sso).Login();
        }

        [When(@"User Navigate Location page via Administration menu")]
        public void WhenUserNavigateLocationPageViaAdministrationMenu()
        {
            new PullRightMenu(_sso).NavigateToLocationPage();
        }


        [Then(@"should be able to create a Location")]
        public SearchPage ThenShouldBeAbleToCreateALocation()
        {
            new SearchPage(_sso).ClickAddbutton().AddLocation();
            return new SearchPage(_sso);
        }
    }
}
