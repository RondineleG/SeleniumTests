//using C2GSeleniumTeste.Tests;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;



//namespace C2GSeleniumTeste.LocalTests
//{
//    [TestFixture]
//    public class CloudExpertTestsDev
//    {
//        private IWebDriver driver;

//        [SetUp]
//        public void Setup()
//        {
//            BrowserManager.OpenBrowserDev();
//            driver = BrowserManager.Driver;
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//        }

//        [Test]
//        public void SuccessRegistrationTests()
//        {
//            SuccessRegistrationTest.CreateAccount(driver);
//            SuccessRegistrationTest.LoginSuccess(driver);
//            SuccessRegistrationTest.SelectCloudExpertProfile(driver);
//            SuccessRegistrationTest.CloudExpertOptionsTest(driver);
//        }

//        [Test]
//        public void IncorrectRegistrationTests()
//        {
//            IncorrectRegistrationTest.TryCreateAccountIncorrect(driver);
//            IncorrectRegistrationTest.TryCreateExistingAccount(driver);
//        }

//        [Test]
//        public void SuccessCloudExpertProfile()
//        {
//            Auth.LoginSuccessDev(driver);

//            SuccessTests.AddPublicNameAndAboutField(driver, "dev");
//            SuccessTests.SaveTestPicture(driver);
//            SuccessTests.UploadCloudExpertImg(driver);
//            SuccessTests.RemoveCloudExpertImg(driver);
//            SuccessTests.AddLanguages(driver);
//            SuccessTests.RemoveLanguages(driver);
//            SuccessTests.CorrectAdress(driver);
//            SuccessTests.DownloadW8BenForm(driver);
//            SuccessTests.UploadW8BenForm(driver, "dev");
//            SuccessTests.CopyW8BenForm(driver);
//        }

//        [Test]
//        public void SuccessLoginContact()
//        {
//            Auth.LoginSuccessDev(driver);

//            SuccessTests.AddUserInformation(driver, "dev");
//            SuccessTests.UploadUserPicture(driver);
//            SuccessTests.RemoveUserPicture(driver);
//            SuccessTests.ChangePassword(driver);
//            SuccessTests.InsertEmailContact(driver);
//            SuccessTests.DeleteContact(driver);
//            SuccessTests.InsertPhoneContact(driver);
//            SuccessTests.DeleteContact(driver);
//        }

//        [Test]
//        public void SuccessCertificationAndSkills()
//        {
//            Auth.LoginSuccessDev(driver);

//            SuccessTests.AddCertification(driver, "dev");
//            SuccessTests.RemoveCertification(driver);
//            SuccessTests.AddSkills(driver);
//            SuccessTests.RemoveSkills(driver);
//        }

//        [Test]
//        public void SuccessAvailability()
//        {
//            Auth.LoginSuccessDev(driver);

//            SuccessTests.ChangeTimezone(driver, "dev");
//            SuccessTests.AddPreferredMeetingHours(driver);
//            SuccessTests.RemovePreferredMeetingHours(driver);
//        }

//        [Test]
//        public void SuccessSolution()
//        {
//            Auth.LoginSuccessDev(driver);

//            SuccessTests.AddSolutionBasicInformation(driver, "dev");
//            SuccessTests.AddArtifactsUpload(driver);
//            SuccessTests.AddSolutionDocumentation(driver);
//            SuccessTests.PublishingSolution(driver);
//        }

//        [Test]
//        public void IncorrectCloudExpertProfile()
//        {
//            Auth.LoginSuccessDev(driver);

//            IncorrectTests.EditNameWithWhitespace(driver);
//            IncorrectTests.EditLongName(driver);
//            IncorrectTests.EditInvalidCharactersName(driver);
//            IncorrectTests.EditWithWrongCharactersAddress(driver);
//            IncorrectTests.EditIncorrectAddress(driver);
//            IncorrectTests.SaveTestPicture(driver);
//            IncorrectTests.UploadWrongW8BenForm(driver);
//        }

//        [Test]
//        public void IncorrectLoginContact()
//        {
//            Auth.LoginSuccessDev(driver);

//            IncorrectTests.UserInformationWithoutCharacters(driver, "dev");
//            IncorrectTests.UserInformationWithInvalidCharacters(driver, "dev");
//            IncorrectTests.UserInformationWithLongCharacters(driver, "dev");
//            IncorrectTests.InsertContactIncorrect(driver);
//        }

//        [Test]
//        public void IncorrectCertificationAndSkills()
//        {
//            Auth.LoginSuccessDev(driver);

//            IncorrectTests.AddIncorrectCertification(driver, "dev");
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            driver.Quit();
//        }

//        public static void InnovtNotificationAssert(string notificationMessage, IWebDriver driver)
//        {
//            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
//            var notification = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//invt-notification[@class='ng-star-inserted']//span")));

//            string actualNotification = notification.Text;

//            Assert.That(actualNotification, Does.Contain(notificationMessage));
//        }
//    }
//}
