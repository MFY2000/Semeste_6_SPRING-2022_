using System;
using TechTalk.SpecFlow;
using Class05_TDD_ATM;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class ATM_WithdrawStepDefinitions
    {
        ATM atm_bank = new ATM();
        Param atm_step = new Param();
        string respone = "";

        [Given(@"Enter your pin \(pin = ""([^""]*)""\)")]
        public void GivenEnterYourPinPin(string p0)
        {
            atm_step.pinCode = p0;
            atm_step.amout = 1200;
        }

        [Given(@"Enter the Choice\(for withdrawal = (.*)\)")]
        public void GivenEnterTheChoiceForWithdrawal(int p0)
        {
            atm_step.choice = p0;
        }

        [Given(@"Enter the withdrawal amount\(for withdraw amount = (.*)\. \)")]
        public void GivenEnterTheWithdrawalAmountForWithdrawAmount_(int p0)
        {
            atm_step.actionAmount = p0;

        }

        [When(@"check the pin ,check the process/Choice and check if withdrawal amount is greater than current balance\.")]
        public void WhenCheckThePinCheckTheProcessChoiceAndCheckIfWithdrawalAmountIsGreaterThanCurrentBalance_()
        {
            respone = atm_bank.BankTransaction(atm_step);
        }

        [Then(@"retunr the current balance\.")]
        public void ThenRetunrTheCurrentBalance_()
        {
            Assert.AreEqual(respone, "Withdraw Successfully of amount:200");
        }
    }
}
