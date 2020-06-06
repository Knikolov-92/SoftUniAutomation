using OpenQA.Selenium;


namespace AutomationPractice.Pages.SignUp
{
    public partial class SignUpPage : BasePage
    {
        //-------------------------locators----------------------------------------------------------------
        public static readonly By EMAIL_FIELD_OUTPUT = By.Id("email");
        public static readonly By FIRST_NAME_FIELD = By.Id("customer_firstname");
        public static readonly By LAST_NAME_FIELD = By.Id("customer_lastname");
        public static readonly By PASSWORD_FIELD = By.Id("passwd");
        public static readonly By ADDRESS_FIELD = By.Id("address1");
        public static readonly By CITY_FIELD = By.Id("city");
        public static readonly By STATE_DROPDOWN_BUTTON = By.Id("id_state");
        public static readonly By POSTAL_CODE_FIELD = By.Id("postcode");
        public static readonly By COUNTRY_DROPDOWN_BUTTON = By.Id("id_country");
        public static readonly By PHONE_FIELD = By.Id("phone_mobile");
        public static readonly By REGISTER_BUTTON = By.Id("submitAccount");
        public static readonly By ERROR_MESSAGES_LIST = By.CssSelector(".alert.alert-danger ol > li:nth-child(n)");
        public static readonly By ALIAS_FIELD = By.Id("alias");
    }
}
