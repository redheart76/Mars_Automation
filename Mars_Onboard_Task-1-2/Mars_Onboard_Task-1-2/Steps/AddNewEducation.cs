using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_Onboard_Task_1_2.Steps
{
    [Binding]
    public class AddNewEducation
    {
        private readonly ScenarioContext _scenarioContext;

        public AddNewEducation(ScenarioContext scenarioContext)
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

        [Given(@"I select Education section")]
        public void GivenISelectEducationSection()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I type in the my University name in College/University Name field")]
        public void GivenITypeInTheMyUniversityNameInCollegeUniversityNameField()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I choose the Conuntry of College/University from the drop down menu")]
        public void GivenIChooseTheConuntryOfCollegeUniversityFromTheDropDownMenu()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I choose my Title from the drop down menu")]
        public void GivenIChooseMyTitleFromTheDropDownMenu()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I type in what kind of degree I have got in the Degree field")]
        public void GivenITypeInWhatKindOfDegreeIHaveGotInTheDegreeField()
        {
            _scenarioContext.Pending();
        }

        [Given(@"I choose the year of graduation from drop down menu")]
        public void GivenIChooseTheYearOfGraduationFromDropDownMenu()
        {
            _scenarioContext.Pending();
        }

        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            _scenarioContext.Pending();
        }

        [Then(@"the new education will be saved")]
        public void ThenTheNewEducationWillBeSaved()
        {
            _scenarioContext.Pending();
        }
    }
}
