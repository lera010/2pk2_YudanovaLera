using System.Globalization;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graduate_Student student1 = new Graduate_Student("Иван Иванов", new DateOnly(2000, 02, 08), new DateOnly(2020, 09, 01), "автомеханик", 4.6);
            student1.Expulsion();

            Expelled_Student student2 = new Expelled_Student("Петр Петров", new DateOnly(2001, 02, 08), new DateOnly(2019, 09, 01), "программист", 2.3);
            student2.Expulsion();

            Academic_Leave_Student student3 = new Academic_Leave_Student("Иван Петров", new DateOnly(2002, 02, 08), new DateOnly(2021, 09, 01), "гостиничное дело", 4.9);
            student3.Expulsion();

            Graduate_Student student4 = new Graduate_Student("Петр Иванов", new DateOnly(2001, 10, 05), new DateOnly(2020, 09, 01), "мед. сестра", 3.8);
            student4.Expulsion();

            Graduate_Student student5 = new Graduate_Student("Касаткина Анастасия", new DateOnly(2003, 03, 12), new DateOnly(2020, 09, 01), "земельно имущественные отношения", 4.6);
            student5.Expulsion();

            Expelled_Student student6 = new Expelled_Student("Петрова Алена", new DateOnly(2000, 07, 25), new DateOnly(2020, 09, 01), "правоохранительная деятельность", 2.4);
            student6.Expulsion();

            Graduate_Student student7 = new Graduate_Student("Иванова Алена", new DateOnly(2000, 05, 23), new DateOnly(2020, 09, 01), "туризм", 4.6);
            student7.Expulsion();

            Graduate_Student student8 = new Graduate_Student("Пушкин Александр", new DateOnly(2000, 11, 09), new DateOnly(2020, 09, 01), "звукооператорское мастерство", 4.6);
            student8.Expulsion();

            Graduate_Student student9 = new Graduate_Student("Пушкина Евгения", new DateOnly(2000, 01, 01), new DateOnly(2020, 09, 01), "анимация", 4.6);
            student9.Expulsion();

            Graduate_Student student10 = new Graduate_Student("Тургенева Мария", new DateOnly(2000, 04, 16), new DateOnly(2020, 09, 01), "реклама", 4.6);
            student10.Expulsion();
        }
    }
}
