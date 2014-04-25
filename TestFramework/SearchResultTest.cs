using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestFramework {
    [TestFixture]
    public class SearchResultTest
    {
  
        [SetUp]
        public void Setup() {
            Browser.Open();
            Pages.GoogleHomePage.Goto();
        }

        [TearDown]
        public void CleanUpTest() {

            Browser.Close();

        }

        [Test]
        public void This_Test_Should_Pass()
        {
            GoogleSearchTest("Simple Energy");
        }

        [Test]
        public void This_Test_Should_Fail() 
        {
            GoogleSearchTest("Techstar Winners");
        }

        public void GoogleSearchTest(string searchString) {
            Pages.GoogleHomePage.TypeStringInSearchField(searchString);
            Pages.GoogleHomePage.ClickSearchButton();
            Browser.AllowPageLoad();
            for (var i = 0; i < 4; i++) {
                Assert.That(Pages.ResultsPage.elements[i].Text.ToLower(), Contains.Substring(searchString.ToLower()));
            }
               
           
        }

    }
}
