//using C2GSeleniumTeste.LocalTests;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;

//namespace C2GSeleniumTeste.Tests
//{
//    public class IncorrectTests
//    {
//        private static int _randomNumber;

//        public static void SaveTestPicture(IWebDriver driver)
//        {
//            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

//            Random random = new();
//            _randomNumber = random.Next(1, 10000);

//            string fileName = $"D:\\InnovtImageTest{_randomNumber}.png";

//            screenshot.SaveAsFile(fileName);
//        }

//        static string RepeatLetters(string text, int repetitions)
//        {
//            string repeatedText = "";

//            for (int i = 0; i < repetitions; i++)
//            {
//                repeatedText += text;
//            }

//            return repeatedText;
//        }

//        public static void EditNameWithWhitespace(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            var nameField = driver.FindElement(By.XPath("//*[@id='name']"));
//            nameField.Clear();
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Save changes']")).Click();

//            string notificationMessage = "The username cannot contain whitespace.";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }
//        public static void EditInvalidCharactersName(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            string text = " /&@()";
//            string wrongRepeatedText = RepeatLetters(text, 100);

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys(wrongRepeatedText);
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Save changes']")).Click();


//            string notificationMessage = "User contact successfully created";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void EditLongName(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            string text = " davi";
//            string wrongRepeatedText = RepeatLetters(text, 100);

//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys(wrongRepeatedText);
//            driver.FindElement(By.XPath("//span[@class='mdc-button__label' and normalize-space()='Save changes']")).Click();

//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            var notification = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//invt-notification[@class='ng-star-inserted']//span")));


//            string notificationMessage = "The field Name must be a string with a maximum length of 100.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void EditWithWrongCharactersAddress(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            List<By> fields =
//            [
//                By.XPath("//*[@id='Street']"),
//                By.XPath("//*[@id='Number']"),//Se estiver correto o Adress é salvo.
//                By.XPath("//*[@id='Complement']"),
//                By.XPath("//*[@id='ZipCode']"),
//                By.XPath("//*[@id='City']"),
//                By.XPath("//*[@id='State']"),
//                By.XPath("//*[@id='Country']")
//            ];

//            foreach (By field in fields)
//            {
//                IWebElement element = driver.FindElement(field);
//                element.Clear();
//                element.SendKeys("$@!!@%!@$@$($&%*");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            IWebElement button = driver.FindElement(By.XPath("//div[@class='col-12 col-md-4 offset-md-8']//invt-button//span[@class='mdc-button__label' and normalize-space()='Save changes']"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", button);

//            string notificationMessage = "Error during Address Process";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void EditIncorrectAddress(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(1));

//            List<By> fields =
//            [
//                By.XPath("//*[@id='Street']"),
//                By.XPath("//*[@id='Number']"),//Se estiver correto o Adress é salvo.
//                By.XPath("//*[@id='Complement']"),
//                By.XPath("//*[@id='ZipCode']"),
//                By.XPath("//*[@id='City']"),
//                By.XPath("//*[@id='State']"),
//                By.XPath("//*[@id='Country']")
//            ];

//            foreach (By field in fields)
//            {
//                IWebElement element = driver.FindElement(field);
//                element.Clear();
//                element.SendKeys("dasadsgfeqwrq");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));

//            IWebElement button = driver.FindElement(By.XPath("//div[@class='col-12 col-md-4 offset-md-8']//invt-button//span[@class='mdc-button__label' and normalize-space()='Save changes']"));
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].click();", button);

//            string notificationMessage = "Error during Address Process";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void UploadWrongW8BenForm(IWebDriver driver)
//        {

//            string imgPath = $"D:\\InnovtImageTest{_randomNumber}.png";
//            IWebElement inputFile = driver.FindElement(By.XPath("//div[@class='col-12 col-md-auto']/input[@type='file']"));

//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("arguments[0].removeAttribute('hidden')", inputFile);

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            inputFile.SendKeys(imgPath);

//            Thread.Sleep(TimeSpan.FromSeconds(2));

//            string notificationMessage = "Expert only support pdf file.";

//            CloudExpertTestsSand.InnovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void UserInformationWithoutCharacters(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            var firstName = driver.FindElement(By.Id("firstName"));
//            firstName.Clear();
//            var lastName = driver.FindElement(By.Id("lastName"));
//            lastName.Clear();
//            driver.FindElement(By.XPath(" //*[@id=\'buttonForm\']")).Click();

//            string notificationMessage = "Error during Address Proccess";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void UserInformationWithInvalidCharacters(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            var firstName = driver.FindElement(By.Id("firstName"));
//            firstName.Clear();
//            firstName.SendKeys("!$@&)_@$()(@!$*_*!@$_)!@)_");
//            var lastName = driver.FindElement(By.Id("lastName"));
//            lastName.Clear();
//            lastName.SendKeys("!*($@_)@!$*)_!@$)_@!$(+@!(");
//            driver.FindElement(By.XPath(" //*[@id=\'buttonForm\']")).Click();

//            string notificationMessage = "Error during Address Proccess";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void UserInformationWithLongCharacters(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            var firstName = driver.FindElement(By.Id("firstName"));
//            firstName.Clear();

//            string text = " davi";
//            string wrongRepeatedText = RepeatLetters(text, 100);
//            firstName.SendKeys(wrongRepeatedText);
//            var lastName = driver.FindElement(By.Id("lastName"));
//            lastName.Clear();
//            lastName.SendKeys(wrongRepeatedText);

//            driver.FindElement(By.XPath(" //*[@id=\'buttonForm\']")).Click();

//            string notificationMessage = "Error during Address Proccess";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//        public static void InsertContactIncorrect(IWebDriver driver)
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
//            inputField.SendKeys("($@)_!)_!@$)!@$@!$@!");

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            driver.FindElement(By.XPath("//button[@aria-label='Click save contacts information']")).Click();

//            string notificationMessage = "Invalid Email";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);

//            driver.Navigate().Refresh();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            element = driver.FindElement(By.XPath("//mat-label[contains(@class, 'ng-star-inserted') and contains(text(), 'Type')]"));
//            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
//            Thread.Sleep(TimeSpan.FromSeconds(1));
//            driver.FindElement(By.XPath("//mat-icon[@class='mat-icon notranslate me-sm-0 material-icons mat-ligature-font mat-icon-no-color ng-star-inserted' and text()='delete_outline']")).Click();
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//        }

//        public static void AddIncorrectCertification(IWebDriver driver, string environment)
//        {
//            if (environment == "dev")
//            {
//                driver.Navigate().GoToUrl("https://expert-dev.cloud2gether.com/account/cloud-expert-profile");
//            }
//            else
//            {
//                driver.Navigate().GoToUrl("https://expert-sand.cloud2gether.com/account/cloud-expert-profile");
//            }

//            List<By> fields =
//          [
//              By.XPath("//*[@id='Name']"),
//              By.XPath("//*[@id='IssuedBy']"),
//              By.XPath("//*[@id=\'Issued\']"),
//              By.XPath("//*[@id=\'ExpiresAt\']"),
//              By.XPath("//input[@id='CredentialId' and contains(@class, 'mat-mdc-input-element')]"),
//          ];

//            foreach (By field in fields)
//            {
//                IWebElement element = driver.FindElement(field);
//                element.Clear();
//                element.SendKeys("$&@!()$&@!()$&@!()$&@!()$&");
//            }
            
//            var credentialUrl = driver.FindElement(By.XPath("//*[@id=\'CredentialUrl\']"));
//            credentialUrl.Clear();
//            credentialUrl.SendKeys("https://www.nbrc.org/wp-content/uploads/2020/02/credentials2.jpg");
//            driver.FindElement(By.XPath("//button[@id='buttonForm']")).Click();

//            Thread.Sleep(TimeSpan.FromSeconds(3));
//            string notificationMessage = "Certification not added successfully.";

//            //CloudExpertTestsC2G.innovtNotificationAssert(notificationMessage, driver);
//        }

//    }
//}
