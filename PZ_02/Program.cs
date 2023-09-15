namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число:");
            double a = double.Parse(Console.ReadLine()); //объявление переменной
            Console.WriteLine("Введите целое число:");
            double c = double.Parse(Console.ReadLine()); //объявление переменной
            double pi = Math.PI; //переменная со значением числа пи
            double x, y, z; //указание типа переменных
            if (a > pi) 

                x = Math.Cos(a + 2 * c); //вычисление, если введенное пользователем число больше пи

            else

                x = c + Math.Sqrt(a * (c * c) - 2 * (a + pi)); //вычисление, если введенное пользователем число меньше или равно пи

            if (x <= 0)

                y = Math.Log(a + c - x);//вычисление, если найденная переменная x меньше или равна нулю

            else

                y = Math.Sin(2 * a * x) + Math.Sin(a + x);//вычисление, если найденная переменная x больше нуля

            z = (2 * x + 3 * y) * (a * a - c * c); //вычисление конечного результата с найденными переменными x и y

            Console.WriteLine("Результат: " + z);
        }
    }
}