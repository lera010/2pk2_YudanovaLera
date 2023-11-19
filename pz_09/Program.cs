namespace pz_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int length = 0; //cсоответствие длине строки
            int reg = 0; //наличие символов в верхнем регистре
            int reg2 = 0; //наличие символов в нижнем регистре
            int num = 0; // наличие цифр
            int symbols = 0; //наличие спец символов
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i])) num = 1;

                if (Char.IsUpper(password[i])) reg = 1;

                if (Char.IsLower(password[i])) reg2 = 1;

                if (password[i] == '!' ||
                    password[i] == '-' ||
                    password[i] == '_' ||
                    password[i] == '.') symbols = 1;
            }

            if (password.Length > 8) length = 1;

            if (length==1 && reg==1 && reg2==1 && num==1 && symbols==1)
                Console.WriteLine("пароль соответствует требованиям");
            else
                Console.WriteLine("пароль не соответствует требованиям");
        }
    }
}