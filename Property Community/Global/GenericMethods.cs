using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Community.Global
{
    class GenericMethods
    {
        //sendkeys function for textbox
        public static void TextBox(IWebDriver driver, string LocatorType, string LocatorValue, string Text)
        {
            if (LocatorType == "Id")
            {
                try
                {
                    driver.FindElement(By.Id(LocatorValue)).SendKeys(Text);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Wrong ID detected while entering text in" + LocatorValue + "exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
                    driver.Close();
                }
                
            }
            if (LocatorType == "XPath")
            {
                try
                {
                    driver.FindElement(By.XPath(LocatorValue)).SendKeys(Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong XPath detected while entering text " + LocatorValue + "exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
                    driver.Close();
                }                               
            }
        }

        //button click function
        public static void ButtonClick(IWebDriver driver, string LocatorType, string LocatorValue)
        {
            if (LocatorType == "Id")
            {
                try
                {
                    driver.FindElement(By.Id(LocatorValue)).Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong XPath detected while button click " + "exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
                    driver.Close();
                }                
               
            }
            if (LocatorType == "XPath")
            {
                try
                {
                    driver.FindElement(By.XPath(LocatorValue)).Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong XPath detected while button click " + "exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
                    driver.Close();
                }                             
            }
            if (LocatorType == "CSS")
            {
                driver.FindElement(By.CssSelector(LocatorValue)).Click();
            }
        }
        //send keys return function - when a webelement is wrapped into another div, Chrome does not allow click
        public static void SendKeysReturn(IWebDriver driver, string LocatorType, string LocatorValue)
        {
            if (LocatorType == "Id")
            {
                driver.FindElement(By.Id(LocatorValue)).SendKeys(Keys.Return);
            }
            if (LocatorType == "XPath")
            {
                driver.FindElement(By.XPath(LocatorValue)).SendKeys(Keys.Return);
            }
            if (LocatorType == "CSS")
            {
                driver.FindElement(By.CssSelector(LocatorValue)).SendKeys(Keys.Return);
            }
        }
        //select element from dropdown

        public static void DropDown(IWebDriver driver, string LocatorType, string LocatorValue, string TextValue)
        {
            if (LocatorType == "Id")
            {
                SelectElement option = new SelectElement(driver.FindElement(By.Id(LocatorValue)));
                option.SelectByText(TextValue);
                option.SelectedOption.Click();
            }
            else if (LocatorType == "XPath")
            {
                SelectElement option = new SelectElement(driver.FindElement(By.XPath(LocatorValue)));
                option.SelectByText(TextValue);
                option.SelectedOption.Click();
            }
        }

        //clear textbox

        public static void ClearText(IWebDriver driver, string LocatorType, string LocatorValue)
        {
            if (LocatorType == "Id")
            {
                driver.FindElement(By.Id(LocatorValue)).Clear();
            }
            else if (LocatorType == "XPath")
            {
                driver.FindElement(By.XPath(LocatorValue)).Clear();
            }

        }

        // UI validation methods are coming below

        // character length validation

        public static void CheckLength (int minLength, int maxLength, string inputText, string fieldName)
        {
            try
            {
                Assert.LessOrEqual(inputText.Length, maxLength);
                Assert.GreaterOrEqual(inputText.Length, minLength);
                //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Skip, passMessage);
            }
            catch (Exception ex)
            {
                //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
                Console.WriteLine("exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
                Console.WriteLine("The field must be between " + minLength + " - " + maxLength + " alphanumeric characters.");
                CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, fieldName + " must be between " + minLength + " - " + maxLength + " alphanumeric characters.");
                CommonFeatures.Teardown();
            }
            
        }
        public static void ValidYear(int minYear, string inputYear, string fieldName)
        {
            int currentYear = DateTime.Now.Year;
            int _inputYear = Int32.Parse(inputYear);
            try
            {

                Assert.GreaterOrEqual(_inputYear, minYear);
                Assert.LessOrEqual(_inputYear, currentYear);
                
                //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Skip, passMessage);
            }
            catch (Exception ex)
            {
                //CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
                Console.WriteLine("The exception message : " + ex + "Inner Exception : " + ex.InnerException);
                Console.WriteLine("The Year built should be within " + minYear + " and " + currentYear);
                CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "The Year in " + fieldName + " field should be within " + minYear + " and " + currentYear);
                CommonFeatures.Teardown();
            }

        }
        public static void ValidNumeric(string inputField, string fieldName)
        {
         int myInteger;

         bool IsNumeric = int.TryParse(inputField, out myInteger);
                
         if (IsNumeric == true)
            {
                //ignore
            }
         else
            {
                Console.WriteLine(" The " + fieldName + " should be numeric ");
                CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, " The " + fieldName + " should be numeric ");
                CommonFeatures.Teardown();
            }
        }

        // page title validation
        public static void ValidateTitle(string expectedTitle, string actualTitle, string successMessage, string failMessage)
        {
            try
            {
                Assert.AreEqual(expectedTitle, actualTitle);
                CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, successMessage);
            }
            catch (Exception)
            {
                CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
            }
            
        }
    }
}
