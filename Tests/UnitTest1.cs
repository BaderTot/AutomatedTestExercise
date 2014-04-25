using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
{
/*        [TestMethod]
        public void Can_Load_Login_Page() 
        {
            Pages.LogInPage.Goto();
            Assert.IsTrue(Pages.LogInPage.IsAt());
        }
*/

    [Test]
    public void Can_Log_In()
    {
        Pages.LogInPage.Goto();
        Pages.LogInPage.TypeLogInFields("mrb", "Moocowmoo1", "Demonstration");
        Pages.LogInPage.ClickLogInButton();
        Assert.IsTrue(Pages.LoadHomePage("Log Out"));


    }

    [TestCleanup]
    public void CleanUp()
    {
        //Pages.HomePage.LogOut();
        Browser.Close();
    }
}
}
