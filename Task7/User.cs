using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    internal class User : IAccountTable
    {
        public int Id { get; }
        private int _id = 0;
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value) && value.Length > 8)
                {
                    _password = value;
                } 
               
            }
        }

        public bool PasswordChecker(string password)
        {
            bool hasdigit = false;
            bool hassupper = false;
            bool haslower = false;

            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    hasdigit = true;
                }

                if (char.IsUpper(item))
                {
                    hassupper = true;
                }
                if (char.IsLower(item))
                {
                    haslower = true;
                }
            }
            bool result = hasdigit && hassupper && haslower;
            return result;
        }


        public void Showinfo()
        {
            Console.WriteLine($"Id:{Id} Fullname:{Fullname} Email:{Email}");
        }

        public User()
        {
            Id = ++_id;
        }

    }
}
