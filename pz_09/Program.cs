namespace pz_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int length = 0; 
            int reg = 0; 
            int reg2 = 0; 
            int num = 0; 
            int symbols = 0; 
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i])) //проверка на наличие цифр
                    num = 1;

                if (Char.IsUpper(password[i])) //проверка на наличие верхнего регистра
                    reg = 1;

                if (Char.IsLower(password[i])) //проверка на наличие нижнего регистра
                    reg2 = 1;

                if (password[i] == '!' || password[i] == '-' || password[i] == '_' || password[i] == '.') //проверка на наличие символов
                    symbols = 1;
            }

            if (password.Length > 8) //проверка на длину пароля
                length = 1;

            if (length==1 && reg==1 && reg2==1 && num==1 && symbols==1)
                Console.WriteLine("пароль соответствует требованиям");
            else
                Console.WriteLine("пароль не соответствует требованиям");
        }
    }
}