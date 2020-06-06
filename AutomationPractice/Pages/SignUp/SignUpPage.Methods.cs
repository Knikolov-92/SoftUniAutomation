using AutomationPractice.Models;
using AutomationPractice.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace AutomationPractice.Pages.SignUp
{
    public partial class SignUpPage : BasePage
    {
        public SignUpPage(IWebDriver driver)
            : base(driver)
        {
        }        

        public void EnterValidAccountData(SignUpModel user)
        {
            string country = "United States";
            string state = GetRandomUnitedStateFromEnum();

            FillFieldWithText(FIRST_NAME_FIELD, user.FirstName);
            FillFieldWithText(LAST_NAME_FIELD, user.LastName);
            FillFieldWithText(PASSWORD_FIELD, user.Password);
            FillFieldWithText(ADDRESS_FIELD, user.Address);
            FillFieldWithText(CITY_FIELD, user.City);
            SelectCountryAndState(country, state);
            FillFieldWithText(POSTAL_CODE_FIELD, user.PostalCode);
            FillFieldWithText(PHONE_FIELD, user.PhoneNumber);            
        }

        public string GetRandomUnitedStateFromEnum()
        {
            string stateName;
            var state = GetRandomValueFromEnum<UnitedStates>();
            stateName = GetAttribute<EnumStringAttribute>(state).Name;

            return stateName;
        }

        public void SelectCountryAndState(string targetCountry, string targetState)
        {
            SelectOptionFromDropDown(COUNTRY_DROPDOWN_BUTTON, targetCountry);
            WaitForElementToBePresent(STATE_DROPDOWN_BUTTON);
            MovePointerTo(REGISTER_BUTTON);
            SelectOptionFromDropDown(STATE_DROPDOWN_BUTTON, targetState);
        }

        public void SubmitAccountData()
        {
            ClickOn(REGISTER_BUTTON);
        }

        public List<string> GetExpectedErrorMessages(List<Enum> listOfErrors)
        {
            List<string> errorMessages = new List<string>();
            string message;

            foreach (Enum error in listOfErrors)
            {
                message = GetAttribute<EnumStringAttribute>(error).Name;

                errorMessages.Add(message);
            }
            return errorMessages;
        }

        public List<string> GetActualErrorMessages()
        {
            List<string> currentMessagesText = new List<string>();

            WaitForErrorMessagesToBeDisplayed();
            var currentMessageElements = Driver.FindElements(ERROR_MESSAGES_LIST);

            foreach (IWebElement element in currentMessageElements)
            {
                currentMessagesText.Add(element.Text);
            }

            return currentMessagesText;
        }               

        public void WaitForErrorMessagesToBeDisplayed()
        {
            WaitForElementToBeDisplayed(ERROR_MESSAGES_LIST);
        }     

        public void EnterEmptyState()
        {
            string emptyState = "-";

            SelectOptionFromDropDown(STATE_DROPDOWN_BUTTON, emptyState);
        }

        public void EnterEmptyCountry()
        {
            string emptyCountry = "-";

            SelectOptionFromDropDown(COUNTRY_DROPDOWN_BUTTON, emptyCountry);
        }

        public void EnterEmptyEmail()
        {
            ClearFieldText(EMAIL_FIELD_OUTPUT);
        }

        public void EnterEmptyAlias()
        {
            ClearFieldText(ALIAS_FIELD);
        }
    }
}
