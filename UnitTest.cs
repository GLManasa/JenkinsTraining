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
        public IWebDriver driver;
        static string RootDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

        public void setupBrowser() {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", RootDirectory + "\\chromedriver.exe");
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            driver = new ChromeDriver(options);
        }

        [TestMethod, TestCategory("First")]
        public void TestMethod1() 
        {
            setupBrowser();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.SwitchTo().ActiveElement().SendKeys("Google");
            driver.Manage().Window.Maximize();
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            Console.WriteLine("Search keyword - Google");
            driver.Quit();
        }


        [TestMethod, TestCategory("Second")]
        public void TestMethod2()
        {
            setupBrowser()
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.SwitchTo().ActiveElement().SendKeys("Gmail");
            driver.Manage().Window.Maximize();
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            Console.WriteLine("Search keyword - Gmail");
            driver.Quit();
        }

        [TestMethod, TestCategory("Third")]
        public void TestMethod3()
        {
            setupBrowser();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.SwitchTo().ActiveElement().SendKeys("Google Drive");
            driver.Manage().Window.Maximize();
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            Console.WriteLine("Search keyword - Google Drive");
            driver.Quit();
        }
    }
}
