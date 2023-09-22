namespace pz_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: "); //вывод текста
            int n = Convert.ToInt32(Console.ReadLine()); //объявление и воод переменной
            int f0 = 0; //объявление переменной, обозначающей число фибоначчи 0
            int f1 = 1;//объявление переменной, обозначающей число фибоначчи 1
            int a = 2;//объявление переменной, используемой в цикле
            int fn = 0;//объявление переменной, обозначающей конечный результат 
            if (n == 0) { fn=0; }
            if (n == 1) { fn=1; }

            while (n>=a)//
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                a++;
            }
            Console.WriteLine($"Фибоначчи №{n} = {fn}");//
        }
    }
}