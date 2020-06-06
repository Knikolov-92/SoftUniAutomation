using NUnit.Framework;


namespace SeleniumBasic.Pages.Practice
{
    public partial class PracticePage : BasePage
    {
        public void AssertInputEmailIsTypedInField(string expectedEmail)
        {
            WaitForElementToBeDisplayed(EMAIL_FIELD_OUTPUT);
            WaitForValueOfElementToBeUpdated(EMAIL_FIELD_OUTPUT);
            string actualEmail = GetElementValue(EMAIL_FIELD_OUTPUT);

            Assert.That(actualEmail, Is.EqualTo(expectedEmail));
        }
    }
}
