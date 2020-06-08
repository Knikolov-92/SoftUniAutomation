using DemoQA.Pages.Interactions.Resizable;
using NUnit.Framework;
using System.Collections.Generic;

namespace DemoQA.Tests.Interactions
{
    public class Resizable : BaseTest
    {
        private ResizablePage _resizePage;
        [SetUp]
        public void OpenBrowserWindowAndNavigateToResizablePage()
        {
            Initialize();
            _resizePage = new ResizablePage(Driver);
            _resizePage.Open();
        }

        [Test]
        public void RestrictedBoxHasMaxSize_When_ResizingToMaxRestrictions()
        {
            //Arrange            
            int expectedWidth = ResizablePage.CONSTRAINT_AREA_MAX_X;
            int expectedHeight = ResizablePage.CONSTRAINT_AREA_MAX_Y;           
            List<int> expectedSize = new List<int>()
            {
                expectedWidth,
                expectedHeight
            };

            //Act             
            _resizePage.WaitForResizeHandleToBeClickable();
            _resizePage.ResizeRestrictedBoxToMaximum();

            //Assert  
            _resizePage.ValidateRestrictedBoxSize(expectedSize);
        }

        [Test]
        public void RestrictedBoxHasMinSize_When_ResizingToMinRestrictions()
        {
            //Arrange            
            int expectedWidth = ResizablePage.CONSTRAINT_AREA_MIN_X;
            int expectedHeight = ResizablePage.CONSTRAINT_AREA_MIN_Y;
            List<int> expectedSize = new List<int>()
            {
                expectedWidth,
                expectedHeight
            };

            //Act             
            _resizePage.WaitForResizeHandleToBeClickable();
            _resizePage.ResizeRestrictedBoxToMinimum();

            //Assert  
            _resizePage.ValidateRestrictedBoxSize(expectedSize);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
