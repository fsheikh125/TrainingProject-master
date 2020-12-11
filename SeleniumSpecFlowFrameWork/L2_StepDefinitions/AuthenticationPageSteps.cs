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
    public class AuthenticationPageSteps
    {

        ShareStateObjects sso;

        public AuthenticationPageSteps(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }

      
        [When(@"I provide valid credentials and signin")]
        public void WhenIProvideValidCredentialsAndSignin()
        {
            new AuthenticationPage(sso).ValidLogin();
        }


      




    }
}
