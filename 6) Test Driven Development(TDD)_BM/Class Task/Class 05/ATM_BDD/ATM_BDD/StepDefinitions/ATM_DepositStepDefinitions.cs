using System;
using TechTalk.SpecFlow;
using Class05_TDD_ATM;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class ATM_DepositStepDefinitions
    {
        ATM atm_bank = new ATM();
        Param atm_step = new Param();
        string respone = "";

        [Given(@"Enter your pin \(pin = ""([^""]*)""\)\.")]
        public void GivenEnterYourPinPin_(string p0)
        {
            atm_step.pinCode = p0;
            atm_step.amout = 1200;
        }

        [Given(@"Enter the Choice\(for deposit = (.*)\)")]
        public void GivenEnterTheChoiceForDeposit(int p0)
        {
            atm_step.choice = p0;
        }

        [Given(@"Enter the withdrawal amount\(for deposit amount = (.*)\. \)")]
        public void GivenEnterTheWithdrawalAmountForDepositAmount_(int p0)
        {
            atm_step.actionAmount = p0;
        }

        [When(@"check the pin ,check the process/Choice and check if deposit amount is greater than zero\.")]
        public void WhenCheckThePinCheckTheProcessChoiceAndCheckIfDepositAmountIsGreaterThanZero_()
        {
            respone = atm_bank.BankTransaction(atm_step);
        }

        [Then(@"retunr the current balance")]
        public void ThenRetunrTheCurrentBalance()
        { 
            Assert.AreEqual(respone, "Your Balance Deposit Successfully: 12001000");
        }
    }
}
