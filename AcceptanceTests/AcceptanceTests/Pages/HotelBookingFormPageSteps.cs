using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Pages
{
    [Binding]
    public class HotelBookingFormPageSteps : StepDefinitions.CommonSteps
    {
        //To navigate to a page
        [Given(@"I have navigate to ""(.*)"" page")]
        public void GivenIHaveNavigateToPage(string page)
        {
            SetUp();
            driver.Navigate().GoToUrl(Utils.Selectors.LinksUrlSearch(page));
        }

        //To enter a input in the input field
        [When(@"I enter ""(.*)"" in ""(.*)"" input field")]
        public void WhenIEnterInInputField(string name, string field)
        {
            EnterInputIntoField(name, field);
            Thread.Sleep(2000);
        }

        //To select a value from the dropdown  
        [When(@"I select ""(.*)"" from ""(.*)"" dropdown list")]
        public void WhenISelectFromDropdownList(string text, string dropDown)
        {
            SelectSingleDropDownList(text,dropDown);
        }

        //To perfrom click action on button
        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string button)
        {
            ClickOnButton(button);
        }

        //To check text exist on the page
        [Then(@"I should see ""(.*)"" text on the page")]
        public void ThenIShouldSeeTextOnThePage(string text)
        {
            CheckForTextOnPage(text);
            Thread.Sleep(5000);
        }

    }
}
