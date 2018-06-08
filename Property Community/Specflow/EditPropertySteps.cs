using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using System.Threading;
using NUnit.Framework;

namespace Property_Community.Specflow
{
    [Binding]
    public class EditPropertySteps
    {
        [Given(@"I login")]
        public void GivenILogin()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Edit Property");
            Pages.Login.LoginSteps();
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
        }
        
        [When(@"I search a property and try to edit")]
        public void WhenISearchAPropertyAndTryToEdit()
        {
            MyProperties.EditProperty();
            //Console.WriteLine(Global.GlobalDriver.driver.Title);
            Assert.AreEqual("Properties | Property Community", Global.GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property Edited Successfully");
        }
        
        [Then(@"property gets edited")]
        public void ThenPropertyGetsEdited()
        {
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(Global.GlobalDriver.driver, "Adding is successful", Global.CommonFeatures.ScreenshotPath);
            Thread.Sleep(1500);
            CommonFeatures.Teardown();
        }
    }
}
