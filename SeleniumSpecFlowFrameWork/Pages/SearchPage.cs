using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.Pages.ModalSidePopups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Pages
{
    public class SearchPage : BasePage
    {
        ShareStateObjects _sso;
        protected override string PageTitle => "Search";
        private By Addbtn => By.XPath("//i[@title='Add']");
        
        public SearchPage(ShareStateObjects sso) : base(sso)
        {
            _sso = sso;
            VerifyPage();
        }

        public AddLocationModal ClickAddbutton()
        {
            _sso.ngDriver.FindElement(Addbtn).Click();
            return new AddLocationModal(_sso);

        }



    }
}
