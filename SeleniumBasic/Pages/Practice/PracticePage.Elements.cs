using OpenQA.Selenium;


namespace SeleniumBasic.Pages.Practice
{
    public partial class PracticePage : BasePage
    {
        public readonly string PRACTICE_HOME_PAGE_URL = "http://automationpractice.com/index.php/";
        public readonly By NAV_BAR_SIGN_IN_BUTTON = By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]");
        public readonly By EMAIL_FIELD_INPUT = By.Id("email_create");
        public readonly By EMAIL_FIELD_OUTPUT = By.Id("email");
        public readonly By SUBMIT_EMAIL_BUTTON = By.Id("SubmitCreate");
    }
}
