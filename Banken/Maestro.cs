using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    class Maestro : DebitCard, IExpire
    {
        private string expirationDate;

        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public string date { get; set; }
        public override void GenerateCardNumber()
        {
            for (int i = prefix.Length; i < 19; i++)
            {
                cardNumber += rng.Next(0, 10);
            }
            Console.WriteLine(cardNumber);
        }


        public Maestro(string Name, string AccountNumber, double Balance, List<string> prefixes)
        {
            name = Name;
            accountNumber = AccountNumber;
            accountBalance = Balance;
            possiblePrefix = prefixes;
        }
       
        public void GetExpirationDate()
        {
            DateTime dt = DateTime.Now.AddYears(5).AddMonths(8);
            expirationDate = dt.Month.ToString() + "/" + dt.Year.ToString();
            Console.WriteLine(expirationDate);
        }
    }
}
