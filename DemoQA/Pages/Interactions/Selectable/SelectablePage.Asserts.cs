using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;


namespace DemoQA.Pages.Interactions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public void ValidateListElementIsSelected(int elementIndex, string defaultColor)
        {
            List<IWebElement> elementsList = Driver.FindElements(LIST_ALL_ELEMENTS).ToList();
            IWebElement selectedElement = elementsList[elementIndex];
            string actualElementColor = GetElementBackgroundColor(selectedElement);
            string expectedElementText = GetExpectedListElementText(elementIndex);
            string actualElementText = selectedElement.Text;
            
            Assert.Multiple(() =>
            {
                Assert.That(actualElementColor, Is.Not.SameAs(defaultColor));
                Assert.That(actualElementText, Is.EqualTo(expectedElementText));
            });
        }

        public void ValidateGridElementIsSelected(int elementIndex, string defaultColor)
        {
            List<IWebElement> elementsList = Driver.FindElements(GRID_ALL_ELEMENTS).ToList();
            IWebElement selectedElement = elementsList[elementIndex];
            string actualElementColor = GetElementBackgroundColor(selectedElement);
            string expectedElementText = GetExpectedGridElementText(elementIndex);
            string actualElementText = selectedElement.Text;
                        
            Assert.Multiple(() =>
            {
                Assert.That(actualElementColor, Is.Not.SameAs(defaultColor));
                Assert.That(actualElementText, Is.EqualTo(expectedElementText));
            });
        }
    }
}
