using NUnit.Framework;


namespace SeleniumBasic.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    {
        public void AssertFirstSearchResultLinkIsOpened(string expectedPageURL, string expectedPageTitle)
        {
            Assert.Multiple(() =>
            {
                string actualPageTitle = Driver.Title;
                string actualPageURL = Driver.Url;

                Assert.That(actualPageURL, Is.EqualTo(expectedPageURL));
                Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle));
            });
        }
    }
}
