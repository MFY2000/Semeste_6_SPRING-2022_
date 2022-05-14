using System;
using TechTalk.SpecFlow;
using PasswordValidator.PasswordValidator;
using NUnit.Framework;

namespace PasswordValidator.StepDefinitions
{
    [Binding]
    public class PasswordValidate_2StepDefinitions
    {
        PassowrdValidatorClass passowrdValidator = new PassowrdValidatorClass();
        int respone = 0;

        [Given(@"Enter the Password_two \(password = ""([^""]*)""\)")]
        public void GivenEnterThePassword_TwoPassword(string abcaxsxklcned)
        {
            passowrdValidator.password = abcaxsxklcned;
        }

        [When(@"Validate the Password_two\.")]
        public void WhenValidateThePassword_Two_()
        {
            respone = passowrdValidator.Validator();
        }

        [Then(@"verified Password_two is valid\.")]
        public void ThenVerifiedPassword_TwoIsValid_()
        {
            Assert.AreEqual(respone, -1);
        }
    }
}
