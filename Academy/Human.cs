using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Human
    {

        static readonly int last_name_width=15;
        static readonly int first_name_width = 15;
        static readonly int age_width = 5;

        string lastName;
        string firstName;
        int age;
        public string LastNme {  get=>lastName; set { lastName = value; } }
        public string FirstName { get => firstName; set { firstName = value; } }
        public int Age { get => age; set { age = value; } }

        public Human(string lastName, string firstName, int age)
        {
            LastNme = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"Hconstrustor\t{this.GetHashCode()}");
        }
        public Human(Human othert)
        {
            this.LastNme=othert.LastNme;
            this.FirstName=othert.FirstName;
            this.Age = othert.Age;
        }
         ~Human()
        {
            Console.WriteLine($"Hdestustor\t{this.GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString()+$":{lastName.PadRight(last_name_width)}{firstName.PadRight(first_name_width)}{age.ToString().PadRight(age_width)} ";
        }

    }
}
