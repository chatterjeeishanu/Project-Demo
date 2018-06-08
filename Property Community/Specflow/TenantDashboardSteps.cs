using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using System.Threading;
using NUnit.Framework;

namespace Property_Community
{
    [Binding]
    public class TenantDashboardSteps
    {
        [Given(@"I have logged into the homepage by correct username and password")]
        public void GivenIHaveLoggedIntoTheHomepageByCorrectUsernameAndPassword()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Tenant Dashboard");
            Pages.Login.LoginSteps();

            //To skip the alert
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//body/div[5]/div//div[5]/a[1]");
            Thread.Sleep(2500);

            // login validation
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I try to go all (.*) sections and come back to the dashboard by back button")]
        public void WhenITryToGoAllSectionsAndComeBackToTheDashboardByBackButton(int p0)
        {
            Dashboard.MyRentals();
            Dashboard.BackNavigation();
            Dashboard.MyWatchlist();
            Dashboard.BackNavigation();
            Dashboard.MyApplications();
            Dashboard.BackNavigation();
        }
        
        [Then(@"My navigation should be uninterrupted")]
        public void ThenMyNavigationShouldBeUninterrupted()
        {
            CommonFeatures.Teardown();
        }
    }
}
