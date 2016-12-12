using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class CountrysSortTests : AuthTestBase
    {

        [Test]
        public void CountriesPageCountriesSortTest()
        {
            app.Navigator.GotoCountriesPage();
            app.Navigator.CheckCountriesAlphabetOrder();
        }

        [Test]

        public void CheckCountriesPageCanadaZonesOrder()
        {
            app.Navigator.GotoCountriesPage();
            app.Navigator.GoToCountriesCanadaPage();
            app.Navigator.CheckZonesAlphabetOrder();
        }

        [Test]

        public void CheckCountriesPageUSAZonesOrder()
        {
            app.Navigator.GotoCountriesPage();
            app.Navigator.GoToCountriesUSAPage();
            app.Navigator.CheckZonesAlphabetOrder();
        }
    }
}
