namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            double sum = 0;
            int c = 0;
 
            for (int i = 0; i < text.Length; i++)
            {   
                string num = "";

                while (i < text.Length && Char.IsDigit(text[i])) //проверка на то является ли символ цифрой и добавление чисел в строку
                {
                    num += text[i];
                    i++;
                }

                if (!String.IsNullOrEmpty(num)) //если строка не пустая, числа из строки суммируются
                {
                    sum += int.Parse(num);
                    c++; //обновление счетчика количества чисел
                }
            }
            double sr = Math.Round((sum / c), 2); //нахождение среднего арифметического и округление 
            Console.WriteLine("Среднее арифметическое равно: " + sr); 
        }
    }
}