using System;
using System.Collections.Generic;

namespace Banken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> basicCardPrefixes = new List<string>() { "2400" };
            List<string> maestroPrefixes = new List<string>() { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            List<string> visaElectronPrefixes = new List<string>() { "4026", "417500", "4508", "4844", "4913", "4917" };
            List<string> visaCreditCardPrefixes = new List<string>() { "4" };
            List<string> mastercardPrefixes = new List<string>() { "51", "52", "53", "54", "55" };

            BasicCard basicCard = new BasicCard("Mads Rasmussen", "78923892739", 14738.27, basicCardPrefixes);
            Maestro maestro = new Maestro("Andreas Larsen", "3048957349857", 394875349857, maestroPrefixes);
            VisaElectron visaElectron = new VisaElectron("Mathias smolpepe", "902385379823", 90, visaElectronPrefixes);
            VisaCreditCard visaCreditCard = new VisaCreditCard("Jannick Bladfjeder", "003489789345", 420.69, visaCreditCardPrefixes, 20000);
            Mastercard mastercard = new Mastercard("Camilla HendeDenSure", "938090803945", 34987.00 , mastercardPrefixes, 40000);
            List<BankCard> bankCards = new List<BankCard>() { basicCard, maestro, visaElectron, visaCreditCard, mastercard };
            foreach (BankCard bankCard in bankCards)
            {
                bankCard.GeneratePrefix();
                bankCard.GenerateCardNumber();
            }
            maestro.GetExpirationDate();
            visaElectron.GetExpirationDate();
            visaCreditCard.GetExpirationDate();
            mastercard.GetExpirationDate();
        }
    }
}
