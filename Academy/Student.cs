using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Academy
{
    internal class Student : Human
    {

        string speciality;
        string group;
        double reiting;
        double attendace;

        public string Speciality { get { return speciality; } set { speciality = value; } }
        public string Group { get { return group; } set { group = value; } }
        public double Reiting { get { return reiting; } set { reiting = value; } }
        public double Attendace { get { return attendace; } set { attendace = value; } }

        public Student(string lastName, string firstName, int age,
            string speciality, string group, double reiting, double attendace) : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Reiting = reiting;
            Attendace = attendace;
            Console.WriteLine($"Aconstrustor\t{this.GetHashCode()}");


        }
        public Student(Human human, string speciality, string group, double reiting, double attendace) : base(human)
        {


        }
        ~Student()
        {
            Console.WriteLine($"Adestructor\t{this.GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Speciality}{Group}{Reiting}{Attendace}";
        }

        public Student(Student other) : base(other)
        {
            
            this.speciality = other.speciality;



            this.group = other.group;


            this.reiting = other.reiting;
            
            this.attendace=other.attendace;
        }


    }
}
