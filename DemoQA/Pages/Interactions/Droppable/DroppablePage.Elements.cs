using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Droppable
{
    public partial class DroppablePage : BasePage
    {
        //URL
        public const string DROPPABLE_PAGE_URL = "http://demoqa.com/droppable/";

        //Locators--------------------        
        public static readonly By NAV_ACCEPT_BUTTON = By.Id("droppableExample-tab-accept");
        public static readonly By NAV_PREVENT_BUTTON = By.Id("droppableExample-tab-preventPropogation");
        public static readonly By ACCEPTABLE_DRAG_ELEMENT = By.Id("acceptable");
        public static readonly By NOT_ACCEPTABLE_DRAG_ELEMENT = By.Id("notAcceptable");
        public static readonly By DROPBOX_ELEMENT_ACCEPT_TAB = By.CssSelector("#droppableExample-tabpane-accept #droppable");
        public static readonly By OUTER_DROPBOX_ELEMENT_TOP = By.Id("notGreedyDropBox");
        public static readonly By OUTER_DROPBOX_ELEMENT_BOTTOM = By.Id("greedyDropBox");
        public static readonly By DRAG_ME_ELEMENT_PREVENT = By.Id("dragBox");

        public static readonly By OUTER_DROPBOX_ELEMENT_TOP_TEXT = By.CssSelector("#notGreedyDropBox p");
        public static readonly By OUTER_DROPBOX_ELEMENT_BOTTOM_TEXT = By.CssSelector("#greedyDropBox p");
        //End of Locators--------------------

        //constants
        public static readonly string DROPBOX_DROPPED_STATE_TEXT = "Dropped!";
        public static readonly string DROPBOX_NOT_DROPPED_STATE_TEXT = "Drop here";
        public static readonly int DRAG_ME_ELEMENT_HEIGHT = 28;
        public static readonly int INNER_DROPBOX_HEIGHT = 138;
    }
}
