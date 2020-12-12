using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class HomePage
    {


        ShareStateObjects sso;

        public HomePage(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }
        public void ValidLogin()
        {


            sso.driver.FindElement(By.Id("txtUserID")).SendKeys("autotest@workflows.com");
            sso.driver.FindElement(By.Id("txtPassword")).SendKeys("TEst1234");
            sso.driver.FindElement(By.Id("btnLogin")).Click();


        }
    }
}
