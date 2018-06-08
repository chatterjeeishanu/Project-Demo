using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Community.Global
{
    class GlobalDriver
    {
        //driver setup
        public static IWebDriver driver { get; set; }
    }
}
