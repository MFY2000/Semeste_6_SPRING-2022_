using System;
using TechTalk.SpecFlow;
using PasswordValidator.PasswordValidator;
using NUnit.Framework;

namespace PasswordValidator.StepDefinitions
{
    [Binding]
    public class PasswordValidate_4StepDefinitions
    {
        PassowrdValidatorClass passowrdValidator = new PassowrdValidatorClass();
        int respone = 0;

        [Given(@"Enter the Password_four \(password = ""([^""]*)""\)")]
        public void GivenEnterThePassword_FourPassword(string p0)
        {
            passowrdValidator.password = p0;
        }

        [When(@"Validate the Password_four\.")]
        public void WhenValidateThePassword_Four_()
        {
            respone = passowrdValidator.Validator();
        }

        [Then(@"verified Password_four is valid\.")]
        public void ThenVerifiedPassword_FourIsValid_()
        {
            Assert.AreEqual(respone,-1);
        }
    }
}
