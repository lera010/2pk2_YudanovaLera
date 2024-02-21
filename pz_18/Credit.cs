using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18
{
    enum Status { high, average, low }
    internal class Credit
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public decimal Sum { get; set; }

        public static int clients = 0;
        public static decimal allcredits = 0;
        public Credit(string name, Status status, int sum)
        {
            Name = name;
            Status = status;
            Sum = sum;

            if (string.IsNullOrEmpty(name))
                Console.WriteLine("Поле ФИО не может быть пустым");

            if (sum < 100000 || sum > 5000000)
                Console.WriteLine("Сумма кредита не может быть меньше 100000 и больше 5000000");

            clients++;
            allcredits += sum;
        }
        public void PrintCreditInfo()
        {
            Console.WriteLine($"ФИО: {Name}");
            if (Status == Status.high)//проверка на статус кредитной истории
                Console.WriteLine($"Статус кредитной истории: высокий \n Процент по кредиту: 10");
            else if (Status == Status.average)
                Console.WriteLine($"Статус кредитной истории: средний \n Процент по кредиту: 12");
            else
                Console.WriteLine("Процент по кредиту: отсутствует");
            Console.WriteLine($"Сумма кредита: {Sum}");
        }
        public void GetCredit()//метод выдачи кредита
        {
            if (allcredits < 5000000)//проверка на остаток средств в банке
            {
                if (Status == Status.high)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Кредит одобрен");
                }
                else if (Status == Status.average)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Кредит одобрен");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Кредит отказан");
                    if (clients != 0)
                        clients--;
                    allcredits -= Sum;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Кредит отказан(недостаточно средств в банке)");
                if (clients != 0)
                    clients--;
                allcredits -= Sum;
            }
        }
        public static void PrintBankInfo()
        {
            Console.WriteLine($"Сумма всех кредитов в банке:{allcredits}");
            Console.WriteLine($"Количество выданных кредитов:{clients}");
            Console.WriteLine($"Остаток средств банка:{5000000 - allcredits}");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}