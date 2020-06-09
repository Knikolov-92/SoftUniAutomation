using NUnit.Framework;
using System.Collections.Generic;


namespace DemoQA.Pages.Interactions.Sortable
{
    public partial class SortablePage : BasePage
    {
        public void ValidateOrderOfSortedElements(List<string> expectedOrder)
        {           
            List<string> actualOrder = GetActualOrderOfSortedListElements();

            Assert.That(actualOrder, Is.EqualTo(expectedOrder));
        }
    }
}
