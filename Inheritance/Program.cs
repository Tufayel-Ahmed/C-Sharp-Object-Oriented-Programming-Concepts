using System;

namespace Inheritance
{
    class Program
    {
        public static void Main(String[] args)
        {
            SavingAccount accountSaving = new SavingAccount();
            accountSaving.AccountNo = "101";
            accountSaving.CustomerName = "Tufayel";
            accountSaving.InterestAmount = 500.0;
            accountSaving.Deposit(1000);
            accountSaving.Withdraw(500);

            double balance = accountSaving.Balance;
            
            CheckingAccount accountChecking = new CheckingAccount();
            accountChecking.AccountNo = "102";
            accountChecking.CustomerName = "Kalam";
            accountChecking.ServiceCharge = 200.0;
            accountChecking.Deposit(2000);
            accountChecking.Withdraw(1000);

            balance = accountChecking.Balance;

            BankAccount bankAccount = new BankAccount();
            
            BankAccount bankAccount2 = new SavingAccount();
            
            SavingAccount savingAccount = (SavingAccount) new BankAccount();

            BankAccount bankAccount3 = new CheckingAccount();
        }
    }
}
