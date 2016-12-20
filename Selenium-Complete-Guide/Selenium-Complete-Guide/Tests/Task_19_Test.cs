using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class Task_19_Test : AuthTestBase
    {
        [Test]
        public void Task_19_test()
        {
            app.Navigator.GoToMainPage();
            app.ProductPage.GoToCampaignsArticlePage();
            app.Ducks.Add_1_Duck();
            app.ProductPage.GoToCampaignsArticlePage();
            app.Ducks.Add_2_Duck();
            app.ProductPage.GoToCampaignsArticlePage();
            app.Ducks.Add_3_Duck();
            app.Ducks.GotoCheckoutPage();
            app.Checkout.RemoveDucksFromChekout();
        }
    }
}