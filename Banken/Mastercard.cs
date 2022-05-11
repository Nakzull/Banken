using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    class Mastercard : CreditCard, IExpire
    { 
        public Mastercard(string Name, string AccountNumber, double Balance, List<string> prefixes, int monthlyLimit)
        {
            name = Name;
            accountNumber = AccountNumber;
            accountBalance = Balance;
            possiblePrefix = prefixes;
            monthlyLoanLimit = monthlyLimit;
        }
        public void GetExpirationDate()
        {
            DateTime dt = DateTime.Now.AddYears(5);
            expirationDate = dt.Month.ToString() + "/" + dt.Year.ToString();
            Console.WriteLine(expirationDate);
        }
    }
}
