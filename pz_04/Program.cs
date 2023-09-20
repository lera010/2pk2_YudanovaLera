namespace pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1 "); //задание 1
            int a ; 
            for (a = -100; a <= 20; a +=3)
             Console.WriteLine(a);
            Console.WriteLine(  );//пустая строка


            Console.WriteLine("Задание №2 "); // задание 2
            char m = 'ш';
            for (char simvol = 'п'; simvol<=m ; simvol++)
            Console.WriteLine(simvol);
            Console.WriteLine(  );//пустая строка


            Console.WriteLine("Задание №3 "); // задание 3
            int b, c;
            for (b = 0; b < 3; b++)
            { for (c = 0; c < 10; c++)
                { Console.Write("#"); }
              Console.WriteLine(  ); 
            }
            Console.WriteLine(  );//пустая строка


            Console.WriteLine("Задание №4 "); // задание 4
            int s = 0;  
            for (int f = -300; f < 200; f++)
            { if (f % 6 == 0)
                    Console.Write(f+" ");
                s++;
                 }
            Console.WriteLine("количество кратных чисел равно: "+ s);
            Console.WriteLine(  );//пустая строка


            Console.WriteLine("Задание №5 "); // задание 5
            int t, e;
            for (t =2, e =30; t-e <= 6;  t++, e--)
            { Console.WriteLine(t+" "+e); }

        }
    }
}