using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasic.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {        
        public readonly string GOOGLE_HOME_PAGE_URL = "http://google.com/";
        public readonly By SEARCH_INPUT_FIELD = By.Name("q");
        public readonly By FIRST_SEARCH_RESULT = By.CssSelector(".r a h3[class]");
    }

}
