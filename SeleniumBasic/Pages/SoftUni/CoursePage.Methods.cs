using OpenQA.Selenium;

namespace SeleniumBasic.Pages.SoftUni
{
    public partial class CoursePage : BasePage
    {
        private HomePage _homePage;

        public CoursePage(IWebDriver driver)
           : base(driver)
        {
            _homePage = new HomePage(Driver);
        }

        public void NavigateToQAAutomationCoursePage()
        {
            _homePage.NavigateToQAmodule();
            ClickOn(QA_AUTOMATION_COURSE_LINK);
        }
    }
}
