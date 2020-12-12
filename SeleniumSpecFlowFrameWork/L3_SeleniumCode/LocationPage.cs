using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class LocationPage
    {
        ShareStateObjects sso;

        public LocationPage(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }
        public void createLocation()
        {

            sso.driver.FindElement(By.XPath("//body/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]")).Click();
            sso.driver.FindElement(By.Id("name")).SendKeys("Test Name");
            sso.driver.FindElement(By.Id("code")).SendKeys("TEST1234");
            sso.driver.FindElement(By.XPath("//input[@type='submit']")).Click();

        }
    }
}
