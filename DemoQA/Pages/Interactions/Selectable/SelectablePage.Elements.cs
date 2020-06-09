using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        //URL
        public const string SELECTABLE_PAGE_URL = "http://demoqa.com/selectable/";

        //Locators---------------------------
        public static readonly By LIST_ALL_ELEMENTS = By.CssSelector("#verticalListContainer li");
        public static readonly By GRID_ALL_ELEMENTS = By.CssSelector("#gridContainer li");
        public static readonly By GRID_BUTTON = By.Id("demo-tab-grid");

        //End of Locators--------------------
    }
}
