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
    public class DucksHelper : HelperBase
    {
        public DucksHelper(ApplicationManager manager)
            : base(manager)
        {
            this.manager = manager;
        }

        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("Home")).Click();
        }

        public void SelectSmallDuckSize()
        {
            driver.FindElement(By.XPath("//td[@class='options']/select//option[2]")).Click();
        }

        public void ClickDuckPageAddCartButton()
        {
            driver.FindElement(By.Name("add_cart_product")).Click();
        }

        public void CheckCartIsUpdated_1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='1']")));
        }

        public void CheckCartIsUpdated_2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='2']")));
        }

        public void CheckCartIsUpdated_3()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='3']")));
        }

        public void GotoCheckoutPage()
        {
            driver.FindElement(By.LinkText("Checkout »")).Click();
        }

        public void Add_1_Duck()
        {
            SelectSmallDuckSize();
            ClickDuckPageAddCartButton();
            CheckCartIsUpdated_1();
            GoToHomePage();
        }

        public void Add_2_Duck()
        {
            SelectSmallDuckSize();
            ClickDuckPageAddCartButton();
            CheckCartIsUpdated_2();
            GoToHomePage();
        }

        public void Add_3_Duck()
        {
            SelectSmallDuckSize();
            ClickDuckPageAddCartButton();
            CheckCartIsUpdated_3();
        }
    }
}