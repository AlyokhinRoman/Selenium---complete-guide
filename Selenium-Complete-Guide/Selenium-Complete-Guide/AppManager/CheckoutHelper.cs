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
    public class CheckoutHelper : HelperBase
    {
        public CheckoutHelper(ApplicationManager manager)
            : base(manager)
        {
            this.manager = manager;
        }

        public void PressRemoveButton()
        {
            driver.FindElement(By.Name("remove_cart_item"));
        }

        public void CheckIsOrderSummaryTableUpdated()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.Id("order_confirmation-wrapper")));
        }

        public void RemoveDucksFromChekout()
        {
            PressRemoveButton();
            CheckIsOrderSummaryTableUpdated();
        }
    }
}