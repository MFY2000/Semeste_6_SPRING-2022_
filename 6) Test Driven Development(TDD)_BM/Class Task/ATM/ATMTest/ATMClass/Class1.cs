using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClass
{
    public class ATM
    {
        public string BankTransaction(Param parame)
        {
            if (parame.pin == 123)
            {

                int x = 0;
                while (true)
                {
                    switch (parame.choice)
                    {
                        case 1:
                            return "Your current balance is " + parame.amount;
                        case 2:

                            if (parame.withdraw % 100 != 0)
                            {
                                return "Your current balance is above 100";
                            }
                            else if (parame.withdraw > (parame.amount - 1000))
                            {
                                return "Sorry insufficient balance";
                            }
                            else
                            {
                                parame.amount = parame.amount - parame.withdraw;
                                return "Your current amount now is " + parame.amount;
                            }

                        case 3:
                            parame.amount = parame.amount + parame.deposit;
                            return "Your amount now has been deposited successfully " + parame.amount;

                        case 4:
                            return "Thank you";
                    }
                }
            }
            return "";
        }
    }

    public class Param
    {
        public int choice { get; set;  }
        public int deposit { get; set; }
        public int withdraw { get; set; }
        public int amount { get; set; }
        public int pin { get; set; }
    }
}
