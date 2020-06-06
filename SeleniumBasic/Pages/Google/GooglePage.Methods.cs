using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace SeleniumBasic.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {

        public GooglePage(IWebDriver driver)
            :base(driver)
        {

        }

        public void Open()
        {
            NavigateTo(GOOGLE_HOME_PAGE_URL);
        }

        public void SubmitGoogleSearch(string text)
        {
            Actions actions = new Actions(Driver);

            FillFieldWithText(SEARCH_INPUT_FIELD, text);
            actions.SendKeys(Keys.Enter);
            actions.Perform();
        }

        public void ClickOnFirstResultLink()
        {
            ClickOn(FIRST_SEARCH_RESULT);
        }
    }
}
