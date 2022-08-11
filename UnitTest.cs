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
        string RootDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

        [TestMethod, TestCategory("First"), Priority(1)]
        public void TestMethod1() 
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"; 
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", RootDirectory + "\\chromedriver.exe");
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            driver = new ChromeDriver(options);
        }


        [TestMethod, TestCategory("Second"), Priority(2)]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Second Test Method");
        }

        [TestMethod, TestCategory("Third"), Priority(3)]
        public void TestMethod3()
        {
            driver.SwitchTo().ActiveElement().SendKeys("Google");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            driver.Manage().Window.Maximize();
            Console.WriteLine("Third Test Method");
            driver.Close();
        }
    }
}
