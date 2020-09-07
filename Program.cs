using System;

namespace tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/es-es/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
            // https://github.com/dotnet/docs/tree/master/samples/snippets/csharp/classes-quickstart/

            var account = new BankAccount("Aitor", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException)//(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                //Console.WriteLine(e.ToString());
            }
            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException)//(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                //Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
