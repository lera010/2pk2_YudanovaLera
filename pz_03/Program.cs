﻿namespace pz_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            int a;
            if (age % 10 == 1 & age > 1 & age != 11 || age==1)
                a = 1;
            else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4 & age > 20)
                a = 2;
            else if (age <= 0)
                a = 4;
            else
                a = 3;
            switch (a)
            {
                case 1: 
                    Console.WriteLine($"Вам {age} год");
                break;

                case 2:
                    Console.WriteLine($"Вам {age} года");
                break;
                case 3:
                    Console.WriteLine($"Вам {age} лет");
                break;
                case 4:
                    Console.WriteLine("Введен некорректный возраст");
                break;
            }
        }
    }
}