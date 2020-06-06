using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasic.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {

        public GooglePage(IWebDriver driver)
            :base(driver)
        {

        }

        public void SubmitsGoogleSearch(string text)
        {
            Actions actions = new Actions(Driver);
            FillFieldWithText(SEARCH_INPUT_FIELD, text);
            actions.SendKeys(Keys.Enter);
            actions.Perform();

        }
    }
}
