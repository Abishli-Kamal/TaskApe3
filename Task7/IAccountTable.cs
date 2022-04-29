using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    internal interface IAccountTable
    {
        public bool PasswordChecker(string password);
        public void Showinfo();
    }
}
