using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Pages
{
    public class PullRightMenu : BasePage
    {
        ShareStateObjects _sso;
        protected override string PageTitle => "";

        private By LocationLink => By.PartialLinkText("Location");
        public PullRightMenu(ShareStateObjects sso) : base(sso)
        {
            _sso = sso;
        }

        public SearchPage NavigateToLocationPage()
        {
            _sso.ngDriver.FindElement(AdminBtn).Click();
            _sso.ngDriver.FindElement(LocationLink).Click();
            return new SearchPage(_sso);
        }


    }
}
