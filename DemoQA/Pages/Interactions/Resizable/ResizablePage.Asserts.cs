using NUnit.Framework;
using System.Collections.Generic;

namespace DemoQA.Pages.Interactions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        private readonly int _pixelTolerance = 1;

        public void ValidateRestrictedBoxSize(List<int> expectedBoxSize)
        {
            int expectedWidth = expectedBoxSize[0];
            int expectedHeight = expectedBoxSize[1];
            int actualWidth;
            int actualHeight;

            WaitForResizeHandleToBeClickable();
            actualWidth = GetResizableBoxWidth();
            actualHeight = GetResizableBoxHeight();

            Assert.Multiple(() =>
            {
                Assert.That(actualWidth, Is.EqualTo(expectedWidth).Within(_pixelTolerance));
                Assert.That(actualHeight, Is.EqualTo(expectedHeight).Within(_pixelTolerance));
            });
        }
    }
}
