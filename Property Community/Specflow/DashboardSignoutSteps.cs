using NUnit.Framework;
using Property_Community.Global;
using Property_Community.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Property_Community
{
    [Binding]
    public class DashboardSignoutSteps
    {
        [Given(@"I have already logged into dashboard page")]
        public void GivenIHaveAlreadyLoggedIntoDashboardPage()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Dashboard Signout");
            Pages.Login.LoginSteps();

            //To skip the alert
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//body/div[5]/div//div[5]/a[1]");
            Thread.Sleep(2500);

            // login validation
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I try to signout")]
        public void WhenITryToSignout()
        {
            Dashboard.SignOut();
        }
        
        [Then(@"I am successful to signout and reach login page")]
        public void ThenIAmSuccessfulToSignoutAndReachLoginPage()
        {
            CommonFeatures.Teardown();
        }
    }
}
