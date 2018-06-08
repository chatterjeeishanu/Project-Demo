using System;
using System.Threading;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using NUnit.Framework;

namespace Property_Community.Specflow
{
    [Binding]
    public class DeletingPropertiesSteps
    {
        [Given(@"I have logged in homepage")]
        public void GivenIHaveLoggedInHomepage()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Delete Property");
            Pages.Login.LoginSteps();
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I search a property and try to delete")]
        public void WhenISearchAPropertyAndTryToDelete()
        {
            MyProperties.DeleteProperty();
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Delete");
        }
        
        [Then(@"the property should be deleted")]
        public void ThenThePropertyShouldBeDeleted()
        {
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(Global.GlobalDriver.driver, "Deleting is successful", Global.CommonFeatures.ScreenshotPath);
            Thread.Sleep(1500);
            CommonFeatures.Teardown();
        }
    }
}
