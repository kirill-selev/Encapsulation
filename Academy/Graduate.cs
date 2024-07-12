using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Graduate : Student
    {
        string subject;

        public string Subject { get { return subject; } set { subject = value; } }

        public Graduate(string lastName, string firstName, int age,
            string speciality, string group, double raiting, double attendace, string subject) : base(
                lastName, firstName, age, speciality, group, raiting, attendace)
        {
            Subject = firstName;


        }
        public Graduate(Student student,string subject) : base(student)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"{subject}";
        }


    }
}
