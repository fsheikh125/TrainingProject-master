using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowFrameWork.Pages
{
    public class MyWorkPage : BasePage
    {
        ShareStateObjects _sso;
        protected override string PageTitle => "My Work";
        

        public MyWorkPage(ShareStateObjects sso) : base(sso)
        {
            _sso = sso;
            VerifyPage();
        }






    }
}
