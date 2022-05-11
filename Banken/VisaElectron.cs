using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    class VisaElectron : DebitCard, IExpire
    {
        private string expirationDate;

        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public VisaElectron(string Name, string AccountNumber, double Balance, List<string> prefixes)
        {
            name = Name;
            accountNumber = AccountNumber;
            accountBalance = Balance;
            possiblePrefix = prefixes;
        }
        public void GetExpirationDate()
        {
            DateTime dt = DateTime.Now.AddYears(5);
            expirationDate = dt.Month.ToString() + "/" + dt.Year.ToString();
            Console.WriteLine(expirationDate);
        }
    }
}
