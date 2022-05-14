using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Login.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        public ChromeDriver driver = new ChromeDriver();
        By username = By.Id("");

        [Given(@"Enter the URl of the website \(website = '([^']*)'\)")]
        public void GivenEnterTheURlOfTheWebsiteWebsite(string p0)
        {
            driver.Url = p0;
        }

        [Given(@"Enter User ID in Application")]
        public void GivenEnterUserIDInApplication(string id)
        {
            var c = driver.FindElements(By.Id(id));
            c.SendKeys("sfsd");
        }

        [Given(@"Enter Password")]
        public void GivenEnterPassword(string password)
        {
            driver.FindElements(By.Id(password));
        }

        [When(@"Click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"User logged in Successfully")]
        public void ThenUserLoggedInSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
