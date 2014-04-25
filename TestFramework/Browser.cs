using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;


namespace TestFramework {
    public static class Browser {

        private static IWebDriver WebDriver;

        public static string Title {
            get { return WebDriver.Title; }
        }

        public static ISearchContext Driver {
            get { return WebDriver; }
        }

        public static void Goto(string url) {
            WebDriver.Url = url;

        }

        public static void Open() {
            var profile = new FirefoxProfile();
            profile.AcceptUntrustedCertificates = true;
            WebDriver = new FirefoxDriver(new FirefoxBinary(), profile, TimeSpan.FromMinutes(4));
        }

        public static void AllowPageLoad() {
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMinutes(2));
        }


        public static void Close() {
            WebDriver.Quit();
            }
    }
}
