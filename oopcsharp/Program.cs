using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{

        class Program
        {
            static void Main(string[] args)
            {
                var account = new BankAccount("Daniela", 10000);
                Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

                account.MakeWithdrawal(120, DateTime.Now, "Hammock");
                Console.WriteLine(account.Balance);
            }
        }

}