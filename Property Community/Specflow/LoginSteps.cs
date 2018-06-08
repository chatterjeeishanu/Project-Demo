using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Property_Community.Global;

namespace Property_Community.Specflow
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have open the browser")]
        public void GivenIHaveOpenTheBrowser()
        {
            Global.CommonFeatures.Initialize();
        }
        
        [Given(@"I have navigated to the url")]
        public void GivenIHaveNavigatedToTheUrl()
        {
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Login to Property.Community");
            // Finding the excel path for data driven input
            Global.ExcelData.PopulateInCollection(Global.CommonFeatures.ExcelPath, "Login");

            //passing the url
            Global.GlobalDriver.driver.Navigate().GoToUrl(Global.ExcelData.ReadData(2, "Url"));
            
            //Assertion and reporting comments
            Assert.AreEqual("Log In", Global.GlobalDriver.driver.Title);
            //Global.CommonFeatures.test = Global.CommonFeatures.extent.StartTest("Navigation Successful");
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Navigation Successful");
        }
        
        [When(@"I provide correct user name and password and press sign in")]
        public void WhenIProvideCorrectUserNameAndPasswordAndPressSignIn()
        {
            //Passing username and password
            GenericMethods.TextBox(Global.GlobalDriver.driver, "XPath", "//*[@id='UserName']", Global.ExcelData.ReadData(2, "UserName"));
            GenericMethods.TextBox(Global.GlobalDriver.driver, "Id", "Password", Global.ExcelData.ReadData(2, "PassWord"));

            //clicking the signin button
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//*[@id='sign_in']/div[1]/div[4]/button");
                        
        }
        
        [Then(@"I succesfully login to home page")]
        public void ThenISuccesfullyLoginToHomePage()
        {
            //verification assertion
            Assert.AreEqual("Dashboard", GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
            
            //To skip the alert
            GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");
            //closing the browser
            CommonFeatures.Teardown();
        }
    }
}
