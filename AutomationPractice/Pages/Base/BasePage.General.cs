using AutomationPractice.Utils;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Reflection;

namespace AutomationPractice.Pages
{
    public partial class BasePage
    {      
        protected IWebDriver Driver { get; }
        protected DataGenerator Generator { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Generator = new DataGenerator();
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

        public void ClearFieldText(By fieldLocator)
        {
            Driver.FindElement(fieldLocator).Clear();
        }                   

        public void SelectOptionFromDropDown(By elementLocator, string text)
        {
            var option = Driver.FindElement(elementLocator);
            var selection = new SelectElement(option);
            selection.SelectByText(text);
        }                

        public void MovePointerTo(By elementLocator)
        {
            Actions actions = new Actions(Driver);
            var element = Driver.FindElement(elementLocator);

            actions.MoveToElement(element);
            actions.Perform();
        }

        public T GetAttribute<T>(Enum enumValue) where T : Attribute
        {
            T attribute;
            MemberInfo memberInfo = enumValue.GetType()
                                    .GetMember(enumValue.ToString())
                                    .FirstOrDefault();

            if (memberInfo != null)
            {
                attribute = (T)memberInfo.GetCustomAttributes(typeof(T), false)
                            .SingleOrDefault();

                return attribute;
            }
            else
            {
                return null;
            }
        }

        public T GetRandomValueFromEnum<T>()
        {
            Randomizer rnd = new Randomizer();
            var values = Enum.GetValues(typeof(T));
            int number = rnd.Next(0, values.Length);

            return (T)values.GetValue(number);
        }        
    }
}