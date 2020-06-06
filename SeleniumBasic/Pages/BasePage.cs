using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasic.Pages
{
    public class BasePage
    {        
        public readonly double _timeout = 10000d;
        public readonly double _pollInterval = 500d;
        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }


        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }       


        public void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element); 
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
                      

        public void NavigateToURL(string targetURL)
        {
            Driver.Navigate().GoToUrl(targetURL);
        }

        public void ClickOnWebElement(By elementLocator)
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
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Driver);
            wait.Timeout = TimeSpan.FromMilliseconds(_timeout);
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
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Driver);
            wait.Timeout = TimeSpan.FromMilliseconds(_timeout);
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
