namespace pz_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            int a;
            if (age % 10 == 1 & age > 1 & age != 11 || age==1)
                a = 1; //присвоение переменной a значения 1, если остаток от деления равен 1 или число введенное пользователем равно 1
            else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4 & age > 20)
                a = 2; //присвоение переменной a значения 2, если остаток от деления равен 2 или 3 или 4 и при этом число введенное пользователем больше 20
            else if (age <= 0)
                a = 4; //присвоение переменной a значения 4, если число введенное пользователем меньше или равно нулю
            else
                a = 3; //присвоение переменной a значения 3, если не выполняются предыдущие условия

            switch (a)//вывод текста на консоль в зависимости от числа полученного при использовании оператора if
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