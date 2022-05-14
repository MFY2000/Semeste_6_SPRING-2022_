using System;
using TechTalk.SpecFlow;

namespace PasswordValidator.StepDefinitions
{
    [Binding]
    public class PasswordValidate_1StepDefinitions
    {
        [Given(@"Enter the Password \(password = ""([^""]*)""\)")]
        public void GivenEnterThePasswordPassword(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Validate the Password")]
        public void WhenValidateThePassword()
        {
            throw new PendingStepException();
        }

        [Then(@"verified Password is valid")]
        public void ThenVerifiedPasswordIsValid()
        {
            throw new PendingStepException();
        }
    }
}
