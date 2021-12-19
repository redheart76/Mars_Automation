using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AddNewDescription.Test
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

        [Given(@"I click description edit button")]
        public void GivenIClickDescriptionEditButton()
        {
            IWebElement DescriptionEdit = driver.FindElement(By.XPath("//span[@class='button']/i"));
            DescriptionEdit.Click();
        }

        [Given(@"I type in something I like to tell the people")]
        public void GivenITypeInSomethingILikeToTellThePeople()
        {
            IWebElement DescriptionFeild = driver.FindElement(By.XPath("//textarea[@name='value']"));
            DescriptionFeild.Clear();
            DescriptionFeild.SendKeys("Hi, I have a bunch of skills that can be swapped with you.");
        }

        [When(@"I press Save")]
        public void WhenIPressSave()
        {
            IWebElement SaveBTN = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveBTN.Click();
        }

        [Then(@"the new description will be saved")]
        public void ThenTheNewDescriptionWillBeSaved()
        {
            IWebElement DescriptionText = driver.FindElement(By.XPath("//*[text()='Hi, I have a bunch of skills that can be swapped with you.']"));
            Assert.IsTrue(DescriptionText.Displayed);
            driver.Close();
        
        }
    }
}
