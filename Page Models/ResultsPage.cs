using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace TestFramework {
    public class ResultsPage
    {

        [FindsBy(How = How.CssSelector, Using = ".srg .g .r a")]
        public IList<IWebElement> elements;

        
    }  
}