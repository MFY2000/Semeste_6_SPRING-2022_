using System;
using TechTalk.SpecFlow;
using PasswordValidator.PasswordValidator;
using NUnit.Framework;

namespace PasswordValidator.StepDefinitions
{
    [Binding]
    public class PasswordValidate_3StepDefinitions
    {
        PassowrdValidatorClass passowrdValidator = new PassowrdValidatorClass();
        int respone = 0;

        [Given(@"Enter the Password_three \(password = ""([^""]*)""\)")]
        public void GivenEnterThePassword_ThreePassword(string p0)
        {
            passowrdValidator.password = p0;
        }

        [When(@"Validate the Password_three\.")]
        public void WhenValidateThePassword_Three_()
        {
            respone = passowrdValidator.Validator();
        }

        [Then(@"verified Password_three is valid\.")]
        public void ThenVerifiedPassword_ThreeIsValid_()
        {
            Assert.AreEqual(respone, -1);
        }
    }
}
