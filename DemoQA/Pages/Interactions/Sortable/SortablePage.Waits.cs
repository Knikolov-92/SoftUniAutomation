
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQA.Pages.Interactions.Sortable
{
    public partial class SortablePage : BasePage
    {

        public void WaitForListElementsToBeDisplayed()
        {
            WaitForElementToBeDisplayed(LIST_SIXTH_ELEMENT);
        }

        public void WaitForGridElementsToBeDisplayed()
        {
            WaitForElementToBeDisplayed(GRID_NINTH_ELEMENT);
        }        
    }
}
