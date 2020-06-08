using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver)
        { }

        public void Open()
        {
            NavigateTo(RESIZABLE_PAGE_URL);
        }

        public void WaitForResizeHandleToBeClickable()
        {
            WaitForElementToBeDisplayed(RESIZE_HANDLE_BUTTON_RESTRICTED);
        }

        public void ResizeRestrictedBoxToMaximum()
        {
            DragAndDropElementWithOffsetFromTopLeft(RESIZE_HANDLE_BUTTON_RESTRICTED,
                                                    CONSTRAINT_AREA,
                                                    CONSTRAINT_AREA_MAX_X + RESIZABLE_BOX_HANDLE_WIDTH / 2,
                                                    CONSTRAINT_AREA_MAX_Y + RESIZABLE_BOX_HANDLE_HEIGHT / 2);
        }

        public void ResizeRestrictedBoxToMinimum()
        {
            DragAndDropElementWithOffsetFromTopLeft(RESIZE_HANDLE_BUTTON_RESTRICTED,
                                                    CONSTRAINT_AREA,
                                                    CONSTRAINT_AREA_MIN_X - RESIZABLE_BOX_HANDLE_WIDTH / 2,
                                                    CONSTRAINT_AREA_MIN_Y - RESIZABLE_BOX_HANDLE_HEIGHT / 2);
        }

        public int GetResizableBoxWidth()
        {
            return GetElementSizeWidth(RESIZABLE_BOX_WITH_RESTRICTION);
        }

        public int GetResizableBoxHeight()
        {
            return GetElementSizeHeight(RESIZABLE_BOX_WITH_RESTRICTION);
        }        
    }
}
