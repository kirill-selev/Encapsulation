using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        static readonly int SPECIALITY = 25;
        static readonly int EXPERIDE = 5;


        string speciality;
        int experide;

        public string Speciality {  get  => speciality;  set { speciality = value; } }
        public int Experide { get  => experide;  set { experide = value; } }


        public Teacher(string lastName,string firstName,int age,
            string speciality ,int experide) : base(lastName, firstName,age)
        {
            Speciality = speciality;
            Experide = experide;
        }

        public Teacher(Human human,string speciality,int experide) : base(human)
        {

            this.Speciality = speciality;
            this.Experide = experide;

        }
        public override string ToString()
        {
            return base.ToString()+$"{speciality}{experide}";
        }
    }
}
