using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CommonSteps : Hooks
    {

        //to enter a input into a particular input field
        public void EnterInputIntoField(string input, string field)
        {
            driver.FindElement(By.Id(Utils.Selectors.ElementLocator(field))).SendKeys(input);
        }

        // to check a particular text on the page
        public void CheckForTextOnPage(string text)
        {
            IWebElement body = driver.FindElement(By.TagName("body"));
            Assert.IsTrue(body.Text.Contains(text));
        }

        //to perform click action on buttton
        public void ClickOnButton(string button)
        {
            Thread.Sleep(1000);
            By loadingImage = By.XPath(Utils.Selectors.ElementLocator(button));
            new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(ExpectedConditions.ElementToBeClickable(loadingImage)).Click();
            Thread.Sleep(1000);
            driver.Navigate().Refresh();
            Thread.Sleep(1000);
        }

        //To select a item from dropdown list
        public void SelectSingleDropDownList(string text, string dropDown)
        {

            //need to pass element id for "Element_ID"
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id(Utils.Selectors.ElementLocator(dropDown))));

            Thread.Sleep(1000);
            //need to pass for "Text" anything from - index/value/text/options
            oSelect.SelectByText(text);

        }

    }
}
