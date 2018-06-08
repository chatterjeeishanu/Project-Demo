using System;
using TechTalk.SpecFlow;
using Property_Community.Global;
using Property_Community.Pages;
using System.Threading;

namespace Property_Community
{
    [Binding]
    public class PageNavigationSteps
    {
        [Given(@"I login to home page")]
        public void GivenILoginToHomePage()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Arrow Key");
            Login.LoginSteps();
        }
        
        [When(@"I try to navigate")]
        public void WhenITryToNavigate()
        {
            MyProperties.PageNavigation();
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Navigation Successful");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           // var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(Global.GlobalDriver.driver, "Adding is successful", Global.CommonFeatures.ScreenshotPath);
           // Thread.Sleep(1500);
            CommonFeatures.Teardown();
        }
    }
}
