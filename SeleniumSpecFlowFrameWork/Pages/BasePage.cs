using NUnit.Framework;
using OpenQA.Selenium;
using Protractor;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Pages
{
    public abstract class BasePage
    {
        ShareStateObjects sso;

        protected virtual By PageHeader => By.CssSelector(".partial.active");
        protected abstract string PageTitle { get; }

        public By AdminBtn => By.Id("btn-admin");

        protected BasePage(ShareStateObjects _sso)
        {
            this.sso = _sso;
        }

        protected void VerifyPage()
        {
            var title = sso.ngDriver.FindElement(PageHeader).Text;
            Assert.AreEqual(PageTitle, title, "Page Validation Failed.");
        }



    }
}
