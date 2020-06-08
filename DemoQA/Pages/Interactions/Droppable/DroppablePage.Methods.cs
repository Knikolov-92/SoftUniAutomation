using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver)
        { }

        public void Open()
        {
            NavigateTo(DROPPABLE_PAGE_URL);
        }
        public void NavigateToAcceptTab()
        {
            ClickOn(NAV_ACCEPT_BUTTON);
        }

        public void NavigateToPreventPropogationTab()
        {
            ClickOn(NAV_PREVENT_BUTTON);
        }

        public void MoveAcceptableDragElementToDropBox()
        {
            DragAndDropElementFromTo(ACCEPTABLE_DRAG_ELEMENT, DROPBOX_ELEMENT_ACCEPT_TAB);
        }

        public void MoveNotAcceptableDragElementToDropBox()
        {
            DragAndDropElementFromTo(NOT_ACCEPTABLE_DRAG_ELEMENT, DROPBOX_ELEMENT_ACCEPT_TAB);
        }        

        public void WaitForDraggableElementToBeClickable()
        {
            WaitForElementToBeClickable(ACCEPTABLE_DRAG_ELEMENT);
            WaitForElementToBeClickable(NOT_ACCEPTABLE_DRAG_ELEMENT);
        }

        public void WaitForDragMeElementToBeClickable()
        {
            WaitForElementToBeClickable(DRAG_ME_ELEMENT_PREVENT);
        }

        public void MoveDragMeElementToTopOuterDropBoxWithOffset(int offsetX, int offsetY)
        {
            DragAndDropElementWithOffsetFromCenter(DRAG_ME_ELEMENT_PREVENT, OUTER_DROPBOX_ELEMENT_TOP, offsetX, offsetY);
        }

        public void MoveDragMeElementToBottomOuterDropBoxWithOffset(int offsetX, int offsetY)
        {
            DragAndDropElementWithOffsetFromCenter(DRAG_ME_ELEMENT_PREVENT, OUTER_DROPBOX_ELEMENT_BOTTOM, offsetX, offsetY);
        }
    }
}
