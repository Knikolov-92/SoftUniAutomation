using NUnit.Framework;
using SeleniumBasic.Pages.SoftUni;


namespace SeleniumBasic.Tests.SoftUni
{
    [TestFixture]
    public class CourseNavigation : BaseTest
    {
        private HomePage _homePage;
        private CoursePage _coursePage;

        [SetUp]
        public void OpenBrowserWindowAndNavigateToURL()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _coursePage = new CoursePage(Driver);
            _homePage.Open();
        }

        [Test]
        public void CorrectPageIsLoaded_When_NavigatingToQACourse()
        {
            //Arrange
            string expectedPageTitle = "Курс QA Automation - май 2020 - Софтуерен университет";
            string expectedCourseHeading = "QA Automation - май 2020";

            //Act
            _coursePage.NavigateToQAAutomationCoursePage();

            //Assert          
            _coursePage.AssertCorrectCoursePageIsLoaded(expectedPageTitle, expectedCourseHeading);            
        }

        [TearDown]
        public void CloseBrowserWindow()
        {
            EndSession();
        }
    }
}
