using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using System.Threading;
using NUnit.Framework;

namespace Property_Community
{
    [Binding]
    public class AddPropertySteps
    {
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Add New Property");
            Pages.Login.LoginSteps();
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I try to add new property")]
        public void WhenITryToAddNewProperty()
        {
            Pages.MyProperties.AddNewProperties();
            //verification
           
        }
        
        [Then(@"A new property gets added")]
        public void ThenANewPropertyGetsAdded()
        {
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(Global.GlobalDriver.driver, "Adding is successful", Global.CommonFeatures.ScreenshotPath);
            Thread.Sleep(1500);
            CommonFeatures.Teardown();
        }
    }
}
