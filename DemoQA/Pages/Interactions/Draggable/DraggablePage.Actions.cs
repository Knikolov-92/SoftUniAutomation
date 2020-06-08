using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.Interactions
{
    public partial class DraggablePage : BasePage
    {
        public void MoveOnlyXelementVerticallyDownByOffset(int offset)
        {
            DragAndDropElementWithOffsetFromCenter(ONLY_X_DRAG_ELEMENT,
                                                   ONLY_X_DRAG_ELEMENT,
                                                   0,
                                                   0 + offset);
        }

        public void MoveOnlyYelementHorizontallyToTheLeftByOffset(int offset)
        {
            DragAndDropElementWithOffsetFromCenter(ONLY_Y_DRAG_ELEMENT,
                                                   ONLY_Y_DRAG_ELEMENT,
                                                   0 - offset,
                                                   0 );
        }

        public void MoveDragMeElementToUpperLeftCornerOfWidget()
        {
            DragAndDropElementWithOffsetFromTopLeft(DRAG_ME_ELEMENT,
                                                      BOTTOM_LINE_WIDGET,
                                                      0 + DRAG_ME_ELEMENT_WIDTH / 2,
                                                      0 - DRAG_ME_ELEMENT_HEIGHT / 2 );
        }

        public void MoveDragMeElementToBottomRightCornerOfWidget()
        {
            DragAndDropElementWithOffsetFromTopLeft(DRAG_ME_ELEMENT,
                                                    BOTTOM_LINE_WIDGET,
                                                    0 + BOTTOM_LINE_WIDGET_WIDTH - DRAG_ME_ELEMENT_WIDTH / 2,
                                                    0 + BOTTOM_LINE_WIDGET_HEIGHT + DRAG_ME_ELEMENT_HEIGHT / 2 );
        }        
    }
}
