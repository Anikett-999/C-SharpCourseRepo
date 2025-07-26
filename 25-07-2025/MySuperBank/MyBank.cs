using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public  class MyBank
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public string Balance { get; set; }

        public MyBank(string Name , string InitialBalance )
        {
            Owner = Name;
            Balance = InitialBalance;

        }
    }
}
