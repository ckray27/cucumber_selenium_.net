using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        //driver instance
        public static IWebDriver driver = null;
        public static string browserType;
        public static string userType;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void Initialize()
        {
            //pass browser name on which want to run the tests
            browserType = "Chrome";
        }

        //closes the driver after every scenario
        [AfterTestRun]
        public static void CleanUp()
        {
            driver.Close();
        }

        [TearDown]
        public void TeadDown()
        {
            driver.Quit();
        }

        //picks the browser type which we have passed above from the list
        [SetUp]
        internal void SetUp()
        {
            switch (browserType)
            {
                case "Chrome":
                    string chromeDriverDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var options = new ChromeOptions();
                    options.AddArgument("-no-sandbox");
                    driver = new ChromeDriver(chromeDriverDirectory, options, TimeSpan.FromMinutes(3));
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();

                    break;
                case "Firefox":
                    string firefoxDriverDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("-no-sandbox");
                    driver = new FirefoxDriver(firefoxDriverDirectory, firefoxOptions, TimeSpan.FromMinutes(3));
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
                    break;
            }
            driver.Manage().Window.Maximize();
        }
    }
}
