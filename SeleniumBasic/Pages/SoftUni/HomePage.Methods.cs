using OpenQA.Selenium;


namespace SeleniumBasic.Pages.SoftUni
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            NavigateTo(SOFTUNI_HOME_PAGE_URL);
        }

        public void NavigateToQAAutomationCoursePage()
        {
            ClickOn(NAV_BAR_COURSES_BUTTON);
            ClickOn(QA_AUTOMATION_COURSE_LINK);
        }
    }
}
