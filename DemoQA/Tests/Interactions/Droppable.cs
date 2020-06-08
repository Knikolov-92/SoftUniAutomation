using DemoQA.Pages.Interactions.Droppable;
using NUnit.Framework;


namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePage _dropPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToDroppablePage()
        {
            Initialize();
            _dropPage = new DroppablePage(Driver);
            _dropPage.Open();
        }

        [Test]
        public void DropBoxChangesItsAppearance_When_AcceptableElementIsDraggedToIt()
        {
            //Arrange
            string defaultElementsColor;
            string expectedElementText = DroppablePage.DROPBOX_DROPPED_STATE_TEXT;

            //Act
            _dropPage.NavigateToAcceptTab();
            _dropPage.WaitForDraggableElementToBeClickable();
            defaultElementsColor = _dropPage.GetElementBackgroundColor(DroppablePage.DROPBOX_ELEMENT_ACCEPT_TAB);
            _dropPage.MoveAcceptableDragElementToDropBox();

            //Assert            
            _dropPage.ValidateDropBoxHasChangedAppearance(DroppablePage.DROPBOX_ELEMENT_ACCEPT_TAB, defaultElementsColor, expectedElementText);
        }

        [Test]
        public void DropBoxDoesNotChangesItsAppearance_When_NotAcceptableElementIsDraggedToIt()
        {
            //Arrange
            string defaultElementsColor;
            string expectedElementText = DroppablePage.DROPBOX_NOT_DROPPED_STATE_TEXT;

            //Act
            _dropPage.NavigateToAcceptTab();
            _dropPage.WaitForDraggableElementToBeClickable();
            defaultElementsColor = _dropPage.GetElementBackgroundColor(DroppablePage.DROPBOX_ELEMENT_ACCEPT_TAB);
            _dropPage.MoveNotAcceptableDragElementToDropBox();

            //Assert            
            _dropPage.ValidateDropBoxHasNotChangedAppearance(DroppablePage.DROPBOX_ELEMENT_ACCEPT_TAB, defaultElementsColor, expectedElementText);
        }

        [Test]
        public void OuterDropBoxesChangeTheirAppearances_When_DragMeElementIsDraggedToThem()
        {
            //Arrange
            string defaultElementsColor;
            string expectedElementText = DroppablePage.DROPBOX_DROPPED_STATE_TEXT;
            int offsetX = 0;
            int offsetY = -DroppablePage.INNER_DROPBOX_HEIGHT / 2
                        - DroppablePage.DRAG_ME_ELEMENT_HEIGHT;

            //Act            
            _dropPage.NavigateToPreventPropogationTab();
            _dropPage.WaitForDragMeElementToBeClickable();
            defaultElementsColor = _dropPage.GetElementBackgroundColor(DroppablePage.OUTER_DROPBOX_ELEMENT_TOP);
            _dropPage.MoveDragMeElementToTopOuterDropBoxWithOffset(offsetX, offsetY);
            _dropPage.WaitForDragMeElementToBeClickable();
            _dropPage.MoveDragMeElementToBottomOuterDropBoxWithOffset(offsetX, offsetY);

            //Assert            
            _dropPage.ValidateDropBoxHasChangedAppearance(DroppablePage.OUTER_DROPBOX_ELEMENT_TOP, defaultElementsColor, expectedElementText);
            _dropPage.ValidateDropBoxHasChangedAppearance(DroppablePage.OUTER_DROPBOX_ELEMENT_BOTTOM, defaultElementsColor, expectedElementText);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
