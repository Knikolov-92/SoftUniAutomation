using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions
{
    public partial class DraggablePage : BasePage
    {
        //URL
        public const string DRAGGABLE_PAGE_URL = "http://demoqa.com/dragabble/";

        //Locators--------------------        
        public static readonly By DRAG_ME_ELEMENT = By.Id("dragBox");
        public static readonly By CONSTRAINT_AREA = By.CssSelector(".col-12.mt-4.col-md-6");
        public static readonly By BOTTOM_LINE_WIDGET = By.Id("botton-text-10");
        public static readonly By ONLY_X_DRAG_ELEMENT = By.Id("restrictedX");
        public static readonly By ONLY_Y_DRAG_ELEMENT = By.Id("restrictedY");
        public static readonly By NAV_AXIS_TAB = By.Id("draggableExample-tab-axisRestriction");
        //End of Locators--------------------

        //constants
        public static readonly int DRAG_ME_ELEMENT_WIDTH = 100;
        public static readonly int DRAG_ME_ELEMENT_HEIGHT = 40;
        public static readonly int BOTTOM_LINE_WIDGET_WIDTH = 902;
        public static readonly int BOTTOM_LINE_WIDGET_HEIGHT = 30;
    }
}
