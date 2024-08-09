//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace C2GSeleniumTeste.Setup
//{
//    public class SuccessRegistrationTest
//    {
//        private static int _randomNumber;

//        public static void CreateAccount(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//a[text()='Sign up']")).Click();
//            driver.FindElement(By.XPath("//*[@id='firstName']")).SendKeys("Davi");
//            driver.FindElement(By.XPath("//*[@id='lastName']")).SendKeys("Luquini");
//            Random random = new();
//            _randomNumber = random.Next(1, 10000);

//            string email = $"developer+{_randomNumber}@cloud2gether.com";

//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys(email);
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("testCloud2Gether");
//            driver.FindElement(By.Id("confirmPassword")).SendKeys("testCloud2Gether");
//            driver.FindElement(By.Id("jobPosition")).Click();
//            driver.FindElement(By.CssSelector("span.mdc-list-item__primary-text")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//button[@_ngcontent-ng-c779356000]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(20));

//            string currentUrl = driver.Url;
//            string expectedUrl = "a";

//            //Assert.That(currentUrl, Is.EqualTo(expectedUrl));
//        }

//        public static void LoginSuccess(IWebDriver driver)
//        {
//            driver.Navigate().GoToUrl("https://auth-sand.cloud2gether.com/auth/login/password");

//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys("developer@Cloud2gether.com");
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("testCloud2Gether");

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//*[@id='buttonForm']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(10));
//        }

//        public static void SelectCloudExpertProfile(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement spanElement = driver.FindElement(By.XPath("//span[contains(text(), 'Cloud expert')]"));
//            IWebElement button = driver.FindElement(By.XPath("/html/body/app-root/app-register-page/invt-content/div/app-register-profile/div/div[2]/div/div/div/invt-button/container-element/button"));

//            Actions actions = new(driver);
//            actions.MoveToElement(spanElement).Perform();

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            button.Click();
//        }

//        public static void CloudExpertOptionsTest(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//*[@id=\'name\']")).SendKeys("Davi");
//            driver.FindElement(By.XPath("//*[text()='Languages']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("//*[@id=\"mat-option-1\"]")).Click();
//            driver.FindElement(By.XPath("//*[text()='Languages']")).Click();
//            driver.FindElement(By.XPath("//*[@id=\"mat-option-5\"]")).Click();
//            driver.FindElement(By.XPath("//*[text()='Skills']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("//*[@id=\"mat-option-12\"]")).Click();
//            driver.FindElement(By.XPath("//*[text()='Skills']")).Click();
//            driver.FindElement(By.XPath("//*[@id=\"mat-option-14\"]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            //driver.FindElement(By.XPath("/html/body/app-root/invt-content/app-registration/invt-card/div/form/div[4]/invt-button/container-element/button")).Click();
//        }

//    }
//}
