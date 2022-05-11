using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    class CreditCard : BankCard
    {
        protected double currentMonthlyLoan;

        public double CurrentMonthlyLoan
        {
            get { return currentMonthlyLoan; }
            set { currentMonthlyLoan = value; }
        }

        protected int monthlyLoanLimit;

        public int MonthlyLoanLimit
        {
            get { return monthlyLoanLimit; }
            set { monthlyLoanLimit = value; }
        }

        protected string expirationDate;

        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public override void Withdraw(double withdrawAmount)
        {
            if (accountBalance - withdrawAmount >= 0)
            {
                accountBalance -= withdrawAmount;
            }
            else if (accountBalance + monthlyLoanLimit - currentMonthlyLoan - withdrawAmount >= 0)
            {
                accountBalance -= withdrawAmount;
                currentMonthlyLoan -= accountBalance - withdrawAmount;
            }
            else
                Console.WriteLine("Your balance isn't high enough to withdraw that amount");
        }
    }
}
