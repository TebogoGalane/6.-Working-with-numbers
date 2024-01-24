using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can just print numbers below
            Console.WriteLine(5);
            //you can also use operators right in writeline method ie + - * /
            Console.WriteLine(6 + 5);
            //module operators, to get the reminder of division, use %
            Console.WriteLine(5 % 2);
            //BODMAS still applies 
            Console.WriteLine(4 + 2 * 5);
            // whatever you do just with integer, you get integer back
            Console.WriteLine(5 / 2); //you get 2 not 2.5
            //if you use a decimal and an integer you always get a double
            Console.WriteLine(5 / 2.0); //you get 2.5
            //can also give a number to a variable
            int num = 6;
            //con increment or decrement by 1
            num++;
            Console.WriteLine(num);
            //calling method e.g the math method, abs means absolute
            //you will always get the positive number
            Console.WriteLine(Math.Abs(-40));
            //to raise to powers
            Console.WriteLine(Math.Pow(2, 2));

            Console.Read();

        }
    }
}
