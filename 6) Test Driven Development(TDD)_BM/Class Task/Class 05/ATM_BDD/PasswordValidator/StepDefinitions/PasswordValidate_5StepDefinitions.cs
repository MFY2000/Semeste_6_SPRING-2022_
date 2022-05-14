using System;
using TechTalk.SpecFlow;
using PasswordValidator.PasswordValidator;
using NUnit.Framework;

namespace PasswordValidator.StepDefinitions
{
    [Binding]
    public class PasswordValidate_5StepDefinitions
    {
        PassowrdValidatorClass passowrdValidator = new PassowrdValidatorClass();
        int respone = 0;

        [Given(@"Enter the Password_five \(password = ""([^""]*)""\)")]
        public void GivenEnterThePassword_FivePassword(string p0)
        {
            passowrdValidator.password = p0;
        }

        [When(@"Validate the Password_five")]
        public void WhenValidateThePassword_Five()
        {
            respone = passowrdValidator.Validator();

        }

        [Then(@"verified Password_five is valid")]
        public void ThenVerifiedPassword_FiveIsValid()
        {
            Assert.AreEqual(respone,-1);
        }
    }
}
