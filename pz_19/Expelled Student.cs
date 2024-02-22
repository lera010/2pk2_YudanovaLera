using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_19
{
    internal class Expelled_Student : Student
    {

        public Expelled_Student(string Name, DateOnly Birth, DateOnly Entrance, string Specialization, double GPA) : base(Name, Birth, Entrance, Specialization, GPA)
        {
        }
        public override void Expulsion()
        {
            Console.WriteLine($"Студент {Name} (дата рождения: {Birth}), поступивший {Entrance} на специальность: {Specialization}, отчислен по неуспеваемости ");
            Console.WriteLine();
        }
    }
}
