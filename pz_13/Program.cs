namespace pz_13
{
    internal class Program
    {
            static void Main(string[] args)
            {   //task 1
                Console.WriteLine("Задание 1");
                Console.WriteLine("Введите номер члена арифметической прогрессии: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double res = arpr(n); //вызов метода
                Console.WriteLine("Ответ: " + res);
                Console.WriteLine();

                //task 2
                Console.WriteLine("Задание 2");
                Console.WriteLine("Введите номер члена геометрической прогрессии: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                double res2 = geompr(n2);//вызов метода
                Console.WriteLine("Ответ: " + res2);
                Console.WriteLine();

                //task 2
                Console.WriteLine("Задание 3");
                Console.WriteLine("Введите число А: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число В: ");
                int b = Convert.ToInt32(Console.ReadLine());
                double res3 = nums(a, b);//вызов метода
                Console.WriteLine(res3);
                Console.WriteLine();

                //task 4
                Console.WriteLine("Задание 4");
                Console.WriteLine("Введите положительное число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                double res4 = sum(num1);//вызов метода
                Console.WriteLine($"Сумма чисел от 1 до {num1}: " + res4);
                Console.WriteLine();
            }

            static double arpr(double n) // метод 1
            {
                if (n == 1)
                    return 0.5;
                else
                {
                    return arpr(n - 1) + 0.5;
                }
            }

            static double geompr(double n2) // метод 2 
            {
                if (n2 == 1)
                    return 9;
                else
                {
                    return -0.3 * geompr(n2 - 1);
                }
            }
            static double nums(int A, int B) // метод 3
            {
                if (A == B)
                    return A;
                else if (A < B && A != B)
                {
                    Console.Write(A + " ");
                    return nums(A + 1, B);
                }
                else if (A >= B && A != B)
                {
                    Console.Write(A + " ");
                    return nums(A - 1, B);
                }
                else
                { return B; }


            }
            // ЗАДАНИЕ НА 5:С помощью рекурсии Summ(int x) для введенного числа n вычислить сумму чисел от 1 до n
            //Например: Summ(2) = 2 + 1 = 3
            //Summ(5) = 5 + 4 + 3 + 2 + 1 = 15
            static int sum(int num1)
            {
                if (num1 > 0)
                    return sum(num1 - 1) + num1;
                else
                    return 0;
            }
        }
    }
