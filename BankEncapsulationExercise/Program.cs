using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(); //Inferred typing
            // the BankAccount() is a blueprint
            Console.WriteLine("How much would you like to deposit?");
            var amountToDep = double.Parse(Console.ReadLine()); //double.Parse converts amount to string
            account.Deposit(amountToDep);
            Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");

            /*
             * Example - 
            var account = new BankAccount();
            account.Balance = 300;
            Console.WriteLine(account.Balance);
            */
        }
    }
}
