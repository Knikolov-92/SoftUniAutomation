

namespace DemoQA.Pages.Interactions.Selectable
{
    public partial class SelectablePage : BasePage
    {

        public void WaitForListElementsToBeDisplayed()
        {
            WaitForElementToBeDisplayed(LIST_ALL_ELEMENTS);
        }       

        public void WaitForGridElementsToBeDisplayed()
        {
            WaitForElementToBeDisplayed(GRID_ALL_ELEMENTS);
        }       
    }
}
