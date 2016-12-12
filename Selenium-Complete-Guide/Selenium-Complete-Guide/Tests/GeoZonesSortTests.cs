using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{

    public class GeoZonesSortTests : AuthTestBase
    {

        [Test]
        public void GeoZonesPageGeoZonesSortTest()
        {
            app.Navigator.GotoGeoZonesPage();
            app.Navigator.GoToGeoZonesCanadaPage();
            app.Navigator.CheckZonesAlphabetOrder();
        }

        public void GeoZonesPageUSAGeoZonesSortTest()
        {
            app.Navigator.GotoGeoZonesPage();
            app.Navigator.GoToGeoZonesUnitedStatesOfAmericaPage();
            app.Navigator.CheckZonesAlphabetOrder();
        }
    }
}