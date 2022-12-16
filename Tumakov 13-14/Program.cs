using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест индексатора");
            Console.WriteLine("Тестирование 1");
            Account account1 = new Account(type: AccountType.accountCurrent, balance: 100000);
            Account account2 = new Account(type: AccountType.accountSavings, balance: 800000);
            account2.PutMoneyFromAccount(account1, 3000);
            Console.WriteLine(account1);
            Console.WriteLine(account1[0]);
            Console.WriteLine(account2);
            Console.WriteLine(account2[0]);
            Console.WriteLine("Тестирование 2");
            DecadeBuilding decade = new DecadeBuilding();
            for (int i = 0; i < 10; i++)
            {
                decade[i] = new Building(height: 25 + i, numberStoreys: 5 + i, numberEntrance: 2 + i, numberFlats: 10 + i);
                Console.WriteLine(decade[i]);
            }
            Console.ReadKey();
        }
    }
}
