//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium;
//using NUnit.Framework;

//namespace C2GSeleniumTeste.Setup
//{
//    public class IncorrectRegistrationTest
//    {


//        public static void TryCreateAccountIncorrect(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//a[text()='Sign up']")).Click();
//            driver.FindElement(By.XPath("//*[@id='firstName']")).SendKeys("41214221$@!$@$!@");
//            driver.FindElement(By.XPath("//*[@id='lastName']")).SendKeys("$@!@$$!@@!$$@!");
//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys("@$!$@!@!$@!$@$!");
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("Senha100");
//            driver.FindElement(By.Id("confirmPassword")).SendKeys("Senha100");
//            driver.FindElement(By.Id("jobPosition")).Click();
//            driver.FindElement(By.CssSelector("span.mdc-list-item__primary-text")).Click();

//            Thread.Sleep(2000);
//            driver.FindElement(By.XPath("//button[@_ngcontent-ng-c779356000]")).Click();
//            Thread.Sleep(2000);
//        }

//        public static void TryCreateExistingAccount(IWebDriver driver)
//        {
//            driver.Navigate().Refresh();

//            driver.FindElement(By.XPath("//*[@id='firstName']")).SendKeys("Davi");
//            driver.FindElement(By.XPath("//*[@id='lastName']")).SendKeys("Luquini");
//            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys("davi262016@gmail.com");
//            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("testCloud2Gether");
//            driver.FindElement(By.Id("confirmPassword")).SendKeys("testCloud2Gether");
//            driver.FindElement(By.Id("jobPosition")).Click();
//            driver.FindElement(By.CssSelector("span.mdc-list-item__primary-text")).Click();

//            Thread.Sleep(2000);
//            driver.FindElement(By.XPath("//button[@_ngcontent-ng-c779356000]")).Click();
//            Thread.Sleep(3000);

//            IWebElement accountExists = driver.FindElement(By.XPath("//span[text()='A user with the given email already exists.']"));


//            Assert.That(accountExists.Text.Trim(), Is.EqualTo("A user with the given email already exists."));
//        }
//    }
//}
