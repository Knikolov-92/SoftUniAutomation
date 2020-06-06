using OpenQA.Selenium;


namespace SeleniumBasic.Pages.Practice
{
    public partial class PracticePage : BasePage
    {
        public PracticePage(IWebDriver driver)
            : base(driver)
        {

        }

        public void Open()
        {
            NavigateTo(PRACTICE_HOME_PAGE_URL);
        }

        public void CreateAnAccountEmail(string email)
        {
            WaitForElementToBeDisplayed(EMAIL_FIELD_INPUT);
            FillFieldWithText(EMAIL_FIELD_INPUT, email);
            ClickOn(SUBMIT_EMAIL_BUTTON);
        }

        public void GoToSignInPage()
        {
            ClickOn(NAV_BAR_SIGN_IN_BUTTON);
        }        
    }
}
