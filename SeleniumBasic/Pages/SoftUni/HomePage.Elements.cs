using OpenQA.Selenium;


namespace SeleniumBasic.Pages.SoftUni
{
    public partial class HomePage : BasePage
    {
        public static readonly string SOFTUNI_HOME_PAGE_URL = "http://www.softuni.bg/";
        public static readonly By NAV_BAR_COURSES_BUTTON = By.XPath("//li[@class='nav-item dropdown-item']/a/span[normalize-space(text())='Обучения']");
        public static readonly By QA_AUTOMATION_COURSE_LINK = By.LinkText("QA Automation - май 2020");
    }
}
 