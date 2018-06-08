using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using System.Threading;
using NUnit.Framework;

namespace Property_Community.Specflow
{
    [Binding]
    public class ServiceSupplierDashboardSteps
    {
        [Given(@"I have logged in by correct username and password")]
        public void GivenIHaveLoggedInByCorrectUsernameAndPassword()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Service Supplier Dashboard");
            Pages.Login.LoginSteps();

            //To skip the alert
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//body/div[5]/div//div[5]/a[1]");
            Thread.Sleep(2500);

            // login validation
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I try to navigate all (.*) sections and come back to the dashboard by back button")]
        public void WhenITryToNavigateAllSectionsAndComeBackToTheDashboardByBackButton(int p0)
        {
            Dashboard.MyWatchlistSS();
            Dashboard.BackNavigation();
            Dashboard.MyJobs();
            Dashboard.BackNavigation();
            Dashboard.MyQuotes();
            Dashboard.BackNavigation();
        }
        
        [Then(@"My navigation should be working uninterrupted")]
        public void ThenMyNavigationShouldBeWorkingUninterrupted()
        {
            CommonFeatures.Teardown();
        }
    }
}
