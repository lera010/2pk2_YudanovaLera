namespace pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1 "); //задание 1
            for (int a = -100; a <= 20; a +=3)
             Console.WriteLine(a); // выводятся значения от -100 до 20 с шагом 3
            Console.WriteLine(  ); //пустая строка для разграничения заданий



            Console.WriteLine("Задание №2 "); // задание 2
            char m = 'ш';
            for (char simvol = 'п'; simvol<=m ; simvol++)
            Console.Write(simvol+" "); //выводится 10 букв в алфавитном порядке, начиная с "п"
            Console.WriteLine( "\n" ); //пустая строка для разграничения заданий



            Console.WriteLine("Задание №3 "); // задание 3
            for (int b = 0; b < 3; b++) //выведет 3 строки с 10 символами "#"
            { for (int c = 0; c < 10; c++) //выведет строку с 10 символами "#"
                { Console.Write("#"); } 
              Console.WriteLine(  ); 
            }
            Console.WriteLine(  ); //пустая строка для разграничения заданий



            Console.WriteLine("Задание №4 "); // задание 4
            int f = 0; //ввод переменной, используемой для счетчика кратных чисел
            for (int i = -300; i < 200; i++)
            {
                if (i % 6 == 0)
                {
                    Console.Write(i + " "); //выводит числа кратные 6 (условие if) из диапазона чисел от -300 до 200 (цикл for)
                    f++; //счетчик кратных чисел
                }
            }
            Console.WriteLine("\nКоличество кратных чисел: " + f); //с новой строки выводит сообщение с количеством кратных чисел
            Console.WriteLine(  ); //пустая строка для разграничения заданий



            Console.WriteLine("Задание №5 "); // задание 5
            int t, e; //объявление переменных
            for (t =2, e =30; t-e <= 6;  t++, e--)
            { Console.WriteLine(t+" "+e); } //вывод инкрементированных и декрементированных переменных пока разница между ними не будет меньше 6

        }
    }
}