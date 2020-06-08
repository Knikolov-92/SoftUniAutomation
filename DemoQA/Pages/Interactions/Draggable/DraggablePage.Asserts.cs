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

            WaitForDragMeElementToBeClickable();
            actualX = GetDragMeElementPositionX();
            actualY = GetDragMeElementPositionY();           

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

            WaitForOnlyXelementToBeClickable();
            actualX = GetCoordinateXofOnlyXelement();
            actualY = GetCoordinateYofOnlyXelement();           

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
           
            WaitForOnlyYelementToBeClickable();
            actualX = GetCoordinateXofOnlyYelement();
            actualY = GetCoordinateYofOnlyYelement();

            Assert.Multiple(() =>
            {
                Assert.That(actualX, Is.EqualTo(expectedX).Within(_pixelTolerance));
                Assert.That(actualY, Is.EqualTo(expectedY).Within(_pixelTolerance));
            });
        }
    }
}
