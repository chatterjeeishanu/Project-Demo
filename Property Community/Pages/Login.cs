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
    class Login
    {
        public static IWebDriver myDriver = Global.GlobalDriver.driver;
        public static void LoginSteps()
        {
            // Finding the excel path for data driven input
            Global.ExcelData.PopulateInCollection(CommonFeatures.ExcelPath, "Login");

            //passing the url
            myDriver.Navigate().GoToUrl(Global.ExcelData.ReadData(2, "Url"));                     
                         
            //Passing username and password
            Global.GenericMethods.TextBox(myDriver, "XPath", "//*[@id='UserName']", Global.ExcelData.ReadData(2, "UserName"));
            Global.GenericMethods.TextBox(myDriver, "Id", "Password", Global.ExcelData.ReadData(2, "PassWord"));

            //clicking the signin button
            Global.GenericMethods.ButtonClick(myDriver,"XPath", "//*[@id='sign_in']/div[1]/div[4]/button");
                                                           
        }
        
    }
}
