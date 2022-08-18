using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SavingAccount : BankAccount
    {
        public double InterestAmount { get; set; }
        public SavingAccount(string accountNo, string coustomerName, double interestAmount) : base(accountNo, coustomerName)
        {
            InterestAmount = interestAmount;
        }

        public override string Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                return base.Withdraw(amount);
            }
            return "Insufficient Balance";
        }
    }
}
