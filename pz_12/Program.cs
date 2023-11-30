namespace pz_12
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Введите количество цифр: ");
                int length = int.Parse(Console.ReadLine());//определение длины массива

                int[] nums = new int[length];

                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Введите цифру: ");
                    nums[i] = int.Parse(Console.ReadLine());//заполнение массива
                }
                Console.WriteLine(numsDegree2(nums));//вызов метода возвращающего количество элементов
        }

            static int numsDegree2(int[] nums)//метод возвращающий количество элементов
            {
                int countDegree = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (isDegree(nums[i]))//вызов доп метода
                    {
                        countDegree++;//увеличение счетчика
                    }
                }
                return countDegree;
            }

            
            static bool isDegree(int num)//дополнительный метод, принимающий число и возвращающий true/false в зависимости от результата.
            {
                while (num != 1)//цикл проверяющий является ли число степенью двойки
                {
                    if (num % 2 != 0)
                    {
                        return false;
                    }
                    num /= 2;
                }
                return true;
        }
        }
    }
