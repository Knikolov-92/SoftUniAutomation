using AutoFixture;
using NUnit.Framework;
using SeleniumBasic.Pages.Practice;

namespace SeleniumBasic.Tests.Practice
{
    [TestFixture]
    public class SignInEmail : BaseTest
    {
        private PracticePage _practicePage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToURL()
        {
            Initialize();
            _practicePage = new PracticePage(Driver);
            _practicePage.Open();
        }

        [Test]
        public void CorrectEmailIsTypedInField_When_SigningIn()
        {
            //Arrange
            string randomString = new Fixture().Create<string>();
            string expectedEmail = randomString + "@example.com";

            //Act
            _practicePage.GoToSignInPage();
            _practicePage.CreateAnAccountEmail(expectedEmail);

            //Assert
            _practicePage.AssertInputEmailIsTypedInField(expectedEmail);            
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
