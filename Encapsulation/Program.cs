using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            A.ToString();
            A.SetX(5);A.SetY(2);
            Console.WriteLine($"Y={A.GetY()}\t X={A.GetX()}");
        }


        struct Point
        {
            double x;
            double y;
            public double GetX() { return x; }
            public double GetY() { return y; }

            public void SetX(double x) {this.x = x; }
            public void SetY(double y) {this.y = y; }
            public double Y { get { return y; } set { this.y = value; } }
            public double X { get { return x; } set { this.x = value; } }
        }
    }
}
/*
private.закрытые поля, доступны только внутри класса;

public: открытые поля, доступны в любом месте как в пределах данной сборки, так и за ее пределами;
protected: защищенные поля, достудны внутри класса, и его дочерних классов;
internal: эти поля доступны где угодно в пределах данной сборки;
protocted internal: защищенный внутренние поля, доступны как в классе, таки в его дочерних классах в пределах данной сборки;*/
