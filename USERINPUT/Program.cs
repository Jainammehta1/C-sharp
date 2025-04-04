using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USERINPUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("my name is" +name);
            Console.WriteLine("how many candies do you want");
            string can=Console.ReadLine();
            Console.WriteLine("you will get 4 more candies" +
            (Convert.ToInt32(can) + 4));
        }
    }
}
