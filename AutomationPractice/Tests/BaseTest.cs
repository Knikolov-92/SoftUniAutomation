using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace AutomationPractice.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
        }

        public void EndSession()
        {
            Driver.Quit();
        }
    }
}
