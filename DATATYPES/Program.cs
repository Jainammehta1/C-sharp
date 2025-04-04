using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            DATA TYPES in c#:
             integer- int jainam; -- 4 bytes
            floating point number- float this; --4 bytes
            character- char a='A';-- 2 bytes
            boolean- bool isgreat=true; --1 bit
            string- string inp="jainam"; 2 bytes per character
            long int---8 bytes
            double float---8 bytes and 15 decimal precisions
            
             */


            //string inp=Console.ReadLine();
            //Console.WriteLine(inp);


            //DATA TYPES EXAMPLE

            int a = 34;
            float b = 34.4F;
            double c = 34.4;
            bool isgreat=false;
            char d = 'A';
            string e = "this is a string";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isgreat);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
