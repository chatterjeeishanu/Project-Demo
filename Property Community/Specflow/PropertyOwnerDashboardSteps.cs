using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;

namespace Property_Community.Specflow
{
    [Binding]
    public class PropertyOwnerDashboardSteps
    {
       // public static IWebDriver myDriver = Global.GlobalDriver.driver;

        [Given(@"I have logged into the homepage by username and password")]
        public void GivenIHaveLoggedIntoTheHomepageByUsernameAndPassword()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Property Owner Dashboard");
            Pages.Login.LoginSteps();

            //To skip the alert
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//body/div[5]/div//div[5]/a[1]");
            Thread.Sleep(2500);

            // login validation
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I try to go all (.*) sections and come back to the dashboard")]
        public void WhenITryToGoAllSectionsAndComeBackToTheDashboard(int p0)
        {
            Dashboard.MyProperties();
            Dashboard.BackNavigation();
            Dashboard.MyTenants();
            Dashboard.BackNavigation();
            Dashboard.FinanceDetails();
            Dashboard.BackNavigation();
        }
        
        [Then(@"My navigation is uninterrupted")]
        public void ThenMyNavigationIsUninterrupted()
        {
            CommonFeatures.Teardown();
        }
    }
}
