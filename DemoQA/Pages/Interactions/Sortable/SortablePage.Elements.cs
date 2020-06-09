using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Sortable
{
    public partial class SortablePage : BasePage
    {
        //URL        
        public const string SORTABLE_PAGE_URL = "http://demoqa.com/sortable/";

        //Locators--------------------
        //LIST
        public static readonly By LIST_FIRST_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(1)");
        public static readonly By LIST_SECOND_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(2)");
        public static readonly By LIST_THIRD_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(3)");
        public static readonly By LIST_FOURTH_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(4)");
        public static readonly By LIST_FIFTH_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(5)");
        public static readonly By LIST_SIXTH_ELEMENT = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action:nth-child(6)");
        public static readonly By LIST_ALL_ELEMENTS = By.CssSelector("#demo-tabpane-list .list-group-item.list-group-item-action");

        //NAV
        public static readonly By GRID_BUTTON = By.Id("demo-tab-grid");

        //GRID
        public static readonly By GRID_FIRST_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(1)");
        public static readonly By GRID_SECOND_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(2)");
        public static readonly By GRID_THIRD_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(3)");
        public static readonly By GRID_FOURTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(4)");
        public static readonly By GRID_FIFTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(5)");
        public static readonly By GRID_SIXTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(6)");
        public static readonly By GRID_SEVENTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(7)");
        public static readonly By GRID_EIGHTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(8)");
        public static readonly By GRID_NINTH_ELEMENT = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action:nth-child(9)");
        public static readonly By GRID_ALL_ELEMENTS = By.CssSelector("#demo-tabpane-grid .list-group-item.list-group-item-action");

        //Others
        public static readonly By BOTTOM_END_OF_LIST = By.Id("botton-text-10");

        //End of Locators--------------------

        //constants
        public static readonly int LIST_ELEMENT_HEIGHT = 50;
        public static readonly int LIST_ELEMENT_PADDING = 12;
        public static readonly int GRID_ELEMENT_HEIGHT = 90;
        public static readonly int GRID_ELEMENT_PADDING = 32;
    }
}
