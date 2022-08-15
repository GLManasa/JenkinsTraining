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
        }

        [TestMethod, TestCategory("First"), Priority(1)]
        public void TestMethod1() 
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.SwitchTo().ActiveElement().SendKeys("Google");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Search keyword - Google");
        }


        [TestMethod, TestCategory("Second")]
        public void TestMethod2()
        {
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("Gmail");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Search keyword - Gmail");
        }

        [TestMethod, TestCategory("Third")]
        public void TestMethod3()
        {
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("Google Drive");
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Search keyword - Google Drive");
            driver.Quit();
        }
    }
}
