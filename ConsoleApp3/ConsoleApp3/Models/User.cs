using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class User: IAccount
    {
        private int _id;

        public int Id  { get;  }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       
        

        private User()
        {
            ++_id;
            Id = _id;

        }

        public bool PasswordChecker (string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;
            if (password.Length>=8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) isUpper = true;
                    else if (char.IsLower(item)) isLower = true;
                    else if (char.IsDigit(item)) isDigit = true;


                }
                if (isDigit && isLower && isUpper) return true;
            }
            return false;
        } 

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname :{Fullname} Email:{Email}");
        }
    }
    }

