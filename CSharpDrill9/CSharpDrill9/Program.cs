using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill9
{
    class Program
    {
        static void Main(string[] args)
        {
            MoreMatheyFun mathObject = new MoreMatheyFun();
            Console.WriteLine("When the MathOverload method recieves an integer it will modulo 3 it.");
            Console.WriteLine("The remainder of integer 211 divided by 3 is: " + mathObject.MathOverload(211));
            Console.WriteLine("When the MathOverload method recieves a decimal, it will multiply it by 23 and then round it to an integer.");
            Console.WriteLine("The decimal 8.0912334235902830498098123123098235 * 23 and rounded to an integer is: " + mathObject.MathOverload(8.0912334235902830498098123123098235m));
            Console.WriteLine("When the MathOverload method recieves a string, it will try to convert it to an integer, and then add 5, and simply return 5 if the conversion fails.");
            Console.WriteLine("The string 42 converted to an integer and added to 5 is: " + mathObject.MathOverload("42"));
            Console.ReadLine();
        }
    }
}
