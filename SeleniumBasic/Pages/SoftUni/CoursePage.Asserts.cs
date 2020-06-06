using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumBasic.Pages.SoftUni
{
    public partial class CoursePage : BasePage
    {
        public CoursePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void AssertCorrectCoursePageIsLoaded(string expectedPageTitle, string expectedCourseHeading)
        {
            string actualPageTitle = Driver.Title;
            WaitForElementToBeDisplayed(COURSE_MAIN_HEADING);
            string actualCourseHeading = GetElementText(COURSE_MAIN_HEADING);

            Assert.Multiple(() =>
            {
                Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle));
                Assert.That(actualCourseHeading, Is.EqualTo(expectedCourseHeading));
            });
        }
    }
}
