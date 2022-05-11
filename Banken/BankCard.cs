using System;
using System.Collections.Generic;
using System.Text;

namespace Banken
{
    abstract class BankCard
    {
        protected Random rng = new Random();
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string prefix;

        public string Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }


        protected string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        protected string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        protected double accountBalance;

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        protected List<string> possiblePrefix;

        public List<string> PossiblePrefix
        {
            get { return possiblePrefix; }
            set { possiblePrefix = value; }
        }

        public void Deposit(double deposit)
        {
            accountBalance += deposit;
        }

        public virtual void Withdraw(double withdrawAmount)
        {
            if ((accountBalance - withdrawAmount) > 0)
            {
                accountBalance -= withdrawAmount;
            }
            else
                Console.WriteLine("Your balance isn't high enough to withdraw that amount");
        }

        public void GeneratePrefix()
        {
            prefix = possiblePrefix[rng.Next(0, possiblePrefix.Count)];
            cardNumber = prefix;
        }

        public virtual void GenerateCardNumber()
        {           
            for (int i = prefix.Length; i < 16; i++)
            {
                cardNumber += rng.Next(0, 10);
            }
            Console.WriteLine(cardNumber);
        }
    }
}
