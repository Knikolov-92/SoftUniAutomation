using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA.Pages
{
    public partial class BasePage
    {
        protected IWebDriver Driver { get; }
        protected Actions Actions { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(Driver);
        }

        public void NavigateTo(string targetURL)
        {
            Driver.Navigate().GoToUrl(targetURL);
        }

        public void ClickOn(By elementLocator)
        {
            WaitForElementToBeDisplayed(elementLocator);
            Driver.FindElement(elementLocator).Click();
        }

        public string GetElementBackgroundColor(By elementLocator)
        {
            return Driver.FindElement(elementLocator).GetCssValue("background-color");
        }

        public string GetElementBackgroundColor(IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

        public string GetElementText(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Text;
        }

        public string GetElementText(IWebElement element)
        {
            return element.Text;
        }                

        public int GetElementSizeWidth(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Size.Width;
        }

        public int GetElementSizeHeight(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Size.Height;
        }

        public int GetElementPositionX(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Location.X;
        }

        public int GetElementPositionY(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Location.Y;
        }        
    }
}
