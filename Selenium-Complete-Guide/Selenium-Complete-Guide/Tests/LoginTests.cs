using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginTest()
        {
            //app.Auth.Logout();
            AccountData account = new AccountData("admin", "admin"); 
            app.Auth.Login(account);
            //Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

    }
}
