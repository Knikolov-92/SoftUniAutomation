using OpenQA.Selenium;


namespace SeleniumBasic.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {        
        public static readonly string GOOGLE_HOME_PAGE_URL = "http://google.com/";
        public static readonly By SEARCH_INPUT_FIELD = By.Name("q");
        public static readonly By FIRST_SEARCH_RESULT = By.CssSelector(".r a h3[class]");
    }

}
