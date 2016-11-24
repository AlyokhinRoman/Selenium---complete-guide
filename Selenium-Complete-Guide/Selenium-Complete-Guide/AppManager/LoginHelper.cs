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
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager)
            : base(manager)
        {
            this.manager = manager;

        }

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
               if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
            Type(By.Id("username"), account.Username);
            Type(By.Id("password"), account.Password);
            driver.FindElement(By.Name("submit")).Click();
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.CssSelector("button.submit.no-uniform")).Click();
            }
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.CssSelector("button.submit.no-uniform"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                   && IsElementPresent(By.LinkText("Deposit"));
        }
    }
}
