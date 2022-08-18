using System;

namespace Inheritance
{
    class Program
    {
        public static void Main(String[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountNo = "SR-101";
            bankAccount.CustomerName = "Selim Reza";
            bankAccount.Deposit(1000);


            SavingAccount accountSaving = new SavingAccount("TA-101", "Tufayel Ahmed", 200.0);
            //accountSaving.AccountNo = "101";
            //accountSaving.CustomerName = "Tufayel";
            //accountSaving.InterestAmount = 500.0;
            //accountSaving.Deposit(1000);
            //accountSaving.Withdraw(500);

            //double balance = accountSaving.Balance;
            
            CheckingAccount accountChecking = new CheckingAccount("AK-102", "Abul Kalam", 300.0);
            //accountChecking.AccountNo = "102";
            //accountChecking.CustomerName = "Kalam";
            //accountChecking.ServiceCharge = 200.0;
            //accountChecking.Deposit(2000);
            //accountChecking.Withdraw(1000);

            //balance = accountChecking.Balance;

            
            //BankAccount bankAccount2 = new SavingAccount();
            
            //SavingAccount savingAccount = (SavingAccount) new BankAccount();

            //BankAccount bankAccount3 = new CheckingAccount();

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(accountSaving);
            bankAccounts.Add(accountChecking);

            foreach(BankAccount bankAccount1 in bankAccounts)
            {
                bankAccount.Withdraw(100);
            }
        }
    }
}
