using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Property_Community.Global;

namespace Property_Community.Pages
{
    class Registration
    {
        public static IWebDriver myDriver = Global.GlobalDriver.driver;
        
        public static void Signup()
        {
            // Finding the excel path for data driven input
            Global.ExcelData.PopulateInCollection(CommonFeatures.ExcelPath, "Login");

            //passing the url
            myDriver.Navigate().GoToUrl(Global.ExcelData.ReadData(2, "Url"));

            //Assertion and reporting comments
            Assert.AreEqual("Log In", myDriver.Title);
            CommonFeatures.test = CommonFeatures.extent.StartTest("Navigation Successful");

            //clicking on signup button
            Thread.Sleep(1500);
            GenericMethods.ButtonClick(myDriver,"XPath", "//body/div/div/div/div/form/div[3]/a");

            //filling the data for registration
            GenericMethods.TextBox(myDriver, "Id", "FirstName", "Ishanu");
            GenericMethods.TextBox(myDriver, "Id", "LastName", "Chatterjee");
            GenericMethods.TextBox(myDriver, "Id", "UserName", "ishanurocks@gmail.com");
            GenericMethods.TextBox(myDriver, "Id", "Password", "Ishanu123");
            //GenericMethods.ButtonClick(myDriver, "XPath", "//body/div/div/div/div/form/div/div[5]/div/div");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div/div/div/div/form/div/div[5]/div/div/div");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div/div/div/div/form/div/div[5]/div/div/div[2]/div");
            GenericMethods.ButtonClick(myDriver,"XPath", "//*[@id='sign_in']/div[1]/div[6]/div/label/a");
                       
            Thread.Sleep(1500);
            GenericMethods.ButtonClick(myDriver, "Id", "btnAccept");
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(myDriver, "Id", "SignupButton");

            //saving screenshot
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(myDriver, "Registration Successful", Global.CommonFeatures.ScreenshotPath);


        }
    }
}
