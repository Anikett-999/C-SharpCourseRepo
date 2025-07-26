using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class MyBank
    {
        public int AccountNumber = 1000;
        public string Owner { get; set; }
        public double Balance { get; set; }

        public  MyBank(string Name, double InitialBalance)
        {
            
            Owner = Name;
            Balance = InitialBalance;
           
        }
    }
}
