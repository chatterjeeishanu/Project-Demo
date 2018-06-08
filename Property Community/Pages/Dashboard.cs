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
    class Dashboard
    {
        public static IWebDriver myDriver = Global.GlobalDriver.driver;
        /*******  property owner dashboard
        **
        *******************************/
        public static void MyProperties()
        {
            //click on My Properties 
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[1]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[1]");
            }           

            //validation
            GenericMethods.ValidateTitle("Properties | Property Community", myDriver.Title, "My Properties Dashboard Tested Successfully", "My Properties Dashboard Test Failed");
        }
        public static void MyTenants()
        {
            //click on My Tenants  
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[2]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[2]");
            }            

            //validation
            GenericMethods.ValidateTitle("Property Tenants", myDriver.Title, "My Tenants Dashboard Tested Successfully", "My Tenants Dashboard Test Failed");
        }
        public static void FinanceDetails()
        {
            //click on Finance Details     
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[3]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[3]");
            }            

            //validation            
            GenericMethods.ValidateTitle("Properties | Property Community", myDriver.Title, "Finance Details Dashboard Tested Successfully", "Finance Details Dashboard Test Failed");
        }

        /*******  Tenant dashboard
        **
        *******************************/
        public static void MyRentals()
        {
            //click on My Rentals    
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[1]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[1]");
            }            

            //validation           
            GenericMethods.ValidateTitle("My Rentals", myDriver.Title, "My Rentals Dashboard Tested Successfully", "My Rentals Dashboard Test Failed");
        }
        public static void MyWatchlist()
        {
            //click on My Watchlist    
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[2]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[2]");
            }
            
            //validation            
            GenericMethods.ValidateTitle("Property Community | Watchlist", myDriver.Title, "My Watchlist Dashboard Tested Successfully", "My Watchlist Dashboard Test Failed");
        }
        public static void MyApplications()
        {
            //click on My Applications  
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[3]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[5]/div/div/div/div[2]/div/a[3]");
            }            

            //validation            
            GenericMethods.ValidateTitle("Tenant | Rental Applications", myDriver.Title, "My Applications Dashboard Tested Successfully", "My Applications Dashboard Test Failed");
        }

        /*******  Service Supplier dashboard
        **
        *******************************/
        public static void MyWatchlistSS()
        {
            //click on My Watchlist SS  
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[1]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[1]");
            }            

            //validation            
            GenericMethods.ValidateTitle("Property Community | Watchlist", myDriver.Title, "My Watchlist SS Dashboard Tested Successfully", "My Watchlist SS Dashboard Test Failed");
        }
        public static void MyJobs()
        {
            //click on My Jobs    
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[2]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[2]");
            }           

            //validation
            CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "My Jobs Dashboard Tested Successfully");            
        }
        public static void MyQuotes()
        {
            //click on My Quotes   
            if (CommonFeatures.browser == "Chrome")
            {
                GenericMethods.SendKeysReturn(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[3]");
            }
            else
            {
                GenericMethods.ButtonClick(myDriver, "XPath", "//body/div[2]/section/div[8]/div/div/div/div[2]/div/a[3]");
            }            

            //validation            
            GenericMethods.ValidateTitle("My Quotes", myDriver.Title, "My Quotes Dashboard Tested Successfully", "My Quotes Dashboard Test Failed");
        }
        
        public static void BackNavigation()
        {
            myDriver.Navigate().Back();
            GenericMethods.ValidateTitle("Dashboard", myDriver.Title, "Back Navigation Successful", "Back Navigation Failed");
        }
        public static void SignOut()
        {
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div/div/div[2]/div[4]/i");
            GenericMethods.ButtonClick(myDriver, "XPath", "//body/div/div/div[2]/div[4]/div/a[4]");
            Thread.Sleep(500);
            GenericMethods.ValidateTitle("Log In", myDriver.Title, "Sign Out is Successful", "Sign Out is failed");
        }
        // The below method is the experiemental method and created by specialist - Don't try at home
        public static void ClickSection(string findBy, string byVal, string expectedTitle, string successMessage, string failMessage)
        {
        //click on My Quotes   
            if (CommonFeatures.browser == "Chrome")
            {
               GenericMethods.SendKeysReturn(myDriver, findBy,byVal);
            }
            else
            {
               GenericMethods.ButtonClick(myDriver, findBy, byVal);
            }

        //validation            
            GenericMethods.ValidateTitle(expectedTitle, myDriver.Title, successMessage, failMessage);
        }
    }
}
