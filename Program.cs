using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out numbers as below 
            Console.WriteLine(5);
            //you can also use operators right in the writeline method, ie. +-*/
            Console.WriteLine(6+5);
            //modulo operator, to get the remainder of division, use %
            Console.WriteLine(5%2);
            //BODMAS still applies, 4+2*3 gets 10, use brackets to change the order
            Console.WriteLine(4+2*3);
            //whatever you do with integers, you get an integer back
            Console.WriteLine(5/2); //you will get 2, not 2.5
            //If uou use a decimal and an integer, you always get a double
            Console.WriteLine(5/2.0); //answer is 2.5
            //can also give a number to a variable
            int num = 6;
            //can increment or decrement by 1
            num++;
            Console.WriteLine(num);
            //calling methods eg. the math method, Abs means Absolute
            //you will always get the psitive number
            Console.WriteLine(Math.Abs(-40));
            //to raise to powers
            Console.WriteLine(Math.Pow(2, 2));
            Console.Read();
        }
    }
}
