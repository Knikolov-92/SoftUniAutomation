using OpenQA.Selenium;


namespace SeleniumBasic.Pages.SoftUni
{
    public partial class CoursePage : BasePage
    {
        public static readonly By QA_AUTOMATION_COURSE_LINK = By.XPath("//*[@class='box-content']/h4[contains(text(), 'QA Automation')]");
        public static readonly By COURSE_MAIN_HEADING = By.XPath("//h1[@class='text-center']");
    }
}
