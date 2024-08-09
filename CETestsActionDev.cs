using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace C2GSeleniumTeste
{
    [TestFixture]
    public class CETestsActionDev
    {
        private IWebDriver driver;

        private readonly string environment = "dev";

        private static int _randomNumber;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new();
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--headless");

            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Test]
        public void SuccessCloudExpertProfile()
        {
            LoginSuccessDev(driver);
          //  AddPublicNameAndAboutField(driver);
            //SaveTestPicture(driver);
            //UploadCloudExpertImg(driver);
            //RemoveCloudExpertImg(driver);
            //AddLanguages(driver);
            //RemoveLanguages(driver);
            //CorrectAdress(driver);
            //DownloadW8BenForm(driver);
            //UploadW8BenForm(driver);
            //CopyW8BenForm(driver);
        }

        [Test]
        public void TestGoogleHomePage()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            var title = driver.Title;

            Assert.That(title, Is.EqualTo("Google"));

            driver.Quit();
        }
        //Tentar com Circle CI agora
        public void LoginSuccessDev(IWebDriver driver)
{
    driver.Navigate().GoToUrl("https://auth-dev.cloud2gether.com/auth/login/password");

    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    IWebElement userNameField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='userName']")));
    
    string emailDev = "davi262016+100@gmail.com";
    userNameField.SendKeys(emailDev);

    IWebElement passwordField = driver.FindElement(By.XPath("//*[@id='password']"));
    passwordField.SendKeys("testCloud2Gether");

    IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='buttonForm']"));
    loginButton.Click();

    // Espere até que a URL seja a esperada
    wait.Until(ExpectedConditions.UrlToBe("https://expert-dev.cloud2gether.com/"));
    
    string currentUrl = driver.Url;
    string expectedUrl = "https://expert-dev.cloud2gether.com/";

    Assert.That(currentUrl, Is.EqualTo(expectedUrl));
}


        public void AddPublicNameAndAboutField(IWebDriver driver)
        {
            if (environment == "dev")
            {
                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
            }
            else
            {
                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
            }


            Thread.Sleep(TimeSpan.FromSeconds(1));

            var firstName = driver.FindElement(By.XPath("//*[@id='name']"));
            firstName.Clear();
            firstName.SendKeys("Davi");

            IWebElement about = driver.FindElement(By.XPath("//textarea[@id='about']"));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            about.SendKeys("Hello, I'm Davi. I'm 19 years old and work as a software engineer.");

            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.FindElement(By.XPath("(//button[@id='buttonForm'])[1]")).Click();

            string notificationMessage = "Cloud expert profile updated successfully.";

            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        //public void SaveTestPicture(IWebDriver driver)
        //{
        //    Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

        //    Random random = new();
        //    _randomNumber = random.Next(1, 10000);

        //    string fileName = $"D:\\InnovtImageTest{_randomNumber}.png";

        //    screenshot.SaveAsFile(fileName);
        //}

        //public void UploadCloudExpertImg(IWebDriver driver)
        //{
        //    string imgPath = $"D:\\InnovtImageTest{_randomNumber}.png";
        //    IWebElement inputFile = driver.FindElement(By.XPath("//input[@class='input__file']"));
        //    inputFile.SendKeys(imgPath);
        //    Thread.Sleep(TimeSpan.FromSeconds(3));

        //    string notificationMessage = "Cloud expert picture updated successfully";

        //    //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        //}

        //public void RemoveCloudExpertImg(IWebDriver driver)
        //{
        //    driver.Navigate().Refresh();

        //    driver.FindElement(By.XPath("//button[@aria-label='Remove image' and text()=' Remove ']")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2));
        //    driver.FindElement(By.XPath("//button[@class='mdc-button mdc-button--unelevated mat-mdc-unelevated-button mat-primary mat-mdc-button-base']")).Click();
        //    Thread.Sleep(TimeSpan.FromSeconds(2));

        //    string notificationMessage = "Cloud expert picture removed successfully";

        //    //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        //}

        public static void AddLanguages(IWebDriver driver)
        {
            driver.Navigate().Refresh();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            IWebElement clickLanguages = driver.FindElement(By.Id("languages"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", clickLanguages);
            js.ExecuteScript("arguments[0].click();", clickLanguages);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and text()='Portuguese']")).Click();
            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Add language']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            driver.FindElement(By.XPath("//*[@id='languages']")).Click();
            driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and text()='English']")).Click();
            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Add language']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));

            string notificationMessage = "Language added successfully";

            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        public static void RemoveLanguages(IWebDriver driver)
        {
            Actions actions = new(driver);
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='col-12 pt-3']//button[@class='btn btn-outline-secondary btn-sm' and contains(text(), 'English')]//span[@class='btn fw-bold p-0 m-0 ms-2' and @style='font-size: 14px;' and text()='X']")));
            Thread.Sleep(TimeSpan.FromSeconds(4));
            actions.MoveByOffset(50, 0).Click(element).Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='col-12 pt-3']//button[@class='btn btn-outline-secondary btn-sm' and contains(text(), 'Portuguese')]//span[@class='btn fw-bold p-0 m-0 ms-2' and @style='font-size: 14px;' and text()='X']")));
            element.Click();

            string notificationMessage = "Language deleted successfully.";

            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        public static void CorrectAdress(IWebDriver driver)
        {
            driver.Navigate().Refresh();
            Thread.Sleep(TimeSpan.FromSeconds(1));

            var streetField = driver.FindElement(By.XPath("//*[@id=\'Street\']"));
            streetField.Clear();
            streetField.SendKeys("Magalhaes Neto");
            var numberField = driver.FindElement(By.XPath("//*[@id=\'Number\']"));
            numberField.Clear();
            numberField.SendKeys("150");
            var complementField = driver.FindElement(By.XPath("//*[@id=\'Complement\']"));
            complementField.Clear();
            complementField.SendKeys("Predio Azul");
            var zipCodeField = driver.FindElement(By.XPath("//*[@id=\'ZipCode\']"));
            zipCodeField.Clear();
            zipCodeField.SendKeys("45301-320");
            var cityField = driver.FindElement(By.XPath("//*[@id=\'City\']"));
            cityField.Clear();
            cityField.SendKeys("Salvador");
            var stateField = driver.FindElement(By.XPath("//*[@id=\'State\']"));
            stateField.Clear();
            stateField.SendKeys("Bahia");
            var countryField = driver.FindElement(By.XPath("//*[@id=\'Country\']"));
            countryField.Clear();
            countryField.SendKeys("Brazil");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            IWebElement button = driver.FindElement(By.XPath("(//button[@id='buttonForm'])[3]"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", button);

            string notificationMessage = "Address updated successfully!";

            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        public static void DownloadW8BenForm(IWebDriver driver)
        {
            IWebElement button = driver.FindElement(By.XPath("//div[@class='col-12 col-md-auto']//span[@class='mdc-button__label']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", button);
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            string currentUrl = driver.Url;
            string expectedUrl = "https://www.irs.gov/pub/irs-pdf/fw8ben.pdf";

            Assert.That(currentUrl, Is.EqualTo(expectedUrl));
        }

        public void UploadW8BenForm(IWebDriver driver)
        {
            if (environment == "dev")
            {
                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
            }
            else
            {
                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
            }

            string imgPath = @"C:\Users\Ciro\Downloads\fw8ben.pdf";
            IWebElement inputFile = driver.FindElement(By.XPath("//div[@class='col-12 col-md-auto']/input[@type='file']"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].removeAttribute('hidden')", inputFile);

            Thread.Sleep(TimeSpan.FromSeconds(3));
            inputFile.SendKeys(imgPath);

            Thread.Sleep(TimeSpan.FromSeconds(2));

            string notificationMessage = "Document uploaded successfully.";

            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        public static void CopyW8BenForm(IWebDriver driver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            IWebElement downloadCopy = driver.FindElement(By.XPath("//button[contains(text(), 'Download copy')]"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", downloadCopy);


            string notificationMessage = "Document downloaded successfully.";
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
