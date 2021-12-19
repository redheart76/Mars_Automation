using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AddNewLanguage.Test
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        IWebDriver driver = new ChromeDriver();
        [Given(@"I have logged in to my account and navigate to my profile page")]
        public void GivenIHaveLoggedInToMyAccountAndNavigateToMyProfilePage()
        {
            driver.Url = "http://localhost:5000/";
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));//Sign in page
            SignIn.Click();
            IWebElement UserName = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));//Type in my username
            UserName.SendKeys("redheart76@live.com");

            IWebElement PassWord = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));//Type in my password
            PassWord.SendKeys("123123");

            IWebElement LogInBTN = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));//Login to my account
            LogInBTN.Click();
            Thread.Sleep(2000);
        }

        [Given(@"I select languages section")]
        public void GivenISelectLanguagesSection()
        {
            WebElement LanguageSection = (WebElement)driver.FindElement(By.XPath("//form[@class='ui form']/div/a[@class='item active']"));
            LanguageSection.Click();
            Thread.Sleep(2000);
        }

        [Given(@"I click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            IWebElement AddNewBTN = driver.FindElement(By.XPath("//table[@class='ui fixed table']//tr/th[3]/div")); //Click Add New button to add new language
            AddNewBTN.Click();
        }

        [Given(@"I type in my one of the languages that I can speak")]
        public void GivenITypeInMyOneOfTheLanguagesThatICanSpeak()
        {
            IWebElement MyLanguages = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            MyLanguages.Clear();
            MyLanguages.SendKeys("Chinese");//Add one of my languages
        }

        [Given(@"I choose the level of this language from the drop down menu")]
        public void GivenIChooseTheLevelOfThisLanguageFromTheDropDownMenu()
        {
            IWebElement LanguageLevel = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            LanguageLevel.Click();//Click the drop down menu
            IWebElement LevelSelection = driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[5]"));
            LevelSelection.Click();//Select my lanaguage level
        }

        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            IWebElement SaveBTN = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            SaveBTN.Click();//Click save button to save my selection
        }

        [Then(@"the new language will be saved")]
        public void ThenTheNewLanguageWillBeSaved()
        {
            IWebElement LanguageText = driver.FindElement(By.XPath("//td[text()='Chinese']"));
            Assert.IsTrue(LanguageText.Displayed);
            driver.Quit();
        }
    }
}
