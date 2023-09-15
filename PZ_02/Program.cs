namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            double c = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double x, y, z;
            if (a > pi)

                x = Math.Cos(a + 2 * c);

            else

                x = c + Math.Sqrt(a * (c * c) - 2 * (a + pi));

            if (x <= 0)

                y = Math.Log(a + c - x);

            else

                y = Math.Sin(2 * a * x) + Math.Sin(a + x);

            z = (2 * x + 3 * y) * (a * a - c * c);
            Console.WriteLine("Результат: " + z);
        }
    }
}