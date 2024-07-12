//#define INEHERETENSE_1
#define INEHERETENSE_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
    internal class Academy
    {
        static void Main(string[] args)
        {

#if INEHERETENSE_1
            Human human = new Human("Vercetti", "Tommy", 30);
            Console.WriteLine(human);


            Student student = new Student("Pinkman", "Jassie", 22, "Chemerstry", "WW_220", 67, 98);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("ABOBA", "sie", 22, "Chemerstry", 20);
            Console.WriteLine(teacher);


            //Graduate graduate = new Graduate("","",2,",",2,2,"");  
#endif


            //Human human = new Human("Krill", "BOT", 30);
            //Student student = new Student(human, "theft", "Vice", 94, 95);

            StreamWriter write = new StreamWriter("group.txt");
            write.Close();
            string cmd = "group.txt";
            System.Diagnostics.Process.Start("notepad",cmd);

        }
        
        

    }
}
