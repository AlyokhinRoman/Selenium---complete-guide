using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class CheckoutTests : AuthTestBase
    {
        [Test]
        public void AddProductToCheckoutTest()
        {
            app.Navigator.GoToMainPage();
            app.Navigator.Add1ProductToCheckout();
            app.Navigator.Add2ProductToCheckout();
            app.Navigator.Add3ProductToCheckout();
            app.Navigator.DeleteProductsFromCheckout();
        }
    }
}
