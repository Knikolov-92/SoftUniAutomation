using NUnit.Framework;
using SeleniumBasic.Pages.GooglePage;
using SeleniumBasic.Tests;


namespace Selenium.Tests.Google
{
    [TestFixture]
    public class GoogleSearch : BaseTest
    {
        private GooglePage _googlePage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToURL()
        {
            Initialize();            
            _googlePage = new GooglePage(Driver);
            _googlePage.Open();            
        }

        [Test]
        public void CorrectPageTitleIsDisplayed_When_OpeningFirstSearchResult()
        {
            //Arrange
            string keyWord = "selenium";
            string expectedPageTitle = "SeleniumHQ Browser Automation";
            string expectedPageURL = "https://www.selenium.dev/";           

            //Act
            _googlePage.SubmitGoogleSearch(keyWord);
            _googlePage.ClickOnFirstResultLink();                        

            //Assert
            _googlePage.AssertFirstSearchResultLinkIsOpened(expectedPageURL, expectedPageTitle);
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
