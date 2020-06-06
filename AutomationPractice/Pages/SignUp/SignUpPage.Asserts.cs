using NUnit.Framework;
using System.Collections.Generic;

namespace AutomationPractice.Pages.SignUp
{
    public partial class SignUpPage : BasePage
    {
        public void AssertErrorMessageIsDisplayed(string expectedError)
        {            
            string actualError = GetActualErrorMessages()[0];

            Assert.That(actualError, Is.EqualTo(expectedError));
        }

        public void AssertListOfErrorMessagesIsDisplayed(List<string> expectedErrors)
        {
            List<string> actualErrors = GetActualErrorMessages();

            CollectionAssert.AreEquivalent(expectedErrors, actualErrors);
        }       
    }
}
