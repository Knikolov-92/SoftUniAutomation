using NUnit.Framework;
using System.Collections.Generic;


namespace DemoQA.Pages.Interactions.Sortable
{
    public partial class SortablePage : BasePage
    {
        public void ValidateOrderOfSortedListElements(List<string> expectedOrder)
        {            
            List<string> actualOrder = GetActualOrderOfSortedListElements();

            Assert.That(actualOrder, Is.EqualTo(expectedOrder));
        }

        public void ValidateOrderOfSortedGridElements(List<string> expectedOrder)
        {
            List<string> actualOrder = GetActualOrderOfSortedGridElements();

            Assert.That(actualOrder, Is.EqualTo(expectedOrder));
        }
    }
}
