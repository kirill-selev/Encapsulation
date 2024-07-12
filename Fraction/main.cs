using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class main
    {
        static void Main(string[] args)
        {

            Fraction twoAndAHalf = new Fraction(3, 4, 2);
            Fraction threeQuarters = new Fraction(0, 6, 3);

            Fraction sum = twoAndAHalf + threeQuarters;
            Console.Write("3(4/2) + (6/3) =");
            sum.Print(); //7
            Console.WriteLine();

            Fraction difference = twoAndAHalf - threeQuarters;
            Console.Write("2(1/2) - (3/4) = ");
            difference.Print(); // 3
        }
    }
}
