using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount("Renato", 1000);
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(600, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
