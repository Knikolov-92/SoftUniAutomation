using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoQA.Pages.Interactions.Sortable
{
    public partial class SortablePage : BasePage
    {

        public SortablePage(IWebDriver driver)
            : base(driver)
        { }

        public void Open()
        {
            NavigateTo(SORTABLE_PAGE_URL);
        }

        public void NavigateToGridTab()
        {
            ClickOn(GRID_BUTTON);
        }        

        public void SortAllListElementsInDescendingOrder()
        {
            int offsetY = LIST_ELEMENT_HEIGHT - LIST_ELEMENT_PADDING;

            //works on resolution 1920x1080, 24'' display
            DragAndDropElementWithOffset(LIST_FIRST_ELEMENT, BOTTOM_END_OF_LIST, 0);
            WaitForElementToBeVisible(LIST_FIRST_ELEMENT);

            DragAndDropElementWithOffset(LIST_FIRST_ELEMENT, LIST_SIXTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(LIST_FIRST_ELEMENT);

            DragAndDropElementWithOffset(LIST_FIRST_ELEMENT, LIST_FIFTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(LIST_FIRST_ELEMENT);

            DragAndDropElementWithOffset(LIST_FIRST_ELEMENT, LIST_FOURTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(LIST_FIRST_ELEMENT);

            DragAndDropElementWithOffset(LIST_FIRST_ELEMENT, LIST_THIRD_ELEMENT, offsetY);
            WaitForElementToBeVisible(LIST_FIRST_ELEMENT);
        }

        public List<string> GetActualOrderOfSortedListElements()
        {
            ReadOnlyCollection<IWebElement> sortedElements;
            List<string> orderOfElements = new List<string>();

            sortedElements = Driver.FindElements(LIST_ALL_ELEMENTS);
            foreach (IWebElement elem in sortedElements)
            {
                orderOfElements.Add(elem.Text);
            }
            return orderOfElements;
        }

        public void SortAllGridElementsInDescendingOrder()
        {
            int offsetY = 0;

            //works on resolution 1920x1080, 24'' display
            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, BOTTOM_END_OF_LIST, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_NINTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_EIGHTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_SEVENTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_SIXTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_FIFTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_FOURTH_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);

            DragAndDropElementWithOffset(GRID_FIRST_ELEMENT, GRID_THIRD_ELEMENT, offsetY);
            WaitForElementToBeVisible(GRID_FIRST_ELEMENT);            
        }

        public List<string> GetActualOrderOfSortedGridElements()
        {
            ReadOnlyCollection<IWebElement> sortedElements;
            List<string> orderOfElements = new List<string>();

            sortedElements = Driver.FindElements(GRID_ALL_ELEMENTS);
            foreach (IWebElement elem in sortedElements)
            {
                orderOfElements.Add(elem.Text);
            }
            return orderOfElements;
        }        
    }
}
