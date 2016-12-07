using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;


namespace Selenium_Complete_Guide
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        
        protected NavigationHelper navigator;
        protected LoginHelper loginHelper;




        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {

            //driver = new ChromeDriver();
            //driver = new InternetExplorerDriver();
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);

            //InternetExplorerOptions options = new InternetExplorerOptions();
            //options.RequireWindowFocus = true;
            //driver = new InternetExplorerDriver(options);

            // new schema:
            //IWebDriver driver = new FirefoxDriver();

            // new schema more clearly:
            //FirefoxOptions options = new FirefoxOptions();
            //options.UseLegacyImplementation = false;
            //driver = new FirefoxDriver(options);

            // old schema:
            //FirefoxOptions options = new FirefoxOptions();
            //options.UseLegacyImplementation = true;
            //driver = new FirefoxDriver(options);

            //Nightly
            //FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"c:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            //driver = new FirefoxDriver(options);

            //FirefoxBinary binary = new FirefoxBinary(@"c:\Program Files (x86)\Firefox Developer Edition\firefox.exe");
            //driver = new FirefoxDriver(binary, new FirefoxProfile());


            //driver = new FirefoxDriver();
            //FirefoxProfile profile = new FirefoxProfile();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));


            baseURL = "http://localhost:8080/litecart/admin";

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
           
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                app.Value = newInstance;
                newInstance.Navigator.GotoLoginPage();

            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }
    }
}



