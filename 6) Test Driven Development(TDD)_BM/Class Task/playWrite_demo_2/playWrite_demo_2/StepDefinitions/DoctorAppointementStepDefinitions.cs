using Microsoft.Playwright;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace playWrite_demo_2.StepDefinitions
{
    [Binding]
    public class DoctorAppointementStepDefinitions
    {

        IPage page;
        IPlaywright playwright;

        [BeforeScenario]
        public async Task TestInitialize()
        {
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            page = await browser.NewPageAsync();
        }

        [Given(@"Go to the URL \(""([^""]*)""\)")]
        public async Task GivenGoToTheURLAsync(string p0)
        {
            await page.GotoAsync(p0);
        }

        [Then(@"click on the button Make an Appointement")]
        public async Task ThenClickOnTheButtonMakeAnAppointement()
        {
            await page.ClickAsync("#btn-make-appointment");
        }

        [Then(@"Enter the Username = ""([^""]*)"" and Passwords = ""([^""]*)""")]
        public async Task ThenEnterTheUsernameAndPasswords(string p0, string thisIsNotAPassword)
        {
            await page.FillAsync("#txt-username",p0);
            await page.FillAsync("#txt-password", thisIsNotAPassword);
        }

        [Then(@"Click on login")]
        public async Task ThenClickOnLogin()
        {
            await page.ClickAsync("#btn-login");
        }

        [When(@"Verify the login")]
        public async Task WhenVerifyTheLogin()
        {
            var result = await page.InnerTextAsync("#appointment > div > div > div > h2");

            Assert.AreEqual(result, "Make Appointment");
        }

        [Then(@"Select Facility")]
        public async Task ThenSelectFacility()
        {

            await page.SelectOptionAsync("#combo_facility", "Hongkong CURA Healthcare Center");
            
        }

        [Then(@"mark the checkbox")]
        public async Task ThenMarkTheCheckbox()
        {
            await page.ClickAsync("#chk_hospotal_readmission");
        }

        [Then(@"select any of the radio button on Healthcare Program")]
        public async Task ThenSelectAnyOfTheRadioButtonOnHealthcareProgram()
        {
            await page.ClickAsync("#radio_program_medicaid");
        }

        [Then(@"Enter date Visit Date \(Required\)")]
        public async Task ThenEnterDateVisitDateRequired()
        {
            await page.ClickAsync("#txt_visit_date");
            await page.ClickAsync("body > div > div.datepicker-days > table > tbody > tr:nth-child(5) > td:nth-child(2)");
        }

        [Then(@"Enter any Comment")]
        public async Task ThenEnterAnyComment()
        {
            await page.FillAsync("#txt_comment", ".....");
        }

        [Then(@"Click Make an Appointement")]
        public async Task ThenClickMakeAnAppointement()
        {
            await page.ClickAsync("#btn-book-appointment");
        }

        [Then(@"verify that the Appointement is booked")]
        public async Task ThenVerifyThatTheAppointementIsBooked()
        {

            var result = await page.InnerTextAsync("#summary > div > div > div.col-xs-12.text-center > h2");
            Assert.AreEqual(result, "Appointment Confirmation");
            await page.CloseAsync();
        }
    }
}
