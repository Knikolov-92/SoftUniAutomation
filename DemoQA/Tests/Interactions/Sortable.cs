using DemoQA.Pages.Interactions.Sortable;
using NUnit.Framework;
using System.Collections.Generic;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        private SortablePage _sortPage;
        [SetUp]
        public void OpenBrowserWindowAndNavigateToSortablePage()
        {
            Initialize();
            _sortPage = new SortablePage(Driver);
            _sortPage.Open();
        }

        [Test]
        public void ListOfElementsIsDisplayedCorrectly_When_SortingAllinDescendingOrder()
        {
            //Arrange            
            List<string> expectedElementsOrder = new List<string>
            {
                "Six", "Five", "Four", "Three", "Two", "One"
            };

            //Act
            _sortPage.WaitForListElementsToBeDisplayed();
            _sortPage.SortAllListElementsInDescendingOrder();           

            //Assert
            _sortPage.ValidateOrderOfSortedElements(expectedElementsOrder);
        }

        [Test]
        public void GridOfElementsIsDisplayedCorrectly_When_SortingAllinDescendingOrder()
        {
            //Arrange
            List<string> expectedElementsOrder = new List<string>
            {
                "Nine", "Eight", "Seven","Six", "Five", "Four", "Three", "Two", "One"
            };

            //Act
            _sortPage.NavigateToGridTab();
            _sortPage.WaitForGridElementsToBeDisplayed();
            _sortPage.SortAllGridElementsInDescendingOrder();

            //Assert
            _sortPage.ValidateOrderOfSortedElements(expectedElementsOrder);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
