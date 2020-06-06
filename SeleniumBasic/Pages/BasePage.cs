using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace SeleniumBasic.Pages
{
    public class BasePage
    {        
        public static readonly double _timeout = 10000d;
        public static readonly double _pollInterval = 500d;

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


        public void WaitForElementToBeDisplayed(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_timeout));
            wait.PollingInterval = TimeSpan.FromMilliseconds(_pollInterval);            
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message = "Element not found";

            wait.Until(condition =>
            {
                try
                {
                    var isDisplayed = Driver.FindElement(elementLocator).Displayed;
                    if (isDisplayed == false)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Type exType = e.GetType();
                    if (exType == typeof(StaleElementReferenceException) ||
                        exType == typeof(NoSuchElementException))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            });
        }

        public void WaitForValueOfElementToBeUpdated(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_timeout));
            wait.PollingInterval = TimeSpan.FromMilliseconds(_pollInterval);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message = "Element not found";
            wait.Until(condition =>
            {
                try
                {
                    var value = Driver.FindElement(elementLocator).GetAttribute("value");
                    if (value == null || value.Equals(string.Empty))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Type exType = e.GetType();
                    if (exType == typeof(StaleElementReferenceException) ||
                        exType == typeof(NoSuchElementException))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            });
        }

    }
}
