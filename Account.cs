using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesRoles
{
    internal class Account
    {
        private protected int Balance {  get; set; }

        public int GetBalance() { return Balance; }
    }
    internal class SavingsAccount : Account 
    {
        public void SetBalance(int balance) 
        {
            Balance = balance;       
        }
    }
}
