using DemoQA.Pages.Interactions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DemoQA.Tests.Interactions
{
    [TestFixture]
    public class Draggable : BaseTest
    {
        private DraggablePage _dragPage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToDraggablePage()
        {
            Initialize();
            _dragPage = new DraggablePage(Driver);
            _dragPage.Open();
        }

        [Test]
        public void DragMeElementChangesPosition_When_MovingToTheUpperLeftCornerOfWidget()
        {
            //Arrange            
            int expectedPositionX;
            int expectedPositionY;            
            List<int> expectedDragElementPosition = new List<int>();           

            //Act             
            _dragPage.WaitForDragMeElementToBeClickable();
            expectedPositionX = _dragPage.GetCoordinateXofWidgetUpperLeftCorner();
            expectedPositionY = _dragPage.GetCoordinateYofWidgetUpperLeftCorner() - DraggablePage.DRAG_ME_ELEMENT_HEIGHT;
            expectedDragElementPosition.Add(expectedPositionX);
            expectedDragElementPosition.Add(expectedPositionY);
            _dragPage.MoveDragMeElementToUpperLeftCornerOfWidget();            

            //Assert  
            _dragPage.ValidatesDragMeElementPosition(expectedDragElementPosition);
        }

        [Test]
        public void DragMeElementChangesPosition_When_MovingToTheBottomRightCornerOfWidget()
        {
            //Arrange            
            int expectedPositionX;
            int expectedPositionY;
            List<int> expectedDragElementPosition = new List<int>();           

            //Act             
            _dragPage.WaitForDragMeElementToBeClickable();
            expectedPositionX = _dragPage.GetCoordinateXofWidgetBottomRightCorner() - DraggablePage.DRAG_ME_ELEMENT_WIDTH;
            expectedPositionY = _dragPage.GetCoordinateYofWidgetBottomRightCorner();
            expectedDragElementPosition.Add(expectedPositionX);
            expectedDragElementPosition.Add(expectedPositionY);
            _dragPage.MoveDragMeElementToBottomRightCornerOfWidget();           

            //Assert  
            _dragPage.ValidatesDragMeElementPosition(expectedDragElementPosition);
        }

        [Test]
        public void OnlyXelementDoesNotChangePosition_When_MovingVertically()
        {
            //Arrange            
            int expectedPositionX;
            int expectedPositionY;
            List<int> expectedDragElementPosition = new List<int>();
            int offsetY;

            //Act             
            _dragPage.NavigateToAxisTab();
            _dragPage.WaitForOnlyXelementToBeClickable();
            expectedPositionX = _dragPage.GetCoordinateXofOnlyXelement();
            expectedPositionY = _dragPage.GetCoordinateYofOnlyXelement();
            expectedDragElementPosition.Add(expectedPositionX);
            expectedDragElementPosition.Add(expectedPositionY);
            offsetY = new Random().Next(1, _dragPage.GetCoordinateYofWidgetUpperLeftCorner() - expectedPositionY);
            _dragPage.MoveOnlyXelementVerticallyDownByOffset(offsetY);     

            //Assert  
            _dragPage.ValidatesOnlyXElementPosition(expectedDragElementPosition);
        }

        [Test]
        public void OnlyYelementDoesNotChangePosition_When_MovingHorizontally()
        {
            //Arrange            
            int expectedPositionX;
            int expectedPositionY;            
            List<int> expectedDragElementPosition = new List<int>();
            int offsetX;

            //Act             
            _dragPage.NavigateToAxisTab();
            _dragPage.WaitForOnlyYelementToBeClickable();
            expectedPositionX = _dragPage.GetCoordinateXofOnlyYelement();
            expectedPositionY = _dragPage.GetCoordinateYofOnlyYelement();
            expectedDragElementPosition.Add(expectedPositionX);
            expectedDragElementPosition.Add(expectedPositionY);
            offsetX = new Random().Next(1, expectedPositionX - _dragPage.GetCoordinateXofConstraintArea());
            _dragPage.MoveOnlyYelementHorizontallyToTheLeftByOffset(offsetX);           

            //Assert  
            _dragPage.ValidatesOnlyYElementPosition(expectedDragElementPosition);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
