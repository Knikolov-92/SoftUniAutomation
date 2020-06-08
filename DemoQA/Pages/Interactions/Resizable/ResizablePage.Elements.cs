using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        //URL
        public const string RESIZABLE_PAGE_URL = "http://demoqa.com/resizable/";

        //Locators--------------------        
        public static readonly By RESIZABLE_BOX_WITH_RESTRICTION = By.Id("resizableBoxWithRestriction");
        public static readonly By RESIZE_HANDLE_BUTTON_RESTRICTED = By.CssSelector("#resizableBoxWithRestriction .react-resizable-handle.react-resizable-handle-se");
        public static readonly By CONSTRAINT_AREA = By.ClassName("constraint-area");
        //End of Locators--------------------

        //constants
        public static readonly int CONSTRAINT_AREA_MAX_X = 500;
        public static readonly int CONSTRAINT_AREA_MAX_Y = 300;
        public static readonly int CONSTRAINT_AREA_MIN_X = 150;
        public static readonly int CONSTRAINT_AREA_MIN_Y = 150;
        public static readonly int RESIZABLE_BOX_HANDLE_WIDTH = 20;
        public static readonly int RESIZABLE_BOX_HANDLE_HEIGHT = 20;
    }
}
