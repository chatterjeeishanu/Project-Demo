using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property_Community.Configuration;
using RelevantCodes.ExtentReports;
using NUnit.Framework;

namespace Property_Community.Global
{
    class CommonFeatures
    {
        //public static int browser = Int32.Parse(ResourceFile.Browser);
        public static string browser = ResourceFile.Browser;
        public static string ExcelPath = ResourceFile.ExcelPath;
        public static string ScreenshotPath = ResourceFile.ScreenshotPath;
        public static string ReportPath = ResourceFile.ReportPath;
        public static string PhotoPath = ResourceFile.PhotoPath;
        public static string NavigationSC = ResourceFile.NavigationScreenShot;
        public static int RowCount = Int32.Parse(ResourceFile.RowCount);

        //Extent reports elements

        public static ExtentTest test;
        public static ExtentReports extent;

        public static void Initialize()
        {
            //browser selection logic - selection criteria is datadriven by resourcefile
            switch (browser)
            {
                case "Chrome":
                    GlobalDriver.driver = new ChromeDriver();
                    break;
                case "Firefox":
                    GlobalDriver.driver = new FirefoxDriver();
                    break;
            }
            // maximizing the browser
            GlobalDriver.driver.Manage().Window.Maximize();

            //report initialization
            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ResourceFile.ReportXML);
        }

        public static void Teardown()
        {
            // Report wrapup
            //test.Log(LogStatus.Info, "Test Log");
            extent.EndTest(test);
            extent.Flush();

            //closing the browser
            GlobalDriver.driver.Close();
        }
    }
}
