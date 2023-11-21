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
            
            /*while (i < text.Length)
            {
                string num = "";

                while (i < text.Length && Char.IsDigit(text[i]))
                {
                    num += text[i];
                    i++;
                }

                if (!String.IsNullOrEmpty(num))
                {
                    sum += int.Parse(num);
                    c++;
                }
                i++;
            }
            double sr = Math.Round((sum / c), 2);
            Console.WriteLine("Среднее арифметическое равно: " + sr);*/




            for (int i = 0; i < text.Length; i++)
            {   string num = "";
                while (i < text.Length && Char.IsDigit(text[i]))
                {
                    num += text[i];
                    i++;
                }
                if (!String.IsNullOrEmpty(num))
                {
                    sum += int.Parse(num);
                    c++;
                }
                Console.WriteLine( num);
            }
            double sr = Math.Round((sum / c), 2);
            Console.WriteLine("Среднее арифметическое равно: " + sr); 


        }
    }
}