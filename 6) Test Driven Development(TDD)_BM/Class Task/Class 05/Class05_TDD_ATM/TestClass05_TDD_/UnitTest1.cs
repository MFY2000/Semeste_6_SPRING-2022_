using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Class05_TDD_ATM;
namespace TestClass05_TDD_
{
    [TestClass]
    public class UnitTest1
    {
        Distance distance = new Distance();
        /// <summary>
        /// 
        /// Distance cover is always the product of s * t (speed * time)
        /// </summary>
        [TestMethod]
        public void DistanceTest1()
        {
            double expected = 50;
            double actual = distance.getDistance(5,10);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// negivative
        /// </summary>
        [TestMethod]
        public void DistanceTest2()
        {
            double expected = 50;
            double actual = distance.getDistance(2, 10);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// distance throught 
        /// </summary>
        [TestMethod]
        public void DistanceTest3_XY()
        {
            double expected = 2.24;
            double[] x_array = {2, 3};
            double[] y_array = {5, 7};
            double actual = distance.getDistance_XY(x_array, y_array);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// distance throught - values 
        /// </summary>
        [TestMethod]
        public void DistanceTest4_XY()
        {
            double expected = 5.39;
            double[] x_array = { 10, 5 };
            double[] y_array = { 8, 10 };
            double actual = distance.getDistance_XY(x_array, y_array);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// distance on zero
        /// </summary>
        [TestMethod]
        public void DistanceTest5_XY()
        {
            double expected = 0;
            double[] x_array = { 5, 5 };
            double[] y_array = { 10, 10 };
            double actual = distance.getDistance_XY(x_array, y_array);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// distance in KM always time will be great than zero, 
        /// </summary>
        [TestMethod]
        public void DistanceTest6_PHM()
        {
            double expected = 0;
            double[] x_array = { 5, 5 };
            double[] y_array = { 10, 10 };
            double actual = distance.getDistance_XY(x_array, y_array);
            Assert.AreEqual(expected, actual);
        }
    }


    [TestClass]
    public class UnitTest2
    {
        ATM atm = new ATM();
        Param param = new Param();
        string pin = "KJDLSN156A";
        

            /// <summary>
            /// check correct pin 
            /// </summary>
            [TestMethod]
            public void TestPinTC001()
            {
                param.pinCode = pin;
                param.choice = 4;
                string actualValue = atm.BankTransaction(param);
                Assert.AreEqual(actualValue, "Wrong Option Choice");
            }


        /// <summary>
        /// check Incorrect pin 
        /// </summary>
        [TestMethod]
        public void TestPinTC002()
        {
            param.pinCode = "216a5s15adf";
            param.choice = 1;
            string actualValue = atm.BankTransaction(param);
            Assert.AreEqual(actualValue, "Incorrect Pin");
        }
        /// <summary>
        /// check balance
        /// </summary>
        [TestMethod]
            public void TestBalanceTC001()
            {
                var amount = 5000;
                
                param.pinCode = pin;
                param.choice = 1;
                param.amout = amount;

                var value = "Your Current Balance is " + amount;
                
                var actualValue = atm.BankTransaction(param);
                Assert.AreEqual(value, actualValue);
            }
        /// <summary>
        /// check insufficenet
        /// </summary>
        [TestMethod]
            public void TestWithdrawTC001()
            {
                var amount = 500;
                var amountWithdraw = 800;
                param.pinCode = pin;
                param.choice = 2;
                param.amout = amount;
                param.actionAmount = amountWithdraw;


                var value = "Your Current balance is insufficenet:" + amount;
                var actualValue = atm.BankTransaction(param);
                Assert.AreEqual(value, actualValue);
            }


        /// <summary>
        /// check min balance
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC002()
        {
            var amount = 5000;
            var amountWithdraw = 50;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.actionAmount = amountWithdraw;


            var value = "Your withdraw amout is less than limit(100)";
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }


        /// <summary>
        /// check max balance
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC003()
        {
            var amount = 5000;
            var amountWithdraw = 1500;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.actionAmount = amountWithdraw;


            var value = "Your withdraw amout is great than limit(1000)";
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }


        /// <summary>
        /// withdraw Successfully
        /// </summary>
        [TestMethod]
        public void TestWithdrawTC004()
        {
            var amount = 5000;
            var amountWithdraw = 900;
            param.pinCode = pin;
            param.choice = 2;
            param.amout = amount;
            param.actionAmount = amountWithdraw;


            string value = "Withdraw Successfully of amount:" + (param.amout - param.actionAmount);
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
        }

        /// <summary>
        /// check deposit
        /// </summary>
        [TestMethod]
            public void TestDepositTC001()
            {
                var ammount = 1000;
                        
            string value = "Your Balance Deposit Successfully: " + (param.amout +  param.actionAmount);
            var actualValue = atm.BankTransaction(param);
            Assert.AreEqual(value, actualValue);
            }
        
    
    
    }

}
