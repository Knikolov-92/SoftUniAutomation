﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages
{
    public partial class BasePage
    {

        public void DragAndDropElementFromTo(By sourceElement, By targetElement)
        {
            IWebElement dragElement = Driver.FindElement(sourceElement);
            IWebElement dropElement = Driver.FindElement(targetElement);

            Actions.MoveToElement(dragElement)
                   .ClickAndHold(dragElement)
                   .MoveToElement(dropElement)
                   .Release()
                   .Build()
                   .Perform();
        }

        public void DragAndDropElementWithOffset(By fromElement, By toElement, int offset)
        {
            Actions actions = new Actions(Driver);
            IWebElement dragElement = Driver.FindElement(fromElement);
            IWebElement dropElement = Driver.FindElement(toElement);

            actions.MoveToElement(dragElement)
                   .ClickAndHold(dragElement)
                   .MoveToElement(dropElement, dropElement.Location.X, offset)
                   .Release(dropElement)
                   .Perform();
        }

        public void DragAndDropElementWithOffsetFromCenter(By fromElement, By toElement, int offsetX, int offsetY)
        {
            IWebElement dragElement = Driver.FindElement(fromElement);
            IWebElement dropElement = Driver.FindElement(toElement);           

            Actions.MoveToElement(dragElement)
                   .ClickAndHold(dragElement)
                   .MoveToElement(dropElement, offsetX, offsetY, MoveToElementOffsetOrigin.Center)
                   .Release()
                   .Build()
                   .Perform();
        }

        public void DragAndDropElementWithOffsetFromTopLeft(By fromElement, By toElement, int оffsetX, int оffsetY)
        {
            IWebElement dragElement = Driver.FindElement(fromElement);
            IWebElement dropElement = Driver.FindElement(toElement);            

            Actions.MoveToElement(dragElement)
                   .ClickAndHold(dragElement)
                   .MoveToElement(dropElement, оffsetX, оffsetY, MoveToElementOffsetOrigin.TopLeft)
                   .Release()
                   .Build()
                   .Perform();
        }
    }
}
