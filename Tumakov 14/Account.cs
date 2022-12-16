using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_14
{
    public class Account
    {
        Random random = new Random();
        static ulong lastNumber = 4364_2868_4768_0000;
        public ulong Number { get; private set; }
        public AccountType Type { get; set; }
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Не хватает средств на счете!");
                }
                else
                {
                    balance = value;
                }
            }
        }
        internal Account(AccountType type, decimal balance)
        {
            Type = type;
            Balance = balance;
            Number += lastNumber + (ulong)random.Next(1, 10);
            lastNumber = Number;
        }
        internal Account(AccountType type) : this(type, 0)
        {
        }
        internal Account(decimal balance) : this(AccountType.accountCurrent, balance)
        {
        }
        internal Account() : this(AccountType.accountCurrent, 0)
        {
        }
        public bool Withdraw(decimal money)
        {
            if (money > Balance)
            {
                return false;
            }
            else
            {
                Balance -= money;
                return true;
            }
        }
        public void PutMoney(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Операцию произвести невозможно!");
                return;
            }
            Balance += money;
        }
        public bool PutMoneyFromAccount(ref Account account, decimal money)
        {
            if (!account.Withdraw(money))
            {
                return false;
            }
            else
            {
                Balance += money;
                return true;
            }
        }
        public void Display()
        {
            Console.WriteLine("Информация о счете:\n" + $"{Type}\t{Number}\t{balance}$");
        }
        public override string ToString()
        {
            return $"{Type}\t{Number}\t{balance}$";
        }
        public static bool operator ==(Account account1, Account account2)
        {
            if (account1.ToString().Equals(account2.ToString()))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Account account1, Account account2)
        {
            if (account1.ToString().Equals(account2.ToString()))
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj is Account account)
            {
                return account == this;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine(ToString());
        }
    }
}
