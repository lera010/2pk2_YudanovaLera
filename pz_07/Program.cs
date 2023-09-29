namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Введите число строк массива:");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите число столбцов массива:");
            int b = Convert.ToInt32(Console.ReadLine());
            int min = Int32.MaxValue;//объявление переменной обозначающей максимальное число
            int indexmin = 0;
            int[,] array = new int [a, b];
            for (int i=0; i<a; i++)
            {
                for (int j=0; j<b; j++)
                {   
                    array [i,j] = rnd.Next(-10000,10000);
                    Console.Write(array[i,j]+ "\t");
                    int sum = 0;
                    sum += array[i, j];
                    
                    if (sum < min)
                    {
                        min = sum;
                        indexmin = i;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Строка с минимальной суммой элементов");
            for (int j = 0; j < b; j++)
            {
                Console.Write(array[indexmin, j] + "\t");
            }
        }
    }
}