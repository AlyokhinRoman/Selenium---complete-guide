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
    public class ProductPageHelper : HelperBase
    {
        public ProductPageHelper(ApplicationManager manager)
            : base(manager)
        {
            this.manager = manager;
        }

        public void GoToCampaignsArticlePage()
        {
            driver.FindElement(By.XPath("//div[@id='box-campaigns']/div/ul/li/a[1]/div[1]/img")).Click();
        }

       
    }
}
