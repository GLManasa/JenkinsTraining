using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace JenkinsTraining
{
    [TestClass]
    public class UnitTest
    {
        public static IWebDriver driver;
        static string RootDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

        [ClassInitialize]
        public static void setupBrowser(TestContext tc) {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", RootDirectory + "\\chromedriver.exe");
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.redbus.in/");
        }

        [TestMethod, TestCategory("First")]
        public void TestMethod1() 
        {
            driver.FindElement(By.XPath("//li[@data-creative='offer-banner'][1]")).Click()
        }


        [TestMethod, TestCategory("Second")]
        public void TestMethod2()
        {
            driver.FindElement(By.XPath("//li[@data-creative='offer-banner'][2]")).Click();
        }

        [TestMethod, TestCategory("Third")]
        public void TestMethod3()
        {
            driver.FindElement(By.XPath("//li[@data-creative='offer-banner'][3]")).Click();
            driver.Quit();
        }
    }
}
