using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DemoQA.Pages.Interactions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver)
        { }

        public void Open()
        {
            NavigateTo(SELECTABLE_PAGE_URL);
        }

        public void NavigatesToGridTab()
        {
            ClickOn(GRID_BUTTON);
        }

        public int SelectRandomListElement()
        {
            Random rand = new Random();
            List<IWebElement> elementsList = Driver.FindElements(LIST_ALL_ELEMENTS).ToList();
            int index = rand.Next(0, elementsList.Count - 1);

            ClickOn(elementsList[index]);
         
            return index;
        }        

        public string GetExpectedListElementText(int elementPosition)
        {
            string text;

            switch (elementPosition)
            {
                case 0:
                    text = "Cras justo odio";
                    break;
                case 1:
                    text = "Dapibus ac facilisis in";
                    break;
                case 2:
                    text = "Morbi leo risus";
                    break;
                case 3:
                    text = "Porta ac consectetur ac";
                    break;

                default:
                    text = "No text for element on position: " + elementPosition;
                    break;
            }
            return text;
        }

        public int SelectRandomGridElement()
        {
            Random rand = new Random();
            List<IWebElement> elementsList = Driver.FindElements(GRID_ALL_ELEMENTS).ToList();
            int index = rand.Next(0, elementsList.Count - 1);

            ClickOn(elementsList[index]);

            return index;
        }        

        public string GetExpectedGridElementText(int elementPosition)
        {
            string text;

            switch (elementPosition)
            {
                case 0:
                    text = "One";
                    break;
                case 1:
                    text = "Two";
                    break;
                case 2:
                    text = "Three";
                    break;
                case 3:
                    text = "Four";
                    break;
                case 4:
                    text = "Five";
                    break;
                case 5:
                    text = "Six";
                    break;
                case 6:
                    text = "Seven";
                    break;
                case 7:
                    text = "Eight";
                    break;
                case 8:
                    text = "Nine";
                    break;

                default:
                    text = "No text for element on position: " + elementPosition;
                    break;
            }
            return text;
        }        
    }
}
