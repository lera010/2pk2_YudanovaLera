namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите количество строк в массиве: ");
            int a = int.Parse(Console.ReadLine());//ввод количества строк пользователем
            Console.Write("Введите количество столбцов в массиве: ");
            int b = int.Parse(Console.ReadLine());//ввод количества столбцов пользователем

            int[,] array = new int[a, b];//объявление массива


            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    array[i, j] = rnd.Next(-10000, 10001); //заполнение массива рандомными числами от -10000 до 10000 включительно


            for (int i = 0; i < a; i++, Console.WriteLine())
                for (int j = 0; j < b; j++)
                    Console.Write(array[i, j] + "\t"); //вывод массива

            int min = int.MaxValue, indexMin = 0;//объявление переменной минимума и номера строки с минимальными значениями

            for (int i = 0; i < a; i++)
            {
                int sum = 0; //объявление переменной суммы
                for (int j = 0; j < b; j++)
                    sum += array[i, j]; //нахождение суммы элементов строки

                if (sum < min) //если сумма меньше минимального значения, выполняются следующие действия:
                {
                    min = sum;//переменной минимума присваивается значение суммы
                    indexMin = i; //переменной присваивается число, обозначающее номер строки
                }
            }

            Console.Write("Строка с минимальной суммой элементов: ");
            for (int j = 0; j < b; j++)
                Console.Write(array[indexMin, j] + " ");//вывод результата на консоль
        }
    }
}