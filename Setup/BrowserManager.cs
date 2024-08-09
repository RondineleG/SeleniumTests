//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace C2GSeleniumTeste
//{
//    public class BrowserManager
//    {
//        private static IWebDriver driver;

//        public static IWebDriver Driver
//        {
//            get { return driver; }
//        }

//        public static void OpenBrowserSand()
//        {
//            driver = new ChromeDriver();

//            string urlSand = "https://auth-sand.cloud2gether.com/auth/login/password";

//            driver.Navigate().GoToUrl(urlSand);
//            driver.Manage().Window.Maximize();

//        }

//        public static void OpenBrowserDev()
//        {
//            driver = new ChromeDriver();

//            string urlDev = "https://auth-dev.cloud2gether.com/auth/login/password";

//            driver.Navigate().GoToUrl(urlDev);
//            driver.Manage().Window.Maximize();

//        }

//        public static void CloseBrowser()
//        {
//            driver.Quit();
//        }
//    }
//}