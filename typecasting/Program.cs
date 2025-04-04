using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TYPE CASTING--cganging the datatypes

            //IMPLICIT CASTING
            //CHAR TO INT TO LONG TO FLOAT TO DOUBLE
            int x = (int)3.5;//this is explicit casting

            Console.WriteLine(x);
            //TYPECASTING USING METHODS
            //Convert.ToDouble;
            //Convert.ToString;

            float var = Convert.ToInt32(3.44);

            string sx = "this";
            Console.WriteLine(sx);
        }
    }
}
