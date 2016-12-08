using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Complete_Guide
{
    public class StickerTests : AuthTestBase
    {
        [Test]
        public void CheckStickers()
        {
            app.Navigator.GoToMainPage();
            app.Navigator.EnsureAllImageHasSticker();
        }

    }
}
