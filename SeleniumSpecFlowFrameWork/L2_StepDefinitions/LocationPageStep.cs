
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    public class LocationPageStep
    {

        ShareStateObjects sso;

        public LocationPageStep(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }


        [Then(@"I should be able to go to location page")]
        public void ThenIShouldBeAbleToGoToLocationPage()
        {
            new AuthenticationPage(sso).HomePage();
        }

        [Then(@"I should be able to add new Location entry")]
        public void ThenIShouldBeAbleToAddNewLocationEntry()
        {
            new LocationPage(sso).createLocation();
        }


    }
}


