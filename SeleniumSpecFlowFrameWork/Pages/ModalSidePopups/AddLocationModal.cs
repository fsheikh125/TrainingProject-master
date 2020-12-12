using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Pages.ModalSidePopups
{
    public class AddLocationModal : SearchPage
    {
        ShareStateObjects _sso;
        protected override By PageHeader => By.CssSelector("#modal-title");
        protected override string PageTitle => "Add xLocation";

        private By NameTxtBox => By.Id("name");
        private By CodeTxtBox => By.Id("code");
        private By SaveAndClostBtn => By.ClassName("saveclosebutton");

        public AddLocationModal(ShareStateObjects sso) : base(sso)
        {
            _sso = sso;
            VerifyPage();
        }

        public void AddLocation()
        {
            _sso.ngDriver.FindElement(NameTxtBox).SendKeys("Test");
            _sso.ngDriver.FindElement(CodeTxtBox).SendKeys(DateTime.Now.ToString("yyyymmddhhmmss"));
            _sso.ngDriver.FindElement(SaveAndClostBtn).Click();
        }

    }
}
