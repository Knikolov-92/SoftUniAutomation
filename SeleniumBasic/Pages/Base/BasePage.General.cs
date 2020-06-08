using OpenQA.Selenium;


namespace SeleniumBasic.Pages
{
    public partial class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
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

        public void FillFieldWithText(By textFieldLocator, string text)
        {
            Driver.FindElement(textFieldLocator).SendKeys(text);
        }

        public string GetElementText(By elementLocator)
        {
            return Driver.FindElement(elementLocator).Text;
        }

        public string GetElementValue(By elementLocator)
        {
            return Driver.FindElement(elementLocator).GetAttribute("value");
        }
    }
}
