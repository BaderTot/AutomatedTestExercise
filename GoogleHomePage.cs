using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class GoogleHomePage {
        
        static string Url = "http://www.google.com";

        [FindsBy(How = How.Id, Using = "gbqfq")] 
        private IWebElement searchField;


        [FindsBy(How = How.Id, Using = "gbqfb")]
        private IWebElement searchButton;

        public void Goto() {
            Browser.Goto(Url);
        }

        public void TypeStringInSearchField(string searchString)
        {
            searchField.SendKeys(searchString);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }
    }
}