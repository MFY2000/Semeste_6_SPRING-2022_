using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMClass;

namespace ATMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ATMTestForWithdrawal()
        {
            ATM atm = new ATM();
            Param parame = new Param();
            parame.amount = 50000;
            parame.choice = 2;
            parame.withdraw = 10000;
            parame.pin = 123;
            Assert.AreEqual(atm.BankTransaction(parame), "Your current amount now is 40000");
        }

        [TestMethod]
        public void ATMTestForDeposit()
        {
            ATM atm = new ATM();
            Param parame = new Param();
            parame.amount = 50000;
            parame.choice = 3;
            parame.deposit = 10000;
            parame.pin = 123;
            Assert.AreEqual(atm.BankTransaction(parame), "Your amount now has been deposited successfully 60000");
        }
    }
}
