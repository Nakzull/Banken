using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    class BasicCard : DebitCard
    {

        public BasicCard(string Name, string AccountNumber, double Balance, List<string> prefixes)
        {
            name = Name;
            accountNumber = AccountNumber;
            accountBalance = Balance;
            possiblePrefix = prefixes;
        }
    }
}
