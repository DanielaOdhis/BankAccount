using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{
    public class BankAccount
    {
        //members of the class (5)
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        //constructor because it has the same name as the class
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
