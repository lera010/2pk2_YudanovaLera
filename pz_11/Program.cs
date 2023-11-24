namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void compareSP(int a, int b, out double s, out double p)//метод для подсчета площади и периметра
            {
                s = 0.5 * a * b;//подсчет площади
                Console.WriteLine("Площадь треугольника равна: " + s);
                p = a + b + (Math.Sqrt(a * a + b * b));//подсчет периметра
                Console.WriteLine("Периметр треугольника равен: " + Math.Round(p, 3));//вывод с округлением
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Введите первый катет первого треугольника");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второй катет первого треугольника");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите первый катет второго треугольника");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второй катет второго треугольника");
                int b2 = Convert.ToInt32(Console.ReadLine());
                double s1, p1, s2, p2;//объявление переменных в которых будут храниться результаты вычислений из метода
                compareSP(a1, b1, out s1, out p1);//вызов метода для сторон первого треугольника
                compareSP(a2, b2, out s2, out p2);//вызов метода для сторон второго треугольника
                if (s1 > s2) Console.WriteLine("Площадь первого треугольника больше площади второго");//сравнение площади первого и второго треугольника
                else Console.WriteLine("Площадь второго треугольника больше площади первого");
                if (p1 > p2) Console.WriteLine("Периметр первого треугольника больше периметра второго");//сравнение периметра первого и второго треугольника
                else Console.WriteLine("Периметр второго треугольника больше периметра первого");
            }
        }
    }
}