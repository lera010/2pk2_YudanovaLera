using System.Text;

namespace pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\\txt.txt";
            string file1 = @"D:\\f1.txt";
            string file2 = @"D:\\f2.txt";

            StreamReader reader = new StreamReader(file);
            string[] array = reader.ReadToEnd().Split(' ');// разделение содержимого файла на слова и занесение в массив
            reader.Close();
            StreamWriter writer1 = new StreamWriter(file1);//поток для f1
            StreamWriter writer2 = new StreamWriter(file2);//поток для f2

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)//проверка на четность
                {
                    writer1.Write(array[i] + " ");//добавление в массив
                }
                else
                {
                    writer2.Write(array[i] + " ");//добавление в массив
                }
            }
            writer1.Close();//закрытие потоков
            writer2.Close();
            
            Console.WriteLine("Содержимое файла с нечетными ");
            StreamReader reader1 = new StreamReader(file1);
            string[] array1 = reader1.ReadToEnd().Split(' ');
            for (int i = 0; i < array1.Length; i++) //массива
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Содержимое файла с четными ");
            StreamReader reader2 = new StreamReader(file2);
            string[] array2 = reader2.ReadToEnd().Split(' ');
            for (int i = 0; i < array2.Length; i++) //вывод массива
            {
                Console.Write(array2[i] + " ");
            }
        }
    }
}