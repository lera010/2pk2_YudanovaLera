namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу: ");
            string directoryPath = Console.ReadLine();//ввод пути к каталогу
            if (Directory.Exists(directoryPath))//проверка на существование каталога
            {
                string[] files = Directory.GetFiles(directoryPath);//добавление названий файлов в массив
                foreach (var file in files)//перебор каждого файла из массива
                {
                    if (isKirill(file))//вызов метода 
                        Console.WriteLine(Path.GetFileName(file));//вывод имени файла, если результат метода true
                }
            }
            else
                Console.WriteLine("Указанного каталога не существует или путь к каталогу указан неверно");
        }
        static bool isKirill(string text)//метод для проверки символов
        {
            foreach (char c in text)//перебор каждого символа в названии файла
            {
                if ((c >= 0x0400 && c <= 0x04FF) || (c >= 0x0500 && c <= 0x052F))//проверка являются ли они символами кириллицы согласно их номеру в таблице юникод 
                {
                    return true;
                }
            }
            return false;

        }
    }
    }
}