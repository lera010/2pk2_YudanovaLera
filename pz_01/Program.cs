namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите переменную a"); //вывод текста

            double a = double.Parse(Console.ReadLine()) ; //объявление переменной a

            Console.WriteLine("Введите переменную b"); //вывод текста

            double b = double.Parse(Console.ReadLine()); //объявление переменной b

            Console.WriteLine("Введите переменную c"); //вывод текста

            double c = double.Parse(Console.ReadLine()); //объявление переменной c

            double result = 5 * Math.Atan(a) - 1 / 4.0 * Math.Cos(a) * (a + 3 * Math.Abs(a - b) + a * a )/ (Math.Abs(a - b) * c + a * a); //вычисление выражений

            Console.WriteLine("Результат: " + result); //вывод результата 
        }
    }
}