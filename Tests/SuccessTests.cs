//using C2GSeleniumTeste.LocalTests;
//using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Reflection.Metadata;

//namespace C2GSeleniumTeste.Tests
//{
//    public class SuccessTests
//    {
//        private static int _randomNumber;

//        //Refatorar parametro para ser variavel estatica e nao precisar ser adicionada atraves de parametro
        
//        public static void AddPublicNameAndAboutField(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }


//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            var firstName = driver.FindElement(By.XPath("//*[@id='name']"));
//            firstName.Clear();
//            firstName.SendKeys("Davi");

//            IWebElement about = driver.FindElement(By.XPath("//textarea[@id='about']"));
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            about.SendKeys("Hello, I'm Davi. I'm 19 years old and work as a software engineer.");

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("(//button[@id='buttonForm'])[1]")).Click();

//            string notificationMessage = "Cloud expert profile updated successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void SaveTestPicture(IWebDriver driver)
//        {
//            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

//            Random random = new();
//            _randomNumber = random.Next(1, 10000); 

//            string fileName = $"C:\\InnovtImageTest{_randomNumber}.png";

//            screenshot.SaveAsFile(fileName);
//        }

//        public static void UploadCloudExpertImg(IWebDriver driver)
//        {
//            string imgPath = $"D:\\InnovtImageTest{_randomNumber}.png";
//            IWebElement inputFile = driver.FindElement(By.XPath("//input[@class='input__file']"));
//            inputFile.SendKeys(imgPath);
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "Cloud expert picture updated successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemoveCloudExpertImg(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//button[@aria-label='Remove image' and text()=' Remove ']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//button[@class='mdc-button mdc-button--unelevated mat-mdc-unelevated-button mat-primary mat-mdc-button-base']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            string notificationMessage = "Cloud expert picture removed successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void AddLanguages(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            Thread.Sleep(TimeSpan.FromSeconds(5));
//            IWebElement clickLanguages = driver.FindElement(By.Id("languages"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", clickLanguages);
//            js.ExecuteScript("arguments[0].click();", clickLanguages);
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and text()='Portuguese']")).Click();
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Add language']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(4));
//            driver.FindElement(By.XPath("//*[@id='languages']")).Click();
//            driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and text()='English']")).Click();
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Add language']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "Language added successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemoveLanguages(IWebDriver driver)
//        {
//            Actions actions = new(driver);
//            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

//            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='col-12 pt-3']//button[@class='btn btn-outline-secondary btn-sm' and contains(text(), 'English')]//span[@class='btn fw-bold p-0 m-0 ms-2' and @style='font-size: 14px;' and text()='X']")));
//            Thread.Sleep(TimeSpan.FromSeconds(4));
//            actions.MoveByOffset(50, 0).Click(element).Build().Perform();
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='col-12 pt-3']//button[@class='btn btn-outline-secondary btn-sm' and contains(text(), 'Portuguese')]//span[@class='btn fw-bold p-0 m-0 ms-2' and @style='font-size: 14px;' and text()='X']")));
//            element.Click();

//            string notificationMessage = "Language deleted successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void CorrectAdress(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            var streetField = driver.FindElement(By.XPath("//*[@id=\'Street\']"));
//            streetField.Clear();
//            streetField.SendKeys("Magalhaes Neto");
//            var numberField = driver.FindElement(By.XPath("//*[@id=\'Number\']"));
//            numberField.Clear();
//            numberField.SendKeys("150");
//            var complementField = driver.FindElement(By.XPath("//*[@id=\'Complement\']"));
//            complementField.Clear();
//            complementField.SendKeys("Predio Azul");
//            var zipCodeField = driver.FindElement(By.XPath("//*[@id=\'ZipCode\']"));
//            zipCodeField.Clear();
//            zipCodeField.SendKeys("45301-320");
//            var cityField = driver.FindElement(By.XPath("//*[@id=\'City\']"));
//            cityField.Clear();
//            cityField.SendKeys("Salvador");
//            var stateField = driver.FindElement(By.XPath("//*[@id=\'State\']"));
//            stateField.Clear();
//            stateField.SendKeys("Bahia");
//            var countryField = driver.FindElement(By.XPath("//*[@id=\'Country\']"));
//            countryField.Clear();
//            countryField.SendKeys("Brazil");
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            IWebElement button = driver.FindElement(By.XPath("(//button[@id='buttonForm'])[3]"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", button);

//            string notificationMessage = "Address updated successfully!";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void DownloadW8BenForm(IWebDriver driver)
//        {
//            IWebElement button = driver.FindElement(By.XPath("//div[@class='col-12 col-md-auto']//span[@class='mdc-button__label']"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", button);
//            driver.SwitchTo().Window(driver.WindowHandles[1]);

//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            string currentUrl = driver.Url;
//            string expectedUrl = "https://www.irs.gov/pub/irs-pdf/fw8ben.pdf";

//            Assert.That(currentUrl, Is.EqualTo(expectedUrl));
//        }

//        public static void UploadW8BenForm(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }

//            string imgPath = @"C:\Users\Ciro\Downloads\fw8ben.pdf";
//            IWebElement inputFile = driver.FindElement(By.XPath("//div[@class='col-12 col-md-auto']/input[@type='file']"));

//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].removeAttribute('hidden')", inputFile);

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            inputFile.SendKeys(imgPath);

//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            string notificationMessage = "Document uploaded successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void CopyW8BenForm(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            IWebElement downloadCopy = driver.FindElement(By.XPath("//button[contains(text(), 'Download copy')]"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", downloadCopy);


//            string notificationMessage = "Document downloaded successfully.";
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void AddUserInformation(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/login-contacts");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/login-contacts");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            var firstName = driver.FindElement(By.Id("firstName"));
//            firstName.Clear();
//            firstName.SendKeys("Davi");
//            var lastName = driver.FindElement(By.Id("lastName"));
//            lastName.Clear();
//            lastName.SendKeys("Luquini");
//            driver.FindElement(By.XPath("//*[@id=\'jobPositionId\']")).Click();
//            driver.FindElement(By.XPath("//*[@id=\'mat-option-3\']")).Click();
//            driver.FindElement(By.XPath(" //*[@id=\'buttonForm\']")).Click();

//            string notificationMessage = "User information updated successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void UploadUserPicture(IWebDriver driver)
//        {
//            string imgPath = $"D:\\InnovtImageTest{_randomNumber}.png";
//            IWebElement inputFile = driver.FindElement(By.XPath("//input[@class='input__file']"));
//            inputFile.SendKeys(imgPath);
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "User picture updated successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemoveUserPicture(IWebDriver driver)
//        {

//            driver.FindElement(By.XPath("//button[@aria-label='Remove image' and text()=' Remove ']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//button[@class='mdc-button mdc-button--unelevated mat-mdc-unelevated-button mat-primary mat-mdc-button-base']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            string notificationMessage = "Your photo has been successfully removed";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void ChangePassword(IWebDriver driver)
//        {

//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-button__label') and text()='Change password']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//input[@id='previousPassword']")).SendKeys("testCloud2Gether");
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//input[@placeholder='Insert new password']")).SendKeys("testCloud2Gether1");
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//input[@placeholder='Confirm your new password']")).SendKeys("testCloud2Gether1");

//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//button[contains(@class, 'mat-mdc-button') and contains(@class, 'mat-primary') and contains(@class, 'ng-star-inserted') and contains(span[@class='mdc-button__label'], 'Confirm')]")).Click();

//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-button__label') and text()='Change password']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//input[@id='previousPassword']")).SendKeys("testCloud2Gether1");
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//input[@placeholder='Insert new password']")).SendKeys("testCloud2Gether");
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//input[@placeholder='Confirm your new password']")).SendKeys("testCloud2Gether");

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//button[contains(@class, 'mat-mdc-button') and contains(@class, 'mat-primary') and contains(@class, 'ng-star-inserted') and contains(span[@class='mdc-button__label'], 'Confirm')]")).Click();
//        }

//        public static void InsertEmailContact(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement element = driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]"));
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-list-item__primary-text') and contains(text(), 'Secondary e-mail')]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Contact')]")).Click();

//            IWebElement inputField = driver.FindElement(By.XPath("//*[contains(@placeholder, 'Enter the contact related to the type')]"));
//            inputField.Clear();
//            inputField.SendKeys("emailteste@gmail.com");

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//button[@aria-label='Click save contacts information']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "User contact successfully created";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void DeleteContact(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement element = driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]"));
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//button[contains(., 'Remove') and .//mat-icon[contains(text(), 'delete_outline')]]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            string notificationMessage = "User contact successfully deleted";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void InsertPhoneContact(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement element = driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]"));
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-list-item__primary-text') and contains(text(), 'Phone')]")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            IWebElement flag = driver.FindElement(By.XPath("//div[@class='flex align-center ng-star-inserted']//span[@class='flag']"));
//            Actions actions = new(driver);
//            actions.MoveToElement(flag).MoveByOffset(1, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(2, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(3, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(4, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(5, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(6, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(7, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(10, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(11, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(12, 0).Click().Perform();
//            actions.MoveToElement(flag).MoveByOffset(13, 0).Click().Perform();

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//input[@placeholder='Search' and contains(@class, 'search-box')]")).SendKeys("Brazil");
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            IWebElement brazilFlag = driver.FindElement(By.XPath("//div[@class='modal-country-wrap flex' and span[contains(@class, 'flag')] and span[contains(@class, 'modal-country ml-5') and text()='+55'] and span[contains(@class, 'modal-country ml-5') and text()='Brazil']]"));
//            brazilFlag.Click();

//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            IWebElement moveElement = driver.FindElement(By.XPath("//span[@_ngcontent-ng-c589990934 and contains(@class, 'text ml-5 ng-star-inserted')]"));
//            actions.MoveToElement(moveElement).MoveByOffset(200, 0).Click().Perform();
//            actions.SendKeys("7199123262").Perform();

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//button[@aria-label='Click save contacts information']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "User contact successfully created";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void AddCertification(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/certifications-skills");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/certifications-skills");
//            }

//            var name = driver.FindElement(By.Id("Name"));
//            name.Clear();
//            name.SendKeys("Davi");
//            var organization = driver.FindElement(By.XPath("//input[@id='IssuedBy']"));
//            organization.Clear();
//            organization.SendKeys("Microsoft");
//            var issueDate = driver.FindElement(By.XPath("//*[@id=\'Issued\']"));
//            issueDate.Clear();
//            issueDate.SendKeys("12/07/2001");
//            var expirationDate = driver.FindElement(By.XPath("//*[@id=\'ExpiresAt\']"));
//            expirationDate.Clear();
//            expirationDate.SendKeys("01/10/2050");
//            var credentialID = driver.FindElement(By.XPath("//input[@id='CredentialId' and contains(@class, 'mat-mdc-input-element')]\r\n"));
//            credentialID.Clear();
//            credentialID.SendKeys("842107");
//            var credentialUrl = driver.FindElement(By.XPath("//*[@id=\'CredentialUrl\']"));
//            credentialUrl.Clear();
//            credentialUrl.SendKeys("https://www.nbrc.org/wp-content/uploads/2020/02/credentials2.jpg");
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            driver.FindElement(By.XPath("//button[@id='buttonForm']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            string notificationMessage = "Certification added successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemoveCertification(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//button[@class='btn btn-sm m-0 p-0' and i[@class='c2g-icon-trash']]")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            string notificationMessage = "Certification removed successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void AddSkills(IWebDriver driver)
//        {
//            IWebElement clickInput = driver.FindElement(By.XPath("//div[@class='mat-mdc-form-field-infix ng-tns-c2608167813-6']/input"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", clickInput);

//            IWebElement optionInput1 = driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and normalize-space(text())='Scripting Languages']"));
//            js.ExecuteScript("arguments[0].click();", optionInput1);
//            driver.FindElement(By.XPath("//div[@class='col-2 col-md-2']//span[@class='mdc-button__label']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            js.ExecuteScript("arguments[0].click();", clickInput);
//            IWebElement loadMore = driver.FindElement(By.XPath("//div[@_ngcontent-ng-c1394327708 and contains(@class, 'mat-mdc-option')]"));
//            js.ExecuteScript("arguments[0].click();", loadMore);

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            js.ExecuteScript("arguments[0].click();", clickInput);
//            IWebElement optionInput2 = driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and normalize-space(text())='Cloud Computing Platforms']"));
//            js.ExecuteScript("arguments[0].click();", optionInput2);
//            driver.FindElement(By.XPath("//div[@class='col-2 col-md-2']//span[@class='mdc-button__label']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            string notificationMessage = "Skill added successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemoveSkills(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            IWebElement clickRemove = driver.FindElement(By.XPath("//span[@class='btn fw-bold p-0 m-0 ms-2' and text()='X']"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", clickRemove);

//            Thread.Sleep(TimeSpan.FromSeconds(5));
//            string notificationMessage = "Skilll deleted successfully.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void ChangeTimezone(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/availability");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/availability");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            driver.FindElement(By.XPath("//span[contains(@class, 'mat-mdc-select-min-line') and contains(text(), '(UTC-04:00) Central Brazilian Standard Time')]")).Click();
//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-list-item__primary-text') and contains(text(), '(UTC-04:00) Central Brazilian Standard Time')]")).Click();
//        }


//        public static void AddPreferredMeetingHours(IWebDriver driver)
//        {
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//mat-select[@id=\'AvailableDays\']")).Click();
//            driver.FindElement(By.XPath("//mat-pseudo-checkbox")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            js.ExecuteScript("document.elementFromPoint(250, 700).click();");

//            IWebElement clickStartTime = driver.FindElement(By.Id("StartTime"));
//            js.ExecuteScript("arguments[0].click();", clickStartTime);
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//span[contains(@class, 'mdc-list-item__primary-text') and text()='12:15 AM']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            js.ExecuteScript("document.elementFromPoint(250, 700).click();");

//            IWebElement clickEndTime = driver.FindElement(By.Id("EndingTime"));
//            js.ExecuteScript("arguments[0].click();", clickEndTime);
//            driver.FindElement(By.XPath("//mat-option[@class='mat-mdc-option mdc-list-item ng-tns-c2643520907-7 ng-star-inserted']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            js.ExecuteScript("document.elementFromPoint(250, 700).click();");

//            IWebElement clickButton = driver.FindElement(By.Id("buttonForm"));
//            js.ExecuteScript("arguments[0].click();", clickButton);

//            IWebElement clickCheckBox = driver.FindElement(By.Id("IsSupportEnable-input"));
//            js.ExecuteScript("arguments[0].click();", clickCheckBox);

//            IWebElement clickSaveChanges = driver.FindElement(By.XPath("//button[@id='buttonForm' and span[@class='mdc-button__label' and text()='Save changes']]"));
//            js.ExecuteScript("arguments[0].click();", clickSaveChanges);

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            string notificationMessage = "Availability updated successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void RemovePreferredMeetingHours(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            driver.FindElement(By.XPath("//button[contains(@class, 'btn') and contains(@class, 'p-0') and contains(@class, 'd-flex') and contains(@class, 'align-items-center') and contains(@class, 'gap-2') and contains(text(), 'Remove')]")).Click();

//            IWebElement clickSaveChanges = driver.FindElement(By.XPath("//button[@id='buttonForm' and span[@class='mdc-button__label' and text()='Save changes']]"));
//            js.ExecuteScript("arguments[0].click();", clickSaveChanges);

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            string notificationMessage = "Availability updated successfully";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void AddSolutionBasicInformation(IWebDriver driver, string environment)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/solution/upload/create");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/solution/upload/create");
//            }

//            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Test");
//            driver.FindElement(By.XPath("//input[@id='description']")).SendKeys("Test");
//            driver.FindElement(By.XPath("//input[@id='providerIds']")).Click();
//            driver.FindElement(By.XPath("//span[@class='mdc-list-item__primary-text' and normalize-space()='Amazon Web Services (AWS)']")).Click();
//            driver.FindElement(By.XPath("//input[@id='tags']")).Click();
//            driver.FindElement(By.XPath("//mat-option[span[@class='mdc-list-item__primary-text' and normalize-space()='AWS']]")).Click();
//            driver.FindElement(By.XPath("//input[@id='estimatedCosts']")).SendKeys("USD 100");
//            driver.FindElement(By.XPath("//input[@id='version']")).SendKeys("1.0");
//            driver.FindElement(By.XPath("//input[@id='estimatedHours']")).SendKeys("40");

//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            driver.FindElement(By.XPath("//button[@aria-label='Next']")).Click();
//        }

//        public static void AddArtifactsUpload(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            //TO-DO Encontrar uma maneira de salvar um arquivo JSON para dar Upload

//            Thread.Sleep(TimeSpan.FromSeconds(2));


//            driver.FindElement(By.XPath("//button[@aria-label='Next']")).Click();
//        }

//        public static void AddSolutionDocumentation(IWebDriver driver)
//        {
//            string imgPath = $"D:\\InnovtImageTest{_randomNumber}.png";
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("//div[@class='ace_content']")).SendKeys("Test description");
//            IWebElement inputFile = driver.FindElement(By.XPath("//button[@class='btn btn-outline-primary']//i[@class='c2g-icon-plus']"));
//            inputFile.SendKeys(imgPath);

//            Thread.Sleep(TimeSpan.FromSeconds(2));


//            driver.FindElement(By.XPath("//button[@aria-label='Next']")).Click();
//        }

//        public static void PublishingSolution(IWebDriver driver)
//        {
//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("//input[@id='Price']")).SendKeys("20");
//            driver.FindElement(By.XPath("//input[@type='checkbox' and @id='mat-mdc-checkbox-10-input']")).Click();
//            driver.FindElement(By.XPath("//input[@type='checkbox' and @id='mat-mdc-checkbox-11-input']")).Click();


//            Thread.Sleep(TimeSpan.FromSeconds(2));


//            driver.FindElement(By.XPath("//button[@aria-label='Publish']")).Click();
//        }


//    }
//}
