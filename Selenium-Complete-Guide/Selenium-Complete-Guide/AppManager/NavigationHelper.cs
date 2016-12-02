using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GotoLoginPage()
        {
            if (driver.Url == baseURL + "/login.php")
            {
                return;
            }

            driver.Navigate().GoToUrl(baseURL + "/login.php");
        }
    }
}
