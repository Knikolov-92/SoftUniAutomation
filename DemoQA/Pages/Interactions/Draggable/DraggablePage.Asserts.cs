using NUnit.Framework;
using System.Collections.Generic;


namespace DemoQA.Pages.Interactions
{
    public partial class DraggablePage : BasePage
    {
        private readonly int _pixelTolerance = 5;

        public void ValidatesDragMeElementPosition(List<int> expectedPosition)
        {
            int expectedX = expectedPosition[0];
            int expectedY = expectedPosition[1];            
            int actualX;
            int actualY;
            List<int> actualDragElementPosition = new List<int>();

            WaitForDragMeElementToBeClickable();
            actualX = GetDragMeElementPositionX();
            actualY = GetDragMeElementPositionY();
            actualDragElementPosition.Add(actualX);
            actualDragElementPosition.Add(actualY);

            Assert.Multiple(() =>
            {
                Assert.That(actualX, Is.EqualTo(expectedX).Within(_pixelTolerance));
                Assert.That(actualY, Is.EqualTo(expectedY).Within(_pixelTolerance));
            });
        }

        public void ValidatesOnlyXElementPosition(List<int> expectedPosition)
        {
            int expectedX = expectedPosition[0];
            int expectedY = expectedPosition[1];
            int actualX;
            int actualY;
            List<int> actualDragElementPosition = new List<int>();

            WaitForOnlyXelementToBeClickable();
            actualX = GetCoordinateXofOnlyXelement();
            actualY = GetCoordinateYofOnlyXelement();
            actualDragElementPosition.Add(actualX);
            actualDragElementPosition.Add(actualY);

            Assert.Multiple(() =>
            {
                Assert.That(actualX, Is.EqualTo(expectedX).Within(_pixelTolerance));
                Assert.That(actualY, Is.EqualTo(expectedY).Within(_pixelTolerance));
            });
        }

        public void ValidatesOnlyYElementPosition(List<int> expectedPosition)
        {
            int expectedX = expectedPosition[0];
            int expectedY = expectedPosition[1];
            int actualX;
            int actualY;
            List<int> actualDragElementPosition = new List<int>();

            WaitForOnlyYelementToBeClickable();
            actualX = GetCoordinateXofOnlyYelement();
            actualY = GetCoordinateYofOnlyYelement();
            actualDragElementPosition.Add(actualX);
            actualDragElementPosition.Add(actualY);

            Assert.Multiple(() =>
            {
                Assert.That(actualX, Is.EqualTo(expectedX).Within(_pixelTolerance));
                Assert.That(actualY, Is.EqualTo(expectedY).Within(_pixelTolerance));
            });
        }
    }
}
