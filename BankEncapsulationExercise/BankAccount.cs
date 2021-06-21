using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;
        /* Encapsulation - The only way to access the private balance is to 
         * make a public deposit. */
        public void Deposit(double amount)
        {
            balance = amount;
        }
        public double GetBalance()
        {
            return balance;
        }






        /*
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        */


    }
    // This public property has read (get) and write (set) capabilities.

    public BankAccount(double amount)
        {
            balance = 0;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }


    }
}
