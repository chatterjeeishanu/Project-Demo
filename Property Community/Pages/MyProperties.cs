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

namespace Property_Community.Pages
{
    class MyProperties
    {
        //defining local driver
        public static IWebDriver myDriver = Global.GlobalDriver.driver;

        public static void AddNewProperties()
        {
            //finding the excle path for input
            Global.ExcelData.PopulateInCollection(CommonFeatures.ExcelPath, "Add Property");

            //To skip the alert
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");

            Thread.Sleep(1500);

            //loop for multiple properties getting added at single shot
            int loopNum = CommonFeatures.RowCount + 2;

            for (int rowNum = 2; rowNum < loopNum; rowNum ++ )
            {

            //navigate to Owners>Properties
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]");
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]/div/a[1]");

            //Checking the right page
            Assert.AreEqual("Properties | Property Community", myDriver.Title);
            //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "In My Properties page");

            //clicking add new properties
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(myDriver,"XPath", "//body/div[2]/section/div/div/div[2]/div/div[2]/a[2]");
            
            // Adding property details
            GenericMethods.TextBox(myDriver,"XPath", "//body/div[2]/section/form/fieldset/div/div/div/input", Global.ExcelData.ReadData(rowNum, "PropertyName"));
            GenericMethods.CheckLength(4, 30, Global.ExcelData.ReadData(rowNum, "PropertyName"), "Property Name");
             
            GenericMethods.ButtonClick(myDriver,"XPath", "//fieldset/div/div[2]/div");
            GenericMethods.ButtonClick(myDriver, "XPath", "//fieldset/div/div[2]/div");
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/form/fieldset/div[3]/div/div[2]/div/div/input", Global.ExcelData.ReadData(rowNum, "Number"));
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/form/fieldset/div[3]/div/div[2]/div[2]/div/input", Global.ExcelData.ReadData(rowNum, "Street"));
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/form/fieldset/div[3]/div/div[3]/div/div[2]/div/input", Global.ExcelData.ReadData(rowNum, "City"));
            //postcode
            GenericMethods.TextBox(myDriver,"XPath", "//input[@placeholder='PostCode']", Global.ExcelData.ReadData(rowNum, "Postcode"));
            GenericMethods.ValidNumeric(Global.ExcelData.ReadData(rowNum, "Postcode"), "Postcode");

            //Region
            GenericMethods.TextBox(myDriver, "Id", "region", Global.ExcelData.ReadData(rowNum, "Region"));

            //year built
            GenericMethods.TextBox(myDriver, "XPath", "//input[@placeholder = 'Year Built']", Global.ExcelData.ReadData(rowNum, "Yearbuilt"));
            GenericMethods.ValidYear(1900, Global.ExcelData.ReadData(rowNum, "Yearbuilt"), "Year Built");

            //rent
            GenericMethods.TextBox(myDriver,"XPath", "//input[@placeholder='Rent Amount']", Global.ExcelData.ReadData(rowNum, "targetrent"));

            //bedroom , bathroom, carpark
            GenericMethods.TextBox(myDriver, "XPath", "//input[@placeholder='Number of Bedrooms']", Global.ExcelData.ReadData(rowNum, "bedroom"));
            GenericMethods.ValidNumeric(Global.ExcelData.ReadData(rowNum, "bedroom"), "Bedroom");
            GenericMethods.TextBox(myDriver, "XPath", "//input[@placeholder='Number of Bathrooms']", Global.ExcelData.ReadData(rowNum, "bathroom"));
            GenericMethods.ValidNumeric(Global.ExcelData.ReadData(rowNum, "bathroom"), "Bathroom");
            GenericMethods.TextBox(myDriver,"XPath", "//input[@placeholder='Number of car parks']", Global.ExcelData.ReadData(rowNum, "carpark"));
            GenericMethods.ValidNumeric(Global.ExcelData.ReadData(rowNum, "carpark"),  "Carpark");

            //description of the property
            GenericMethods.TextBox(myDriver,"XPath", "//textarea[@class='add-prop-desc']", Global.ExcelData.ReadData(rowNum, "description"));
            GenericMethods.CheckLength(10, 100, Global.ExcelData.ReadData(rowNum, "description"), "Description");

            //picture of the property
            Thread.Sleep(2000);
            GenericMethods.TextBox(myDriver, "Id", "file-upload", CommonFeatures.PhotoPath);
            
            //navigating to financce page
            Thread.Sleep(2000);
            GenericMethods.ButtonClick(myDriver,"XPath", "//button[@class='ui teal button']");
            Assert.AreEqual("Properties | Add New Property", myDriver.Title);
            //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Info,"In Finance Page");

            //entering details in finance page
            GenericMethods.TextBox(myDriver, "XPath", "//form/fieldset[2]/div/div/div/input", Global.ExcelData.ReadData(rowNum, "purchaseprice"));
            GenericMethods.TextBox(myDriver, "XPath", "//form/fieldset[2]/div/div[2]/div/input", Global.ExcelData.ReadData(rowNum, "mortgage"));
            GenericMethods.TextBox(myDriver, "XPath", "//form/fieldset[2]/div/div[3]/div/input", Global.ExcelData.ReadData(rowNum, "homevalue"));

            //navigating to tenant screen
            GenericMethods.ButtonClick(myDriver, "XPath", "//fieldset[2]/div[8]/button[3]");
            Assert.AreEqual("Properties | Add New Property", myDriver.Title);
            //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Info,"In Tenant Page");

            //entering details in tenant page
            GenericMethods.TextBox(myDriver,"XPath", "//section/form/fieldset[3]/div/div/div/input", Global.ExcelData.ReadData(rowNum, "tenantmail"));
            GenericMethods.TextBox(myDriver, "Id", "fname", Global.ExcelData.ReadData(rowNum, "firstname"));
            GenericMethods.TextBox(myDriver, "Id", "lname", Global.ExcelData.ReadData(rowNum, "lastname"));
            GenericMethods.TextBox(myDriver, "Id", "ramount", Global.ExcelData.ReadData(rowNum, "rentamount"));

            GenericMethods.TextBox(myDriver, "Id", "sdate", Global.ExcelData.ReadData(rowNum, "sdate"));
            GenericMethods.TextBox(myDriver, "Id", "sdate", (Keys.Tab));
            GenericMethods.TextBox(myDriver, "Id", "sdate", "0105AM");

            GenericMethods.TextBox(myDriver, "Id", "edate", Global.ExcelData.ReadData(rowNum, "enddate"));
            GenericMethods.TextBox(myDriver, "Id", "edate", (Keys.Tab));
            GenericMethods.TextBox(myDriver, "Id", "edate", "0105AM");

            GenericMethods.TextBox(myDriver, "Id", "psdate", Global.ExcelData.ReadData(rowNum, "psdate"));
            GenericMethods.TextBox(myDriver, "Id", "psdate", (Keys.Tab));
            GenericMethods.TextBox(myDriver, "Id", "psdate", "0105AM");

            //save property
            GenericMethods.ButtonClick(myDriver, "Id", "saveProperty");
            //Verification
            Thread.Sleep(500);
            Assert.AreEqual("Properties | Add New Property", Global.GlobalDriver.driver.Title);
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property Added Successfully");
            }
            
        }
        public static void EditProperty()
        {
            //finding the excle path for input
            Global.ExcelData.PopulateInCollection(CommonFeatures.ExcelPath, "Add Property");

            //To skip the alert
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");

            Thread.Sleep(1500);

            //navigate to Owners>Properties
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]");
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]/div/a[1]");

            //Checking the right page
            Assert.AreEqual("Properties | Property Community", myDriver.Title);
            //CommonFeatures.test = CommonFeatures.extent.StartTest("In My Properties page");

            //Searching property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input");
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input", "PropIshanu" + Keys.Enter);

            //editing property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/i");
            Thread.Sleep(1500);
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/div/div[4]");

            GenericMethods.ClearText(myDriver,"XPath", "//body/div[2]/section/div[3]/div[2]/form/div[4]/div//div/input");
            Thread.Sleep(1500);
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/div[3]/div[2]/form/div[4]/div//div/input", "800");
            GenericMethods.ButtonClick(myDriver,"XPath", "//body/div[2]/section/div[3]/div[2]/form/div[8]/button");

            //saving screenshot
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(myDriver, "Edit is successful", Global.CommonFeatures.ScreenshotPath);
            
        }

    public static void DeleteProperty()
        {
            //To skip the alert
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");

            Thread.Sleep(1500);

            //navigate to Owners>Properties
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]");
            GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[1]/div/div[2]/div[1]/div/a[1]");

            //Searching property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input");
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/div/div/div/div[2]/div/form/div/input", "PropIshanu" + Keys.Enter);

            //Deleting property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/i");
            Thread.Sleep(1500);
            GenericMethods.ButtonClick(myDriver,"XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/div/div[5]");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[4]/div/div[2]/div[7]/button");
        }
    public static void PageNavigation()
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
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(myDriver, "We are at first page", Global.CommonFeatures.NavigationSC);

            //navigating to the 2nd page
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[4]/div/ul/li[8]//a");
            var ScreenshotPath1 = Global.SaveScreenShot.SaveScreenshot(myDriver, "This is second page", Global.CommonFeatures.NavigationSC);
            //navigating to the last page
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[4]/div/ul/li[10]/a");
            var ScreenshotPath2 = Global.SaveScreenShot.SaveScreenshot(myDriver, "This is last page", Global.CommonFeatures.NavigationSC);
            //returning to the first page
            Thread.Sleep(1000);
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[4]/div/ul/li/a");
            var ScreenshotPath3 = Global.SaveScreenShot.SaveScreenshot(myDriver, "This is again first page page", Global.CommonFeatures.NavigationSC);
        }
    public static void SortEdit()
        {
            //finding the excle path for input
            Global.ExcelData.PopulateInCollection(CommonFeatures.ExcelPath, "Add Property");
                        
            //editing property
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/i");
            Thread.Sleep(1500);
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div/div/div[3]/div/div/div[2]/div/div[3]/div/div/div[4]");

            GenericMethods.ClearText(myDriver, "XPath", "//body/div[2]/section/div[3]/div[2]/form/div[4]/div//div/input");
            Thread.Sleep(1500);
            GenericMethods.TextBox(myDriver, "XPath", "//body/div[2]/section/div[3]/div[2]/form/div[4]/div//div/input", "800");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[3]/div[2]/form/div[8]/button");
            //Edit is successful
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit is successful");
            //saving screenshot
            var ScreenshotPath = Global.SaveScreenShot.SaveScreenshot(myDriver, "Edit is successful", Global.CommonFeatures.ScreenshotPath);

        }
    }
}
