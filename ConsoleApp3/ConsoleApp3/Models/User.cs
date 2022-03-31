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

        public string GetPasswordChecker()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname :{Fullname} Email:{Email}");
        }
    }
    }

