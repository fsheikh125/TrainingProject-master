using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class AuthenticationPage
    {


        ShareStateObjects sso;

        public AuthenticationPage(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }
        public void ValidLogin()
        {
           

            sso.driver.FindElement(By.Id("txtUserID")).SendKeys("FSHEIKH@keyedin4.com");
            sso.driver.FindElement(By.Id("txtPassword")).SendKeys("TEst1234");
            sso.driver.FindElement(By.Id("btnLogin")).Click();


        }


        public void HomePage()
        {

            sso.driver.FindElement(By.XPath("//body/div[3]/div[1]/div[1]/div[3]/div[1]/ul[2]/li[4]/a[1]/i[1]")).Click();
            sso.driver.FindElement(By.XPath("//span[contains(text(),'Locations')]")).Click();
            

        }
    }
}
