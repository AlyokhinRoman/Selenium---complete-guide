using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class ProductTests : AuthTestBase
    {
        [Test]

        public void AddNewProductTest()
        {
            app.Navigator.GotoCatalogPage();
            app.Navigator.AddNewProduct();
            app.Navigator.CheckProductAdded();
        }
    }
}
