using OpenQA.Selenium;


namespace AutomationPractice.Pages.SignIn
{
    public partial class SignInPage : BasePage
    {
        public const string SIGN_IN_PAGE_URL = "http://automationpractice.com/index.php?controller=authentication&back=my-account/";
        public static readonly By EMAIL_FIELD_INPUT = By.Id("email_create");
        public static readonly By SUBMIT_EMAIL_BUTTON = By.Id("SubmitCreate");
    }
}
