//using C2GSeleniumTeste.Setup;
//using C2GSeleniumTeste.Tests;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;



//namespace C2GSeleniumTeste.LocalTests
//{
//    [TestFixture]
//    public class CloudExpertTestsSand
//    {
//        private IWebDriver driver;

        //[SetUp]
        //public void Setup()
        //{
        //    BrowserManager.OpenBrowserSand();
        //    driver = BrowserManager.Driver;
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //}

        //[Test]
        //public void SuccessRegistrationTests()
        //{
        //    SuccessRegistrationTest.CreateAccount(driver);
        //    SuccessRegistrationTest.LoginSuccess(driver);
        //    SuccessRegistrationTest.SelectCloudExpertProfile(driver);
        //    SuccessRegistrationTest.CloudExpertOptionsTest(driver);
        //}

        //[Test]
        //public void IncorrectRegistrationTests()
        //{
        //    IncorrectRegistrationTest.TryCreateAccountIncorrect(driver);
        //    IncorrectRegistrationTest.TryCreateExistingAccount(driver);
        //}

        //[Test]
        //public void SuccessCloudExpertProfile()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    SuccessTests.AddPublicNameAndAboutField(driver, "sand");
        //    SuccessTests.SaveTestPicture(driver);
        //    SuccessTests.UploadCloudExpertImg(driver);
        //    SuccessTests.RemoveCloudExpertImg(driver);
        //    SuccessTests.AddLanguages(driver);
        //    SuccessTests.RemoveLanguages(driver);
        //    SuccessTests.CorrectAdress(driver);
        //    SuccessTests.DownloadW8BenForm(driver);
        //    SuccessTests.UploadW8BenForm(driver, "sand");
        //    SuccessTests.CopyW8BenForm(driver);
        //}

        //[Test]
        //public void SuccessLoginContact()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    SuccessTests.AddUserInformation(driver, "sand");
        //    SuccessTests.UploadUserPicture(driver);
        //    SuccessTests.RemoveUserPicture(driver);
        //    SuccessTests.ChangePassword(driver);
        //    SuccessTests.InsertEmailContact(driver);
        //    SuccessTests.DeleteContact(driver);
        //    SuccessTests.InsertPhoneContact(driver);
        //    SuccessTests.DeleteContact(driver);
        //}

        //[Test]
        //public void SuccessCertificationAndSkills()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    SuccessTests.AddCertification(driver, "sand");
        //    SuccessTests.RemoveCertification(driver);
        //    SuccessTests.AddSkills(driver);
        //    SuccessTests.RemoveSkills(driver);
        //}

        //[Test]
        //public void SuccessAvailability()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    SuccessTests.ChangeTimezone(driver, "sand");
        //    SuccessTests.AddPreferredMeetingHours(driver);
        //    SuccessTests.RemovePreferredMeetingHours(driver);
        //}

        //[Test]
        //public void SuccessSolution()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    SuccessTests.AddSolutionBasicInformation(driver, "sand");
        //    SuccessTests.AddArtifactsUpload(driver);
        //    SuccessTests.AddSolutionDocumentation(driver);
        //    SuccessTests.PublishingSolution(driver);
        //}

        //[Test]
        //public void IncorrectCloudExpertProfile()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    IncorrectTests.EditNameWithWhitespace(driver);
        //    IncorrectTests.EditLongName(driver);
        //    IncorrectTests.EditInvalidCharactersName(driver);
        //    IncorrectTests.EditWithWrongCharactersAddress(driver);
        //    IncorrectTests.EditIncorrectAddress(driver);
        //    IncorrectTests.SaveTestPicture(driver);
        //    IncorrectTests.UploadWrongW8BenForm(driver);
        //}

        //[Test]
        //public void IncorrectLoginContact()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    IncorrectTests.UserInformationWithoutCharacters(driver, "sand");
        //    IncorrectTests.UserInformationWithInvalidCharacters(driver, "sand");
        //    IncorrectTests.UserInformationWithLongCharacters(driver, "sand");
        //    IncorrectTests.InsertContactIncorrect(driver);
        //}

        //[Test]
        //public void IncorrectCertificationAndSkills()
        //{
        //    Auth.LoginSuccessSand(driver);

        //    IncorrectTests.AddIncorrectCertification(driver, "sand");
        //}

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
