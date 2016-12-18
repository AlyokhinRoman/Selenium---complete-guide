using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class CheckLinksOpened : AuthTestBase
    {
        [Test]

        {
            app.Navigator.GotoCountriesPage();
            app.Navigator.CheckLinks();
        }
    }
}
