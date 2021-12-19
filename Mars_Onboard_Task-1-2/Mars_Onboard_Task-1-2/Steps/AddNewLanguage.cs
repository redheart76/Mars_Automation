using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_Onboard_Task_1_2.Steps
{
    [Binding]
    public class AddNewLanguage
    {
        private readonly ScenarioContext _scenarioContext;

        public AddNewLanguage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = new ChromeDriver();
        [Given(@"I have logged in to my account and navigate to my profile page")]
        public void GivenIHaveLoggedInToMyAccountAndNavigateToMyProfilePage()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I select languages section")]
        public void GivenISelectLanguagesSection()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I type in my one of the languages that I can speak")]
        public void GivenITypeInMyOneOfTheLanguagesThatICanSpeak()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I choose the level of this language from the drop down menu")]
        public void GivenIChooseTheLevelOfThisLanguageFromTheDropDownMenu()
        {
            _scenarioContext.Pending();
        }

        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            _scenarioContext.Pending();
        }

        [Then(@"the new language will be saved")]
        public void ThenTheNewLanguageWillBeSaved()
        {
            _scenarioContext.Pending();
        }
    }
}
