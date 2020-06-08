

namespace DemoQA.Pages.Interactions
{
    public partial class DraggablePage : BasePage
    {
        public void WaitForDragMeElementToBeClickable()
        {
            WaitForElementToBeClickable(DRAG_ME_ELEMENT);
        }

        public void WaitForOnlyXelementToBeClickable()
        {
            WaitForElementToBeClickable(ONLY_X_DRAG_ELEMENT);
        }

        public void WaitForOnlyYelementToBeClickable()
        {
            WaitForElementToBeClickable(ONLY_Y_DRAG_ELEMENT);
        }
    }
}
