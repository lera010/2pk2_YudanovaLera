namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();    
            int size = 50;
            int[][] array = new int[size][];//объявление массива
            
            for (int i = 0; i < size; i++)
            {
                int size2 = rnd.Next(10, 21); //сохранение в переменную длины строк
                array[i] = new int[size2]; //создание строки с опреденным количеством элементов
                for (int j = 0; j < size2; j++) 
                {
                    array[i][j] = rnd.Next(-1000, 1001); //присвоение рандомных значений элементов массива
                }            
            }


            Console.WriteLine("Задание 2");     
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < array[i].Length; j++) 
                {
                    Console.Write(array[i][j]+" "); 
                }
                Console.WriteLine(); //вывод массива
            }
            Console.WriteLine();


            Console.WriteLine("Задание 3");     
            int[] task3 = new int[size];//объявление одномерного массива
            for (int i = 0; i < size; i++)
            {
                task3[i] = array[i][array[i].Length - 1]; //заполнение массива последними элементами строки
                Console.Write(task3[i]+ " "); //вывод массива
            }
            Console.WriteLine();


            Console.WriteLine("\nЗадание 4");
            int[][] task4 = array;

            for (int i = 0; i < size; i++)
            {
                Array.Sort(task4[i]);//сортирует массив
            }

            Console.WriteLine("Максимальные значения каждой строки массива: ");
            for (int i = 0; i < size; i++)
            {
                task3[i] = task4[i][task4[i].Length - 1];//заполнение массива последними элементами строк отсортированного массива
                Console.Write(task3[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Задание 5");        
            int forFirst = 0;
            int forMax = 0;
            int[] max1 = new int[size];
            int[] first = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                  {
                   if (array[i][j] == first[forFirst])//если элемент первый то он меняется местами с максимальным
                    {
                       array[i][j] = max1[forFirst];
                    }
                   else if (array[i][j] == max1[forMax])//если элемент максимальный то он меняется местами с первым
                    {
                        array[i][j] = first[forMax];
                    }
                 Console.Write(array[i][j] + " ");
                  }
                forFirst++;//обновление
                forMax++;//обновление
            Console.WriteLine();//вывод
            }
            Console.WriteLine();


            Console.WriteLine("Задание 6");

            for (int i = 0; i < array.Length; i++)
            {
                Array.Reverse(array[i]);//реверс массива
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();//вывод реверсированого массива
            }
            Console.WriteLine();


            Console.WriteLine("Задание 7");     
            double mid = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    mid += array[i][j]; //сумма всех элементов строки
                }
                mid /= array[i].Length;//нахождение среднего значения
                Console.Write(Math.Round(mid, 2) +"  "); //вывод с округлением 2 знака после запятой
                mid = 0;
            }

        }
    }
}