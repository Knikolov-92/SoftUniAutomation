using AutomationPractice.Pages.SignUp;
using OpenQA.Selenium;
using System;


namespace AutomationPractice.Pages.SignIn
{
    public partial class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            NavigateTo(SIGN_IN_PAGE_URL);
        }

        public void SubmitEmailAndProceedToSingUpPage()
        {
            Random generator = new Random();

            int randomNumber = generator.Next(1000, 9999);
            string email = "test" + randomNumber + "@example.com";

            WaitForElementToBeDisplayed(EMAIL_FIELD_INPUT);
            FillFieldWithText(EMAIL_FIELD_INPUT, email);
            ClickOn(SUBMIT_EMAIL_BUTTON);
            WaitForElementToBeDisplayed(SignUpPage.ADDRESS_FIELD);
        }
    }
}
