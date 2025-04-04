using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERATORS IN C#
            /*
            1.ARITHMETIC
            2.LOGICAL
            3.ASSIGNMENT
            4.COMPARISON
            */

            //ARITHMETIC OPERATORS
             int a = 5;
             int b=6;
             Console.WriteLine("the value of a+b is: " + (a + b));
             Console.WriteLine("the value of a-b is: " + (a - b));
             Console.WriteLine("the value of a*b is: " + (a * b));
             Console.WriteLine("the value of a/b is: " + (a / b));
             Console.WriteLine("the value of a%b is: " + (a % b));

            //ASSIGNMENT OPERATORS

            int c = 5;
            int y = c;

            y += 4;
            y *= 4;
            y -= 4;
            y /= 4;
            Console.WriteLine(b);

            //LOGICAL OPERATORS
            //AND

              Console.WriteLine(true && false);

             Console.WriteLine(true && true);

            Console.WriteLine(false && true);


            //OR

             Console.WriteLine(true || false);

            Console.WriteLine(true || true);

             Console.WriteLine(false || true);

            //COMPARISION OPERATORS
             Console.WriteLine(345 > 333);


            //MATH CLASS
            //min
            //max
            //sqrt

            int x = Math.Min(25, 34);
            Console.WriteLine(x);

        }
    }
}
