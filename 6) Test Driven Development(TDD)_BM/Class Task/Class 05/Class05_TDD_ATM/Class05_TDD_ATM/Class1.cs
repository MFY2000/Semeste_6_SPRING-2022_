using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_TDD_ATM
{


    public class ATM
    {
        string pinCode = "KJDLSN156A";
        public string BankTransaction(Param param)
        {
            string result = "Thanks You";

            if (pinCode == param.pinCode)
            {
                switch (param.choice)
                {
                    case 1:
                        result = "Your Current Balance is " + param.amout;
                        break;
                    case 2:

                        if (param.actionAmount < 100)
                        {
                            result = "Your withdraw amout is less than limit(100)";
                        }
                        else if (param.actionAmount > 1000)
                        {
                            result = "Your withdraw amout is great than limit(1000)";
                        }
                        else if (param.actionAmount > param.amout)
                        {
                            result = "Your Current balance is insufficenet:"+ param.amout;
                        }
                        else
                        {
                            param.amout = param.amout - param.actionAmount;
                            result = "Withdraw Successfully of amount:"+ param.amout;
                        }

                        break;
                    case 3:
                        result = param.amout > 0 ? "Your Balance Deposit Successfully: " + param.amout + param.actionAmount  : "Please Select amount greater then 0: " + param.amout;
                        break;

                    default: result = "Wrong Option Choice";
                        break;
                }
            } else
            {
                result = "Incorrect Pin";
            }
            
            
            
            
            return result;
        }
    }
    public class Param
    { 
        public string pinCode { get; set; }
        public int choice { get; set; }
        public int actionAmount { get; set; }
        public int amout { get; set; }
    }


}
