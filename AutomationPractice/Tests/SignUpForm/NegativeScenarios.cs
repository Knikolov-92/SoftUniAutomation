using AutomationPractice.Factories;
using AutomationPractice.Models;
using AutomationPractice.Pages.SignIn;
using AutomationPractice.Pages.SignUp;
using AutomationPractice.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace AutomationPractice.Tests.SignUpForm
{
    [TestFixture]
    public class NegativeScenarios : BaseTest
    {
        private SignInPage _signInPage;
        private SignUpPage _signUpPage;
        private string _expectedErrorMessage;
        private List<string> _expectedErrorMessages;
        private SignUpModel _user;
        private DataGenerator _generator;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToSignUpPage()
        {
            Initialize();
            _signInPage = new SignInPage(Driver);
            _signUpPage = new SignUpPage(Driver);
            _generator = new DataGenerator();
            _user = SignUpFactory.CreateUserData();
            _signInPage.Open();
            _signInPage.SubmitEmailAndProceedToSingUpPage();            
        }

        [Test, Order(1)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithInvalidFirstName()
        {
            //----------Arrange----------
            string invalidFirstName = _generator.GenerateRandomStringName(SignUpPage.NAME_MIN_LENGTH)
                                    + _generator.GenerateRandomStringNumber(1);
            _user.FirstName = invalidFirstName;
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.invalidFirstName
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);           
            _signUpPage.SubmitAccountData();                                   

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(2)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithInvalidPassword()
        {
            //----------Arrange----------
            _user.Password = _generator.GenerateRandomStringNumber(SignUpPage.PASSWORD_MIN_LENGTH - 1);
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.invalidPassword
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();                      

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(3)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithInvalidPhoneNumber()
        {
            //----------Arrange----------
            _user.PhoneNumber = _generator.GenerateRandomStringName(SignUpPage.PHONE_MIN_LENGTH);

            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.invalidPhone
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(4)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithInvalidPostalCode()
        {
            //----------Arrange----------
            _user.PostalCode = _generator.GenerateRandomStringNumber(SignUpPage.POSTAL_CODE_LENGTH - 1);

            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.invalidPostalCode
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();           

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(5)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithEmptyFirstName()
        {
            //----------Arrange----------
            _user.FirstName = string.Empty;
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.emptyFirstName
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(6)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithEmptyPassword()
        {
            //----------Arrange----------
            _user.Password = string.Empty;
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.emptyPassword
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(7)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithEmptyPhoneNumber()
        {
            //----------Arrange----------
            _user.PhoneNumber = string.Empty;
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.emptyPhone
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];
            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(8)]
        public void CorrectErrorMessageIsDisplayed_When_RegisteringWithEmptyState()
        {
            //----------Arrange----------            
            List<Enum> expectedError = new List<Enum>
            {
                SignUpPage.Errors.emptyState
            };
            _expectedErrorMessage = _signUpPage.GetExpectedErrorMessages(expectedError)[0];

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.EnterEmptyState();
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertErrorMessageIsDisplayed(_expectedErrorMessage);
        }

        [Test, Order(9)]
        public void CorrectErrorMessagesAreDisplayed_When_RegisteringWithInvalidFirstNameAndPassword()
        {
            //----------Arrange----------
            int randomNumber = new Random().Next(1, SignUpPage.PASSWORD_MIN_LENGTH - 1);

            _user.FirstName = _generator.GenerateRandomStringName(SignUpPage.NAME_MIN_LENGTH)
                                    + _generator.GenerateRandomStringNumber(1);
            _user.Password = _generator.GenerateRandomString(SignUpPage.PASSWORD_MIN_LENGTH - randomNumber);
            List<Enum> expectedErrors = new List<Enum>
            {
                SignUpPage.Errors.invalidPassword,
                SignUpPage.Errors.invalidFirstName
            };
            _expectedErrorMessages = _signUpPage.GetExpectedErrorMessages(expectedErrors);

            //----------Act----------
            _signUpPage.EnterValidAccountData(_user);
            _signUpPage.SubmitAccountData();

            //----------Assert----------
            _signUpPage.AssertListOfErrorMessagesIsDisplayed(_expectedErrorMessages);
        }

        [Test, Order(10)]
        public void CorrectErrorMessagesAreDisplayed_When_RegisteringWithEmptyFields()
        {
            //----------Arrange----------
            List<Enum> expectedErrors = new List<Enum>
            {
                SignUpPage.Errors.emptyFirstName,
                SignUpPage.Errors.emptyLastName,
                SignUpPage.Errors.emptyEmail,
                SignUpPage.Errors.emptyPassword,
                SignUpPage.Errors.emptyAddress,
                SignUpPage.Errors.emptyCity,
                SignUpPage.Errors.emptyCountry,
                SignUpPage.Errors.missingCountryID,
                SignUpPage.Errors.invalidCountry,
                SignUpPage.Errors.emptyPhone,
                SignUpPage.Errors.emptyAlias
            };
            _expectedErrorMessages = _signUpPage.GetExpectedErrorMessages(expectedErrors);

            //----------Act----------
            _signUpPage.EnterEmptyCountry();
            _signUpPage.EnterEmptyEmail();
            _signUpPage.EnterEmptyAlias();
            _signUpPage.SubmitAccountData();        
           
            //----------Assert----------
            _signUpPage.AssertListOfErrorMessagesIsDisplayed(_expectedErrorMessages);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
