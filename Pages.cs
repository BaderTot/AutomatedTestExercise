using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework {
    public class Pages {
         
        public static GoogleHomePage GoogleHomePage {
            get {               
                var googleHomePage = new GoogleHomePage();
                PageFactory.InitElements(Browser.Driver, googleHomePage);
                return googleHomePage;
            }
        }

        public static ResultsPage ResultsPage{
            get {
                var resultsPage = new ResultsPage();
                PageFactory.InitElements(Browser.Driver, resultsPage);
                return resultsPage;
            }
        }
    }
}
