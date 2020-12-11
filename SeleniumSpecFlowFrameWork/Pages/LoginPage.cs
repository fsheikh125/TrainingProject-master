using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.Pages
{
    public class LoginPage
    {
        ShareStateObjects _sso;

        private By IdTxtBox => By.Id("txtUserID");
        private By PasswordTxtBox => (By.Id("txtPassword"));
        private By SignInBtn => By.Id("btnLogin");
        public LoginPage(ShareStateObjects sso)
        {
            _sso = sso;
        }

        public MyWorkPage Login()
        {
            //sso.ngDriver.Navigate().GoToUrl("https://kipstaging.keyedinuat.com/KIP4/");
            _sso.ngDriver.FindElement(IdTxtBox).SendKeys("FSHEIKH@keyedin4.com");
            _sso.ngDriver.FindElement(PasswordTxtBox).SendKeys("TEst1234");
            _sso.ngDriver.FindElement(SignInBtn).Click();

            return new MyWorkPage(_sso);
        }

    }
}
