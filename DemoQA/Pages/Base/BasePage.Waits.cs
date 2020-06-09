using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace DemoQA.Pages
{
    public partial class BasePage
    {
        public static readonly double _maxWaitTime = 10000d;
        public static readonly double _pollInterval = 500d;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending>")]
        public void WaitForElementToBeDisplayed(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
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

        public void WaitForElementToBeClickable(By elementLocator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
#pragma warning disable CS0618 // Type or member is obsolete

            wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public void WaitForElementToBeClickable(IWebElement element)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
#pragma warning disable CS0618 // Type or member is obsolete

            wait.Until(ExpectedConditions.ElementToBeClickable(element));
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public void WaitForElementToBeVisible(By elementLocator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
#pragma warning disable CS0618 // Type or member is obsolete

            wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
