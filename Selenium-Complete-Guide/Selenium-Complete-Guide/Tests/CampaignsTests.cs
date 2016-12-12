using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium_Complete_Guide
{
    public class CampaignsTests : AuthTestBase
    {
        [Test]

        public void CheckCampaignsTest()
        {
            app.Navigator.GoToMainPage();
        
            var mainPageArticleName = app.Driver.FindElement(By.CssSelector("div[id=\"box-campaigns\"]")).GetAttribute("outerText").Contains("Yellow Duck");
            var mainPageRegularPrice = app.Driver.FindElement(By.CssSelector("s[class=\"regular-price\"]")).GetAttribute("textContent");
            var mainPageCampaignPrice = app.Driver.FindElement(By.CssSelector("strong[class=\"campaign-price\"]")).GetAttribute("textContent");

            app.Navigator.GoToCampaignsArticle();

            var articlePageName = app.Driver.FindElement(By.CssSelector("h1[itemprop=\"name\"]")).GetAttribute("outerText");
            var ArticlePageRegularPrice = app.Driver.FindElement(By.CssSelector("s[class=\"regular-price\"]")).GetAttribute("textContent");
            var ArticlePageCampaignPrice = app.Driver.FindElement(By.CssSelector("strong[class=\"campaign-price\"]")).GetAttribute("textContent");

            Assert.IsTrue(mainPageArticleName, articlePageName);
            Assert.AreEqual(mainPageRegularPrice, ArticlePageRegularPrice);
            Assert.AreEqual(mainPageCampaignPrice, ArticlePageCampaignPrice);
        }
    }
}
