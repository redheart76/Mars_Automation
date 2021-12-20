using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AddNewEducation.Test
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

        [Given(@"I select Education section")]
        public void GivenISelectEducationSection()
        {
            IWebElement EducationBTN = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            EducationBTN.Click();//Click the Education edit button
        }

        [Given(@"I click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            IWebElement AddNewEdu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddNewEdu.Click();//Click the button a add new education
        }

        [Given(@"I type in the my University name in College/University Name field")]
        public void GivenITypeInTheMyUniversityNameInCollegeUniversityNameField()
        {
            IWebElement UniName = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            UniName.Clear();
            UniName.SendKeys("Auckland University");//Type in the name of the school

        }

        [Given(@"I choose the Conuntry of College/University from the drop down menu")]
        public void GivenIChooseTheConuntryOfCollegeUniversityFromTheDropDownMenu()
        {
            IWebElement CountryMenu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            CountryMenu.Click();
            IWebElement CountrySelection = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            CountrySelection.Click();//Select the conuntry of the school
        }

        [Given(@"I choose my Title from the drop down menu")]
        public void GivenIChooseMyTitleFromTheDropDownMenu()
        {
            IWebElement TitleMenu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            TitleMenu.Click();
            IWebElement TitleSelection = driver.FindElement(By.XPath("//select[@name='title']/option[@value='B.A']"));
            
            TitleSelection.Click();//Select the Title I have
        }

        [Given(@"I type in what kind of degree I have got in the Degree field")]
        public void GivenITypeInWhatKindOfDegreeIHaveGotInTheDegreeField()
        {
            IWebElement DegreeType = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            DegreeType.Clear();
            DegreeType.SendKeys("Bachelor");//Select the degree I have
        }

        [Given(@"I choose the year of graduation from drop down menu")]
        public void GivenIChooseTheYearOfGraduationFromDropDownMenu()
        {
            IWebElement YearOfEdu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearOfEdu.Click();
            IWebElement YearSelection = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[10]"));
            YearSelection.Click();//Select the year I graduated
        }

        [When(@"I press Add")]
        public void WhenIPressAdd()
        {
            IWebElement EducationAddBTN = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            EducationAddBTN.Click();//Click the Add button to save the new education
        }

        [Then(@"the new education will be saved")]
        public void ThenTheNewEducationWillBeSaved()
        {
            IWebElement UniNameTxt = driver.FindElement(By.XPath("//td[text()='Auckland University']"));
            Assert.IsTrue(UniNameTxt.Displayed);
            driver.Quit();//Assert the new education has been saved
        }
    }
}
