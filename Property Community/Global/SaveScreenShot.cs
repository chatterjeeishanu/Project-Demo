﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Community.Global
{
    class SaveScreenShot
    {
        public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName, string folderLocation) // Definition
        {
            //screenshot will be saved at a location data-driven in resource file
            //var folderLocation = (Global.CommonFeatures.ScreenshotPath);
            
            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(ScreenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
            //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
            fileName.Append(".jpeg");
            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
            return fileName.ToString();
        }
    }
}
