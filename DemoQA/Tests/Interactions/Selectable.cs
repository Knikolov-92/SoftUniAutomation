using DemoQA.Pages.Interactions.Selectable;
using NUnit.Framework;


namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class Selectable : BaseTest
    {
        private SelectablePage _selectPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToSelectablePage()
        {
            Initialize();
            _selectPage = new SelectablePage(Driver);
            _selectPage.Open();
        }

        [Test]
        public void CorrectElementIsSelected_When_ClickingOnRandomListElement()
        {
            //Arrange
            int indexOfSelectedElement;
            string defaultColorOfElements;

            //Act
            _selectPage.WaitForListElementsToBeDisplayed();
            defaultColorOfElements = _selectPage.GetElementBackgroundColor(SelectablePage.LIST_ALL_ELEMENTS);
            indexOfSelectedElement = _selectPage.SelectRandomListElement();

            //Assert
            _selectPage.ValidateListElementIsSelected(indexOfSelectedElement, defaultColorOfElements);
        }

        [Test]
        public void CorrectElementIsSelected_When_ClickingOnRandomGridElement()
        {
            //Arrange
            int indexOfSelectedElement;
            string defaultColorOfElements;

            //Act
            _selectPage.NavigatesToGridTab();
            _selectPage.WaitForGridElementsToBeDisplayed();
            indexOfSelectedElement = _selectPage.SelectRandomGridElement();
            defaultColorOfElements = _selectPage.GetElementBackgroundColor(SelectablePage.GRID_ALL_ELEMENTS);

            //Assert
            _selectPage.ValidateGridElementIsSelected(indexOfSelectedElement, defaultColorOfElements);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
