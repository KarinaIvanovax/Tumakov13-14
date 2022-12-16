using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗадание 14.1 ");
            Account account = new Account(AccountType.accountCurrent, 2040000);
            account.Withdraw(4234);
            account.DumpToScreen();
            Console.WriteLine();

            Console.WriteLine("\tДомашнее задание 14.1 ");
            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (object attrObj in attrs)
            {
                if (attrObj is DeveloperInfoAttribute2 attr)
                {
                    Console.WriteLine($"Разработчик класса \"Building\"  -- {attr.NameDeveloper}");
                    Console.WriteLine($"Организация  -- {attr.NameOrganization}");
                }
            }
            Console.ReadKey();
        }
    }
}
