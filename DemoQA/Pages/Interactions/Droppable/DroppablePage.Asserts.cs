using NUnit.Framework;
using OpenQA.Selenium;


namespace DemoQA.Pages.Interactions.Droppable
{
    public partial class DroppablePage : BasePage
    {

        public void ValidateDropBoxHasChangedAppearance(By dropBoxLocator, string defaultColor, string expectedText)
        {
            IWebElement dropBox = Driver.FindElement(dropBoxLocator);
            string actualDropBoxColor = dropBox.GetCssValue("background-color");
            string actualDropBoxText;

            //workaround, currently innerbox element' text is added to the outer's one
            if (dropBoxLocator == OUTER_DROPBOX_ELEMENT_TOP)
            {
                actualDropBoxText = Driver.FindElement(OUTER_DROPBOX_ELEMENT_TOP_TEXT).Text;
            }
            else if (dropBoxLocator == OUTER_DROPBOX_ELEMENT_BOTTOM)
            {
                actualDropBoxText = Driver.FindElement(OUTER_DROPBOX_ELEMENT_BOTTOM_TEXT).Text;
            }
            else
            {
                actualDropBoxText = dropBox.Text;
            }

            Assert.Multiple( () =>
            {
                Assert.That(actualDropBoxColor, Is.Not.EqualTo(defaultColor));
                Assert.That(actualDropBoxText, Is.EqualTo(expectedText));
            });
        }

        public void ValidateDropBoxHasNotChangedAppearance(By dropBoxLocator, string defaultColor, string expectedText)
        {
            IWebElement dropBox = Driver.FindElement(dropBoxLocator);
            string actualDropBoxColor = dropBox.GetCssValue("background-color");
            string actualDropBoxText = dropBox.Text;

            Assert.Multiple( () =>
            {
                Assert.That(actualDropBoxColor, Is.EqualTo(defaultColor));
                Assert.That(actualDropBoxText, Is.EqualTo(expectedText));
            });
        }
    }
}
