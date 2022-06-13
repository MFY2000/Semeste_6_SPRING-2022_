using System;
using TechTalk.SpecFlow;
using Microsoft.Playwright;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace adactin_hotel_app_Testing_Playwrite.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        IPage page;
        IPlaywright playwright;
        registaterForm form;

        [BeforeScenario]
        public async Task TestInitialize()
        {
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            page = await browser.NewPageAsync();
        }

        [Given(@"Open the Website of the given url=""([^""]*)""\.")]
        public async Task GivenOpenTheWebsiteOfTheGivenUrl_(string p0)
        {
            await page.GotoAsync(p0);
        }

        [Given(@"fill the userName=""([^""]*)"" and password=""([^""]*)""\.")]
        public async Task GivenFillTheUserNameAndPassword_(string p0, string p1)
        {
            await page.FillAsync("#username", p0);
            await page.FillAsync("#password", p1);

        }

        [When(@"Press the button Login\.")]
        public async Task WhenPressTheButtonLogin_()
        {
            await page.ClickAsync("#login"); 
        }

        [Then(@"Verify the outcome of the process\.")]
        public async void ThenVerifyTheOutcomeOfTheProcess_()
        {
            var result = await page.InputValueAsync("#username_show");
            Assert.AreEqual(result, "Hello Fahad123!");
        }
    }
}
