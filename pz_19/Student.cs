using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_19
{

    internal class Student
    {
        public string Name { get; set; }
        public DateOnly Birth {  get; set; }
        public DateOnly Entrance { get; set; }
        public string Specialization { get; set; }
        public double GPA { get; set; }
        public Student(string name, DateOnly birth, DateOnly entrance, string specialization, double gpa)
        {
            Name = name;
            Birth = birth;
            Entrance = entrance;
            Specialization = specialization;
            GPA = gpa;
        }

        public virtual void Expulsion() 
        {
            Console.WriteLine($"Студент {Name} (дата рождения: {Birth}), поступивший {Entrance} на специальность: {Specialization}, отчислен");
        }
    }
}
