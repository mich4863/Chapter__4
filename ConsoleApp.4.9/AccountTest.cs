using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._4._9
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            DisplayAccount(account1);
            DisplayAccount(account2);

            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);

            DisplayAccount(account1);
            DisplayAccount(account2);

            Console.Write("\nEnter deposit amount for account2: ");
            decimal depositAmount2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount2:C} to account2 balance\n");
            account2.Deposit(depositAmount2);

            DisplayAccount(account1);
            DisplayAccount(account2);

            Console.Write("\nEnter withdraw amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"withdrawing {withdrawAmount:C} from account1 balance\n");
            account1.Withdraw(withdrawAmount);

            DisplayAccount(account1);
            Console.ReadLine();
        }

        static void DisplayAccount(Account accountToDisplay)
        {
            Console.WriteLine($"{ accountToDisplay.Name} {accountToDisplay.Balance}");    
        }


    }
}
