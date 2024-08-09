//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.Net;
//using System.Threading;

//namespace C2GSeleniumTeste.Setup
//{
//    class Auth
//    {
//        public static void LoginSuccessSand(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            string emailSand = "davi262016+125@gmail.com";
            
//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys(emailSand);
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("testCloud2Gether");

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//*[@id='buttonForm']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(10));
//        }

//        public static void LoginSuccessDev(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            string emailDev = "davi262016+100@gmail.com";

//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys(emailDev);
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("testCloud2Gether");

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//*[@id='buttonForm']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(10));
//        }

//        public static void ClickEditProfile(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Edit']")).Click();
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            wait.Until(ExpectedConditions.UrlToBe("https://expert-sand.cloud2gether.com/account/cloud-expert-profile"));

//            string currentUrl = driver.Url;
//            string expectedUrl = "https://expert-sand.cloud2gether.com/account/cloud-expert-profile";

//            Assert.That(currentUrl, Is.EqualTo(expectedUrl));
//        }


//        public static void SelectCloudExpertProfile(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement spanElement = driver.FindElement(By.XPath("//span[contains(text(), 'Cloud expert')]"));
//            IWebElement button = driver.FindElement(By.XPath("/html/body/app-root/app-register-page/invt-content/div/app-register-profile/div/div[2]/div/div/div/invt-button/container-element/button"));

//            Actions actions = new Actions(driver);
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
//            driver.FindElement(By.XPath("/html/body/app-root/invt-content/app-registration/invt-card/div/form/div[4]/invt-button/container-element/button")).Click();
//        }
//    }
//}