using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    public class UserDetails
    {
        public string userName { get; set; }
        public string password { get; set; }

        public UserDetails(string _userName, string _password)
        {
            userName = _userName;
            if (isPasswordValid(_password) == 1)
            {
                password = _password;
            }
        }

        /// <summary>
        /// 1 => all set 
        /// 0 => null
        /// -1 => password is less than 8
        /// -2 => password dosn't contain Uppercase
        /// -3 => password dosn't contain lowercase
        /// -4 => password dosn't contain number
        /// 
        /// 
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="_password"></param>
        /// <returns></returns>


        public static int isPasswordValid(string _password)
        {
            int isPasswordValid = 0;

            if(_password.Length < 8)
            {
                if (_password.Any(char.IsUpper))
                {
                    if (_password.Any(char.IsLower))
                    {
                        if (_password.Any(char.IsDigit))
                        {
                            isPasswordValid = 1;
                        }
                        else
                        {
                            isPasswordValid = -4;
                        }
                    }
                    else
                    {
                        isPasswordValid = -3;
                    }
                }
                else
                {
                    isPasswordValid = -2;
                }
            }
            else if (password == null)
            {
                isPasswordValid = 0;
            }
            else
            {
                isPasswordValid = -1; 
            }


            return isPasswordValid;
        }

    }
}
