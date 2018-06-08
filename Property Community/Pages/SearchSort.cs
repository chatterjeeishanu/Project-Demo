using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Property_Community.Global;
using Property_Community.Pages;

namespace Property_Community.Pages
{
    class SearchSort
    {
        //defining the local driver
        public static IWebDriver myDriver = Global.GlobalDriver.driver;

        public static void SearchAndSort()
        {
            //To skip the alert
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");

            Thread.Sleep(1500);

            //navigate to Owners>Properties
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]");
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]/div/a[1]");

            //Checking the right page
            Assert.AreEqual("Properties | Property Community", myDriver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass,"In My Properties page");

            //Searching property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input");
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input", "PropIshanu" + Keys.Enter);
            //Search is successful
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Search is successful");
            //sorting by name
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[2]/div/div/div/div/i");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[2]/div/div/div/div/div[2]/div");
            //Sorting is done
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Sort is successful");

            //edit the first property
            MyProperties.SortEdit();


        }
    }
}
