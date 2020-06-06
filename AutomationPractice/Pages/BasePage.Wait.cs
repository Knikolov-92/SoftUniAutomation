﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomationPractice.Pages
{
    public partial class BasePage
    {
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending>")]
        public void WaitForValueOfElementToBeUpdated(By elementLocator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));
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

        public void WaitForElementToBePresent(By elementLocator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(_maxWaitTime));

#pragma warning disable CS0618 // Type or member is obsolete

            wait.Until(ExpectedConditions.ElementExists(elementLocator));
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
