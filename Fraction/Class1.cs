using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {

        private int integer;
        public int Integer{get { return integer; } set { integer = value; }}
            
        int numerator;
        public int Numenator { get { return numerator; } set { numerator = value; } }

        int denominator;
        public int Denominator { get { return denominator; } set { denominator = value; } }


        public Fraction(int integer, int numerator, int denominator)
        {
            this.integer = integer; 
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public void Print()
        {
            if (numerator == 0)
            {
                Console.WriteLine(integer);
            }
            else
            {
                if (integer != 0)
                {
                    Console.Write($"{integer}({numerator}/{denominator})");
                }
                else
                {
                    Console.Write($"({numerator}/{denominator})");
                }
            }
        }

        public void SimplifyFraction()
        {
            int gcd = GreatestCommon(this.numerator, this.denominator);
            while (gcd != 1)
            {
                this.numerator /= gcd;
                this.denominator /= gcd;
                gcd = GreatestCommon(this.numerator, this.denominator);
            }
        }

        public double FractionToDouble()
        {
            return (integer * denominator + numerator) / (double)denominator;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            
            a.numerator = a.integer * a.denominator + a.numerator;
            a.integer = 0;
            b.numerator = b.integer * b.denominator + b.numerator;
            b.integer = 0;
            int newDenominator = a.denominator * b.denominator;
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newInteger = newNumerator / newDenominator;
            newNumerator = newNumerator % newDenominator;
            Fraction newFraction = new Fraction(newInteger, newNumerator, newDenominator);
            newFraction.SimplifyFraction();
            return newFraction;
        }
        public static double operator +(Fraction a, double b)
        {
            return a.FractionToDouble() + b;
        }
        public static double operator +(double b, Fraction a)
        {
            return b + a.FractionToDouble();
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            
            a.numerator = a.integer * a.denominator + a.numerator;
            a.integer = 0;
            b.numerator = b.integer * b.denominator + b.numerator;
            b.integer = 0;
            
            int newDenominator = a.denominator * b.denominator;
            int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int newInteger = newNumerator / newDenominator;
            newNumerator = newNumerator % newDenominator;
            Fraction newFraction = new Fraction(newInteger, newNumerator, newDenominator);
            newFraction.SimplifyFraction();
            return newFraction;
        }
        public static double operator -(Fraction a, double b)
        {
            return a.FractionToDouble() - b;
        }
        public static double operator -(double b, Fraction a)
        {
            return b - a.FractionToDouble();
        }






        static int GreatestCommon(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }



       
    }
    
}
