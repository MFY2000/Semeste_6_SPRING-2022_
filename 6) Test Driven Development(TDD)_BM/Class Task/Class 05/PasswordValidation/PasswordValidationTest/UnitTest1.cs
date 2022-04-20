using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using PasswordValidation;
using System.Collections.Generic;

namespace PasswordValidationTest
{
    [TestClass]
    public class UnitTest1
    {

        Dictionary<string, int> ErrorLog = new Dictionary<string, int>();
        

        public UnitTest1(){
            ErrorLog.Add("null", 0);
            ErrorLog.Add("password is less than 8", -1);
            ErrorLog.Add("password dosn't contain Uppercase", -2);

            ErrorLog.Add("password dosn't contain lowercase", -3);
            ErrorLog.Add("password dosn't contain number", -4);
            //ErrorLog.Add("", );
        }

        /// <summary>
        /// 1 => all set 
        /// 0 => null
        /// -1 => password is less than 8
        /// -2 => password dosn't contain Uppercase
        /// -3 => password dosn't contain lowercase
        /// -4 => password dosn't contain number
        /// 
        /// </summary>




        /// <summary>
        /// Null check  
        /// </summary>

        [TestMethod]
        public void Valid_001()
        {
            int resultLog = UserDetails.isPasswordValid("");
            Assert.AreEqual(0, resultLog, ErrorLog[resultLog]);
        }
    }
}
