using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property_Community.Global;
using Property_Community.Pages;
using System.Threading;

namespace Property_Community.Test
{
    // This entire class is commented out as all test cases are created again using Specflow. 

    class Test
    {
        [SetUp]
        public void StartTest()
        {
            Global.CommonFeatures.Initialize();
        }
        //[Test]
        //public void SignupOld()
        //{
        //    Pages.Registration.Signup();
        //}
        //[Test]
        //public void StartLoginOld()
        //{
        //    Pages.Login.LoginSteps();
        //}
        //[Test]
        //public void AddNewPropertiesOld()
        //{
        //    Pages.Login.LoginSteps();
        //    Pages.MyProperties.AddNewProperties();
        //}
        //[Test]
        //public void EditPropertyOld()
        //{
        //    Pages.Login.LoginSteps();
        //    Pages.MyProperties.EditProperty();
        //}
        //[Test]
        //public void DeletePropertyOld()
        //{
        //    Pages.Login.LoginSteps();
        //    Pages.MyProperties.DeleteProperty();
        //}
        //[Test]
        //public void NavigatePropertyPageOld()
        //{
        //    Pages.Login.LoginSteps();
        //    Pages.MyProperties.PageNavigation();
        //}
        //[Test]
        //public void tempTest()
        //{
        //    Pages.Login.LoginSteps();
            
        //    //To skip the alert
        //    Thread.Sleep(1000);
        //    GenericMethods.ButtonClick(Global.GlobalDriver.driver, "XPath", "//body/div[5]/div//div[5]/a[1]");
        //    Thread.Sleep(2500);
        //    Pages.Dashboard.ClickSection("XPath", "/html/body/div[2]/section/div[3]/div[1]/div[1]/div/div[2]/div/a[1]", "Properties | Property Community", "Success", "Failure");

        //}
        [TearDown]
        public void EndTest()
        {            
            Global.CommonFeatures.Teardown();
        }

    }
}
