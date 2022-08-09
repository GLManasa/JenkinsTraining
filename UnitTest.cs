using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JenkinsTraining
{
    [TestClass]
    public class UnitTest
    {
        public IWebDriver driver;

        [TestMethod, TestCategory("First"), Priority(1)]
        public void TestMethod1() 
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            driver = new ChromeDriver(options);
        }


        [TestMethod, TestCategory("Second"), Priority(2)]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Second Test Method");
        }

        [TestMethod, TestCategory("Third")]
        public void TestMethod3()
        {
            driver.SwitchTo().ActiveElement().SendKeys("Google");
            Console.WriteLine("Third Test Method");
        }
    }
}
