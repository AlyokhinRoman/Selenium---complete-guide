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
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        

        public void GotoLoginPage()
        {
            if (driver.Url == baseURL + "/login.php")
            {
                return;
            }

            driver.Navigate().GoToUrl(baseURL + "/login.php");
        }

        public void GotoAppearenceTemplatePage()
        {
            if (driver.Url == baseURL + "/?app=appearance&doc=template")
            {
                return;
            }

            driver.FindElement(By.LinkText("Appearence")).Click();
        }

        public bool EnsureAppearenceTemplatePageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Template']"));
            return true;
        }

        public void CheckAppearenceTemplatePage()
        {
            GotoAppearenceTemplatePage();
            EnsureAppearenceTemplatePageIsLoading();
        }

        public void GotoAppearenceLogotypePage()
        {
            if (driver.Url == baseURL + "/?app=appearance&doc=logotype")
            {
                return;
            }

            driver.FindElement(By.LinkText("Logotype")).Click();
        }

        public bool EnsureAppearenceLogotypePageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Logotype']"));
            return true;
        }

        public void CheckAppearenceLogotypePage()
        {
            GotoAppearenceLogotypePage();
            EnsureAppearenceLogotypePageIsLoading();
        }

        public void GotoCatalogPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=catalog")
            {
                return;
            }

            driver.FindElement(By.LinkText("Catalog")).Click();
        }

        public bool EnsureCatalogPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Catalog']"));
            return true;
        }

        public void GotoProductGroupsPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=product_groups")
            {
                return;
            }

            driver.FindElement(By.LinkText("Product Groups")).Click();
        }

        public bool EnsureProductGroupsIsPageLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Product Groups']"));
            return true;
        }

        public void GotoOptionGroupsPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=option_groups")
            {
                return;
            }

            driver.FindElement(By.LinkText("Option Groups")).Click();
        }

        public bool EnsureOptionGroupsIsPageLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Option Groups']"));
            return true;
        }

        public void GotoManufacturersPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=manufacturers")
            {
                return;
            }

            driver.FindElement(By.LinkText("Manufacturers")).Click();
        }

        public bool EnsureManufacturersIsPageLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Manufacturers']"));
            return true;
        }

        public void GotoSuppliersPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=suppliers")
            {
                return;
            }

            driver.FindElement(By.LinkText("Suppliers")).Click();
        }

        public bool EnsureSuppliersIsPageLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Suppliers']"));
            return true;
        }

        public void GotoDeliveryStatusesPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=delivery_statuses")
            {
                return;
            }

            driver.FindElement(By.LinkText("Delivery Statuses")).Click();
        }

        public bool EnsureDeliveryStatusesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Delivery Statuses']"));
            return true;
        }

        public void GotoSoldOutStatusesPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=sold_out_statuses")
            {
                return;
            }

            driver.FindElement(By.LinkText("Sold Out Statuses")).Click();
        }

        public bool EnsureSoldOutStatusesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Sold Out Statuses']"));
            return true;
        }

        public void GotoQuantityUnitsPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=quantity_units")
            {
                return;
            }

            driver.FindElement(By.LinkText("Quantity Units")).Click();
        }

        public bool EnsureQuantityUnitsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Quantity Units']"));
            return true;
        }

        public void GotoCSVImportExportPage()
        {
            if (driver.Url == baseURL + "/?app=catalog&doc=csv")
            {
                return;
            }

            driver.FindElement(By.LinkText("CSV Import/Export")).Click();
        }

        public bool EnsureCSVImportExportPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='CSV Import/Export']"));
            return true;
        }

        public void CheckCatalogPage()
        {
            GotoCatalogPage();
            EnsureCatalogPageIsLoading();
            GotoProductGroupsPage();
            EnsureProductGroupsIsPageLoading();
            GotoOptionGroupsPage();
            EnsureOptionGroupsIsPageLoading();
            GotoManufacturersPage();
            EnsureManufacturersIsPageLoading();
            GotoSuppliersPage();
            EnsureSuppliersIsPageLoading();
            GotoDeliveryStatusesPage();
            EnsureDeliveryStatusesPageIsLoading();
            GotoSoldOutStatusesPage();
            EnsureSoldOutStatusesPageIsLoading();
            GotoQuantityUnitsPage();
            EnsureQuantityUnitsPageIsLoading();
            GotoCSVImportExportPage();
            EnsureCSVImportExportPageIsLoading();
        }

        public void CheckCountriesPage()
        {
            GotoCountriesPage();
            EnsureCountriesPageIsLoading();
        }

        public void GotoCountriesPage()
        {
            if (driver.Url == baseURL + "/?app=countries&doc=countries")
            {
                return;
            }

            driver.FindElement(By.LinkText("Countries")).Click();
        }

        public bool EnsureCountriesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Countries']"));
            return true;
        }

        public void CheckCurrenciesPage()
        {
            GotoCurrenciesPage();
            EnsureCurrenciesPageIsLoading();
        }

        public void GotoCurrenciesPage()
        {
            if (driver.Url == baseURL + "/?app=currencies&doc=currencies")
            {
                return;
            }

            driver.FindElement(By.LinkText("Currencies")).Click();
        }

        public bool EnsureCurrenciesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Currencies']"));
            return true;
        }
            

        public void GotoCustomersPage()
        {
            if (driver.Url == baseURL + "/?app=customers&doc=customers")
            {
                return;
            }

            driver.FindElement(By.LinkText("Customers")).Click();
        }

        public bool EnsureCustomersPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Customers']"));
            return true;
        }

        public void GotoCustomersCSVImportExportPage()
        {
            if (driver.Url == baseURL + "/?app=customers&doc=csv")
            {
                return;
            }

            driver.FindElement(By.LinkText("CSV Import/Export")).Click();
        }

        public bool EnsureCustomersCSVImportExportPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='CSV Import/Export']"));
            return true;
        }

        public void GotoCustomersNewsletterPage()
        {
            if (driver.Url == baseURL + "/?app=customers&doc=newsletter")
            {
                return;
            }

            driver.FindElement(By.LinkText("Newsletter")).Click();
        }

        public bool EnsureCustomersNewsletterPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Newsletter']"));
            return true;
        }

        public void CheckCustomersPage()
        {
            GotoCustomersPage();
            EnsureCustomersPageIsLoading();
            GotoCustomersCSVImportExportPage();
            EnsureCustomersCSVImportExportPageIsLoading();
            GotoCustomersNewsletterPage();
            EnsureCustomersNewsletterPageIsLoading();
        }

        public void GotoGeoZonesPage()
        {
            if (driver.Url == baseURL + "/?app=geo_zones&doc=geo_zones")
            {
                return;
            }

            driver.FindElement(By.LinkText("Geo Zones")).Click();
        }

        public bool EnsureGeoZonesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Geo Zones']"));
            return true;
        }

        public void CheckGeoZonesPage()
        {
            GotoGeoZonesPage();
            EnsureGeoZonesPageIsLoading();
        }

        public void GotoLanguagesPage()
        {
            if (driver.Url == baseURL + "/?app=languages&doc=languages")
            {
                return;
            }

            driver.FindElement(By.LinkText("Languages")).Click();
        }

        public bool EnsureLanguagesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Languages']"));
            return true;
        }

        public void GotoStorageEncodingPage()
        {
            if (driver.Url == baseURL + "/?app=languages&doc=storage_encoding")
            {
                return;
            }

            driver.FindElement(By.LinkText("Storage Encoding")).Click();
        }

        public bool EnsureStorageEncodingPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Storage Encoding']"));
            return true;
        }

        public void CheckLanguagesPage()
        {
            GotoLanguagesPage();
            EnsureLanguagesPageIsLoading();
            GotoStorageEncodingPage();
            EnsureStorageEncodingPageIsLoading();
        }

        public void GotoModulesPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=jobs")
            {
                return;
            }

            driver.FindElement(By.LinkText("Modules")).Click();
        }

        public bool EnsureModulesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Job Modules']"));
            return true;
        }

        public void GotoModulesCustomerPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=customer")
            {
                return;
            }

            driver.FindElement(By.LinkText("Customer")).Click();
        }

        public bool EnsureModulesCustomerPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Customer Modules']"));
            return true;
        }

        public void GotoModulesShippingPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=shipping")
            {
                return;
            }

            driver.FindElement(By.LinkText("Shipping")).Click();
        }

        public bool EnsureModulesShippingPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Shipping Modules']"));
            return true;
        }

        public void GotoModulesPaymentPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=payment")
            {
                return;
            }

            driver.FindElement(By.LinkText("Payment")).Click();
        }

        public bool EnsureModulesPaymentPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Payment Modules']"));
            return true;
        }

        public void GotoModulesOrderTotalPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=order_total")
            {
                return;
            }

            driver.FindElement(By.LinkText("Order Total")).Click();
        }

        public bool EnsureModulesOrderTotalPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Order Total Modules']"));
            return true;
        }

        public void GotoModulesOrderSuccessPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=order_success")
            {
                return;
            }

            driver.FindElement(By.LinkText("Order Success")).Click();
        }

        public bool EnsureModulesOrderSuccessPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Order Success Modules']"));
            return true;
        }

        public void GotoModulesOrderActionPage()
        {
            if (driver.Url == baseURL + "/?app=modules&doc=order_action")
            {
                return;
            }

            driver.FindElement(By.LinkText("Order Action")).Click();
        }

        public bool EnsureModulesOrderActionPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Order Action Modules']"));
            return true;
        }

        public void CheckModulesPage()
        {
            GotoModulesPage();
            EnsureModulesPageIsLoading();
            GotoModulesCustomerPage();
            EnsureModulesCustomerPageIsLoading();
            GotoModulesShippingPage();
            EnsureModulesShippingPageIsLoading();
            GotoModulesPaymentPage();
            EnsureModulesPaymentPageIsLoading();
            GotoModulesOrderTotalPage();
            EnsureModulesOrderTotalPageIsLoading();
            GotoModulesOrderSuccessPage();
            EnsureModulesOrderSuccessPageIsLoading();
            GotoModulesOrderActionPage();
            EnsureModulesOrderActionPageIsLoading();
        }

        public void GotoOrdersPage()
        {
            if (driver.Url == baseURL + "/?app=orders&doc=orders")
            {
                return;
            }

            driver.FindElement(By.LinkText("Orders")).Click();
        }

        public bool EnsureOrdersPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Orders']"));
            return true;
        }

        public void GotoOrdersStatusesPage()
        {
            if (driver.Url == baseURL + "/?app=orders&doc=order_statuses")
            {
                return;
            }

            driver.FindElement(By.LinkText("Order Statuses")).Click();
        }

        public bool EnsureOrdersStatusesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Order Statuses']"));
            return true;
        }

        public void CheckOrdersPage()
        {
            GotoOrdersPage();
            EnsureOrdersPageIsLoading();
            GotoOrdersStatusesPage();
            EnsureOrdersStatusesPageIsLoading();
        }

        public void GotoPagesPage()
        {
            if (driver.Url == baseURL + "/?app=pages&doc=pages")
            {
                return;
            }

            driver.FindElement(By.LinkText("Pages")).Click();
        }

        public bool EnsurePagesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Pages']"));
            return true;
        }

        public void CheckPagesPage()
        {
            GotoPagesPage();
            EnsurePagesPageIsLoading();
        }

        public void GotoReportsMonthlySalesPage()
        {
            if (driver.Url == baseURL + "/?app=reports&doc=monthly_sales")
            {
                return;
            }

            driver.FindElement(By.LinkText("Reports")).Click();
        }

        public bool EnsureReportsMonthlySalesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Monthly Sales']"));
            return true;
        }

        public void GotoReportsMostSoldProductsPage()
        {
            if (driver.Url == baseURL + "/?app=reports&doc=most_sold_products")
            {
                return;
            }

            driver.FindElement(By.LinkText("Most Sold Products")).Click();
        }

        public bool EnsureReportsMostSoldProductsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Most Sold Products']"));
            return true;
        }

        public void GotoReportsMostShoppingCustomersPage()
        {
            if (driver.Url == baseURL + "/?app=reports&doc=most_shopping_customers")
            {
                return;
            }

            driver.FindElement(By.LinkText("Most Shopping Customers")).Click();
        }

        public bool EnsureReportsMostShoppingCustomersPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Most Shopping Customers']"));
            return true;
        }

        public void CheckReportsMonthlySalesPage()
        {
            GotoReportsMonthlySalesPage();
            EnsureReportsMonthlySalesPageIsLoading();
            GotoReportsMostSoldProductsPage();
            EnsureReportsMostSoldProductsPageIsLoading();
            GotoReportsMostShoppingCustomersPage();
            EnsureReportsMostShoppingCustomersPageIsLoading();
        }

        public void GotoSettingsStoreInfoPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=store_info")
            {
                return;
            }

            driver.FindElement(By.LinkText("Settings")).Click();
        }

        public bool EnsureSettingsStoreInfoPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsDefaultsPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=defaults")
            {
                return;
            }

            driver.FindElement(By.LinkText("Defaults")).Click();
        }

        public bool EnsureSettingsDefaultsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsGeneralPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=general")
            {
                return;
            }

            driver.FindElement(By.LinkText("General")).Click();
        }

        public bool EnsureSettingsGeneralPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsListingsPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=listings")
            {
                return;
            }

            driver.FindElement(By.LinkText("Listings")).Click();
        }

        public bool EnsureSettingsListingsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsImagesPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=images")
            {
                return;
            }

            driver.FindElement(By.LinkText("Images")).Click();
        }

        public bool EnsureSettingsImagesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsCheckoutPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=checkout")
            {
                return;
            }

            driver.FindElement(By.LinkText("Checkout")).Click();
        }

        public bool EnsureSettingsCheckoutPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsAdvancedPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=advanced")
            {
                return;
            }

            driver.FindElement(By.LinkText("Advanced")).Click();
        }

        public bool EnsureSettingsAdvancedPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void GotoSettingsSecurityPage()
        {
            if (driver.Url == baseURL + "/?app=settings&doc=security")
            {
                return;
            }

            driver.FindElement(By.LinkText("Security")).Click();
        }

        public bool EnsureSettingsSecurityPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Settings']"));
            return true;
        }

        public void CheckSettingsPage()
        {
            GotoSettingsStoreInfoPage();
            EnsureSettingsStoreInfoPageIsLoading();
            GotoSettingsDefaultsPage();
            EnsureSettingsDefaultsPageIsLoading();
            GotoSettingsGeneralPage();
            EnsureSettingsGeneralPageIsLoading();
            GotoSettingsListingsPage();
            EnsureSettingsListingsPageIsLoading();
            GotoSettingsImagesPage();
            EnsureSettingsImagesPageIsLoading();
            GotoSettingsCheckoutPage();
            EnsureSettingsCheckoutPageIsLoading();
            GotoSettingsAdvancedPage();
            EnsureSettingsAdvancedPageIsLoading();
            GotoSettingsSecurityPage();
            EnsureSettingsSecurityPageIsLoading();
        }

        public void GotoSlidesPage()
        {
            if (driver.Url == baseURL + "/?app=slides&doc=slides")
            {
                return;
            }

            driver.FindElement(By.LinkText("Slides")).Click();
        }

        public bool EnsureSlidesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Slides']"));
            return true;
        }

        public void CheckSlidesPage()
        {
            GotoSlidesPage();
            EnsureSlidesPageIsLoading();
        }

        public void GotoTaxClassesPage()
        {
            if (driver.Url == baseURL + "/?app=tax&doc=tax_classes")
            {
                return;
            }

            driver.FindElement(By.LinkText("Tax")).Click();
        }

        public bool EnsureTaxClassesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Tax Classes']"));
            return true;
        }

        public void GotoTaxRatesPage()
        {
            if (driver.Url == baseURL + "/?app=tax&doc=tax_rates")
            {
                return;
            }

            driver.FindElement(By.LinkText("Tax Rates")).Click();
        }

        public bool EnsureTaxRatesPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Tax Rates']"));
            return true;
        }

        public void CheckTaxPage()
        {
            GotoTaxClassesPage();
            EnsureTaxClassesPageIsLoading();
            GotoTaxRatesPage();
            EnsureTaxRatesPageIsLoading();
        }

        public void GotoSearchTranslationsPage()
        {
            if (driver.Url == baseURL + "/?app=translations&doc=search")
            {
                return;
            }

            driver.FindElement(By.LinkText("Translations")).Click();
        }

        public bool EnsureSearchTranslationsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Search Translations']"));
            return true;
        }

        public void GotoTranslationsScanFilesPage()
        {
            if (driver.Url == baseURL + "/?app=translations&doc=scan")
            {
                return;
            }

            driver.FindElement(By.LinkText("Scan Files")).Click();
        }

        public bool EnsureTranslationsScanFilesPageIsLoading()
        {
                driver.FindElement(By.Name("scan"));
            return true;
        }

        public void GotoTranslationsCSVImportExportPage()
        {
            if (driver.Url == baseURL + "/?app=translations&doc=csv")
            {
                return;
            }

            driver.FindElement(By.LinkText("CSV Import/Export")).Click();
        }

        public bool EnsureTranslationsCSVImportExportPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='CSV Import/Export']"));
            return true;
        }


        public void CheckSearchTranslationsPage()
        {
            GotoSearchTranslationsPage();
            EnsureSearchTranslationsPageIsLoading();
            GotoTranslationsScanFilesPage();
            EnsureTranslationsScanFilesPageIsLoading();
            GotoTranslationsCSVImportExportPage();
            EnsureTranslationsCSVImportExportPageIsLoading();
        }

        public void GotoUsersPage()
        {
            if (driver.Url == baseURL + "/?app=users&doc=users")
            {
                return;
            }

            driver.FindElement(By.LinkText("Users")).Click();
        }

        public bool EnsureUsersPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='Users']"));
            return true;
        }

        public void CheckUsersPage()
        {
            GotoUsersPage();
            EnsureUsersPageIsLoading();
        }

        public void GotovQmodsPage()
        {
            if (driver.Url == baseURL + "/?app=vqmods&doc=vqmods")
            {
                return;
            }

            driver.FindElement(By.LinkText("vQmods")).Click();
        }

        public bool EnsurevQmodsPageIsLoading()
        {
            driver.FindElement(By.XPath("//td[@id='content']//h1[normalize-space(.)='vQmods']"));
            return true;
        }

        public void CheckvQmodsPage()
        {
            GotovQmodsPage();
            EnsurevQmodsPageIsLoading();
        }

        public void CheckAllPages()
        {
            CheckAppearenceTemplatePage();
            CheckAppearenceLogotypePage();
            CheckCatalogPage();
            CheckCountriesPage();
            CheckCurrenciesPage();
            CheckCustomersPage();
            CheckGeoZonesPage();
            CheckLanguagesPage();
            CheckModulesPage();
            CheckOrdersPage();
            CheckPagesPage();
            CheckReportsMonthlySalesPage();
            CheckSettingsPage();
            CheckSlidesPage();
            CheckTaxPage();
            CheckSearchTranslationsPage();
            CheckUsersPage();
            CheckvQmodsPage();
        }

        public void ClickCatalogButton()
        {
            driver.FindElement(By.CssSelector("i.fa.fa-chevron-circle-left")).Click();
        }
        public bool EnsureMainPageIsLoading()
        {
            driver.FindElement(By.Id("cart"));
            return true;
        }

        public void GoToMainPage()
        {
            ClickCatalogButton();
            EnsureMainPageIsLoading();
        }

        string salesticker = "div.sticker.sale";
        string newsticker = "div.sticker.new";
        string sticker = "div.sticker";

        public bool EnsureAllImageHasSticker()
        {
        
            ICollection<IWebElement> images = driver.FindElements(By.CssSelector("img[class=\"image\"]"));

            int i = driver.FindElements(By.CssSelector(sticker)).Count;

            foreach (IWebElement image in images)
            {
                //if (EnsureNewSticker());
                Assert.AreEqual(i , 11);
                //else
                //EnsureSaleSticker();
                return (EnsureNewSticker() || EnsureSaleSticker());
            }
            return true;
        }

        public void CheckCountriesAlphabetOrder()
        {
            ICollection<IWebElement> countries = driver.FindElements(By.XPath("//table[@class='dataTable']"));
            var x = countries.Select(item => item.Text.Replace(Environment.NewLine, ""));
            var sorted = new List<string>();
            sorted.AddRange(x.OrderBy(o => o));
            Assert.IsTrue(x.SequenceEqual(sorted));
        }


        public void ClickCountriesCanada()
        {
            driver.FindElement(By.LinkText("Canada")).Click();
        }

        public bool EnsureCountriesCanadaPageIsOpened()
        {
            driver.FindElement(By.CssSelector("input[value=\"Canada\"]"));
            return true;
        }

        public void GoToCountriesCanadaPage()
        {
            ClickCountriesCanada();
            EnsureCountriesCanadaPageIsOpened();
        }

        public void CheckZonesAlphabetOrder()
        {
            ICollection<IWebElement> zones = driver.FindElements(By.Id("table-zones"));
            var x = zones.Select(item => item.Text.Replace(Environment.NewLine, ""));
            var sorted = new List<string>();
            sorted.AddRange(x.OrderBy(o => o));
            Assert.IsTrue(x.SequenceEqual(sorted));
        }

        public void ClickCountriesUSA()
        {
            driver.FindElement(By.LinkText("United States")).Click();
        }

        public bool EnsureCountriesUSAPageIsOpened()
        {
            driver.FindElement(By.CssSelector("input[value=\"USA\"]"));
            return true;
        }

        public void GoToCountriesUSAPage()
        {
            ClickCountriesUSA();
            EnsureCountriesUSAPageIsOpened();
        }

        public bool EnsureSaleSticker()
        {
            driver.FindElement(By.CssSelector(salesticker));
            return true;
        }

        public bool EnsureNewSticker()
        {
            driver.FindElement(By.CssSelector(newsticker));
            return true;
        }

        public void ClickGeoZonesCanada()
        {
            driver.FindElement(By.LinkText("Canada")).Click();
        }

        public bool EnsureGeoZonesCanadaPageIsLoading()
        {
            driver.FindElement(By.CssSelector("input[value=\"Canada\"]"));
            return true;
        }

        public void GoToGeoZonesCanadaPage()
        {
            ClickGeoZonesCanada();
            EnsureGeoZonesCanadaPageIsLoading();
        }

        public void ClickGeoZonesUnitedStatesOfAmerica()
        {
            driver.FindElement(By.LinkText("United States of America")).Click();
        }

        public bool EnsureGeoZonesUnitedStatesOfAmericaPageIsLoading()
        {
            driver.FindElement(By.CssSelector("input[value=\"United States of America\"]"));
            return true;
        }

        public void GoToGeoZonesUnitedStatesOfAmericaPage()
        {
            ClickGeoZonesUnitedStatesOfAmerica();
            EnsureGeoZonesUnitedStatesOfAmericaPageIsLoading();
        }

        public void GoToCampaignsArticle()
        {
            driver.FindElement(By.XPath("//div[@id='box-campaigns']/div/ul/li/a[1]/div[1]/img")).Click();
        }

        public void GoToCreateAccountPage()
        {
            ClickNewCustomersClickHereLink();
            EnsureCreateAccountPageIsLoading();
        }

        public bool EnsureCreateAccountPageIsLoading()
        {
            driver.FindElement(By.XPath(".//*[@id='create-account']/h1[text() = 'Create Account']"));
            return true;
        }

        public void ClickNewCustomersClickHereLink()
        {
            driver.FindElement(By.LinkText("New customers click here")).Click();
        }

        public void ClickCreateAccountButton()
        {
            driver.FindElement(By.Name("create_account")).Click();
        }

        public string FirstName = "firstname";
        public string LastName = "lastname";
        public string Address1 = "address1";
        public string PostCode = "postcode";
        public string City = "city";
        public string Email = "email";
        public string Phone = "phone";
        public string DesiredPassword = "password";
        public string ConfirmPassword = "confirmed_password";
        public string LoginEmail = "test2@test.com";
        public string Password = "123123";
        public string LoginEmailAddress = "email";
        public string LoginPassword = "password";

        public void FillRegistrationForm()
        {
            Type(By.Name(FirstName), "FirstName");
            Type(By.Name(LastName), "LastName");
            Type(By.Name(Address1), "Address1");
            Type(By.Name(PostCode), "21021");
            Type(By.Name(City), "City");
            //FillCountryField();
            //new SelectElement(driver.FindElement(By.CssSelector("span.select2-selection__arrow"))).SelectByText("Ukraine");
            Type(By.Name(Email), LoginEmail);
            Type(By.Name(Phone), "+380637865432");
            Type(By.Name(DesiredPassword), "123123");
            Type(By.Name(ConfirmPassword), "123123");
        }

        public void FillCountryField()
        {
            driver.FindElement(By.XPath("//span[@id='select2-country_code-qh-container']")).Click();
            driver.FindElement(By.CssSelector("input.select2-search__field")).SendKeys("Ukraine");
        }
        
        public void RegisterNewUser()
        {
            GoToCreateAccountPage();
            FillRegistrationForm();
            ClickCreateAccountButton();
            Logout();
            Login();
        }

        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        public void Login()
        {
            Type(By.Name(LoginEmailAddress), LoginEmail);
            Type(By.Name(LoginPassword), Password);
            ClickLoginButton();
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.Name("login")).Click();
        }

        public void AddNewProduct()
        {
            GoTokAddNewProductPage();
            FillNewProductData();
        }

        public void FillNewProductData()
        {
            FillGeneralTabData();
            FillInformationTabData();
            FillPricesTabData();
            ClickSaveButton();
        }

        public void ClickSaveButton()
        {
            driver.FindElement(By.Name("save")).Click();
        }

        public string pricesUSD = "prices[USD]";

        public void FillPricesTabData()
        {
            GoToPricesDataTab();
            Type(By.Name(pricesUSD), "100");
        }

        public void GoToPricesDataTab()
        {
            ClickPricesTab();
            EnsurePricesTabIsLoading();
        }

        public bool EnsurePricesTabIsLoading()
        {
            driver.FindElement(By.XPath(".//*[@id='tab-prices']/h2[1][text() = 'Prices']"));
            return true;
        }

        public void ClickPricesTab()
        {
            driver.FindElement(By.LinkText("Prices")).Click();
        }


        public string keywords = "keywords";
        public string shortDdescription = "short_description[en]";
        public string description = "description[en]";
        public string headTitle = "head_title[en]";
        public string metaDescription = "meta_description[en]";


        public void FillInformationTabData()
        {
            GotoInformationDataTab();
            Type(By.Name(keywords), "Keywords");
            Type(By.Name(shortDdescription), "ShortDdescription");
            Type(By.Name(description), "Description");
            Type(By.Name(headTitle), "HeadTitle");
            Type(By.Name(metaDescription), "MetaDescription");
        }

        public void GotoInformationDataTab()
        {
            ClickInformationTab();
            EnsureInformationTabIsLoaded();
        }

        public bool EnsureInformationTabIsLoaded()
        {
            driver.FindElement(By.XPath(".//*[@id='tab-information']/table/tbody/tr[1]/td/strong[text() = 'Manufacturer']"));
            return true;
        }

        public void ClickInformationTab()
        {
            driver.FindElement(By.LinkText("Information")).Click();
        }


        public string productName = "name[en]";
        public string productCode = "code";
        public string dateValidFrom = "date_valid_from";
        public string dateValidTo = "date_valid_to";

        
        public void FillGeneralTabData()
        {
            Type(By.Name(productName), "productName");
            Type(By.Name(productCode), "productCode");
            //Type(By.Name(dateValidFrom), "20161212");
            //Type(By.Name(dateValidTo), "12-12-2017");
        }

        public void GoTokAddNewProductPage()
        {
            ClickAddNewProductButton();
            EnsureAddNewProductPageIsLoading();

        }

        public bool EnsureAddNewProductPageIsLoading()
        {
            driver.FindElement(By.XPath(".//*[@id='content']/h1[text() = ' Add New Product']"));
            return true;
        }

        public void ClickAddNewProductButton()
        {
            driver.FindElement(By.LinkText("Add New Product")).Click();
        }

        public void CheckProductAdded()
        {
            ICollection<IWebElement> productList = driver.FindElements(By.CssSelector("tr[class=\"row semi-transparent\"]"));
            var x = productList.Select(item => item.Text.Replace(Environment.NewLine, ""));
            var sorted = new List<string>();
            sorted.Contains(productName);
        }

        public void Add1ProductToCheckout()
        {
            GoToCampaignsArticle();
            SelectSmallSize();
            ClickAddToCartButton();
            Check1CartIsUpdated();
            driver.Navigate().Back();
        }

        public void SelectSmallSize()
        {
            driver.FindElement(By.XPath("//td[@class='options']/select//option[2]")).Click();
        }

        public void Check1CartIsUpdated()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='1']")));
        }

        public void ClickAddToCartButton()
        {
            //if (EnsureOptionsSizeIsDisplayed())
            //{
            //    driver.FindElement(By.XPath("//td[@class='options']/select//option[2]")).Submit();
            //}
            //else
            driver.FindElement(By.Name("add_cart_product")).Click();
        }

        public bool EnsureOptionsSizeIsDisplayed()
        {
            driver.FindElement(By.XPath(".//*[@id='box-product']/div[2]/div[2]/div[5]/form/table/tbody/tr[1]/td/strong[text() = 'Size']"));
            return true;
        }

        public void GoToMostPopularProduct()
        {
            driver.FindElement(By.XPath("//div[@id='box-most-popular']/div/ul/li[1]/a[1]/div[1]/img")).Click();
        }

        public void Add3ProductToCheckout()
        {
            GoToCampaignsArticle();
            SelectSmallSize();
            ClickAddToCartButton();
            Check3CartIsUpdated();
        }

        public void Check3CartIsUpdated()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='3']")));
        }

        public void Add2ProductToCheckout()
        {
            GoToCampaignsArticle();
            SelectSmallSize();
            ClickAddToCartButton();
            Check2CartIsUpdated();
            driver.Navigate().Back();
        }
        public void Check2CartIsUpdated()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='cart']//span[.='2']")));
        }

        public void DeleteProductsFromCheckout()
        {
            OpenCheckoutPage();
            ClickRemoveButton();
            CheckIsTableUpdated();
            
        }

        private void CheckIsTableUpdated()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.Id("order_confirmation-wrapper")));
        }

        

        public void ClickRemoveButton()
        {
            driver.FindElement(By.Name("remove_cart_item"));
        }

        public void OpenCheckoutPage()
        {
            ClickChekoutlink();
            EnsureCheckoutpageIsLoading();
        }

        public bool EnsureCheckoutpageIsLoading()
        {
            driver.FindElement(By.XPath(".//*[@id='box-checkout-summary']/h2[text() = 'Order Summary']"));
            return true;
        }

        private void ClickChekoutlink()
        {
            driver.FindElement(By.LinkText("Checkout »")).Click();
        }
    }
}
