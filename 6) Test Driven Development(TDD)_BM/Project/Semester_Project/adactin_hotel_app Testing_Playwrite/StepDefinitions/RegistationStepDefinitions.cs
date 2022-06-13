using System;
using TechTalk.SpecFlow;
using Microsoft.Playwright;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;


namespace adactin_hotel_app_Testing_Playwrite.StepDefinitions
{
    [Binding]
    public class RegistationStepDefinitions
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


        [Given(@"Open the Website of the given Url=""([^""]*)""\.")]
        public async Task GivenOpenTheWebsiteOfTheGivenUrl_(string p0)
        {
            await page.GotoAsync(p0);
        }

        [Given(@"Press the button of \[New User Register Here]\.")]
        public async Task GivenPressTheButtonOfNewUserRegisterHere_()
        {
            await page.ClickAsync("#login_form > table > tbody > tr:nth-child(7) > td > a");
        }

        [When(@"Fill the form")]
        public async Task WhenFillTheForm(Table table)
        {
            form = table.CreateInstance<registaterForm>();
            await page.FillAsync("#username", form.Username);
            await page.FillAsync("#password", form.Password);
            await page.FillAsync("#re_password", form.CPassword);
            await page.FillAsync("#full_name", form.FName);
            await page.FillAsync("#email_add", form.Email);
            if (form.Terms) { 
                await page.ClickAsync("#tnc_box");
            }

        }

        [Then(@"wait for sec=(.*), time=(.*) for Captcha text")]
        public async Task ThenWaitForSecTimeForCaptchaText(int p0, int p1)
        {
            for (int i = 0; i < p1; i++) {
                string value = await page.InputValueAsync("captcha-form");
                if (value.Length >= 6) {
                    //MessageBox.Show("");
                    break;
                }
                else{
                    Thread.Sleep(p0);
                }
            
            }
        }

        [Then(@"Press the button of \[Register]\.")]
        public async Task ThenPressTheButtonOfRegister_()
        {
            await page.ClickAsync("#Submit");
        }

        [Then(@"verify the outcome of the process\.")]
        public async Task ThenVerifyTheOutcomeOfTheProcess_()
        {
            var result = await page.InnerTextAsync("");
            Assert.AreEqual(result, "");
        }
    }


    class registaterForm {

        public string Username { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }
        public string FName { get; set; }
        public string Email { get; set; }
        public bool Terms { get; set; }
        
    }
}
