using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's do even more silly math!");
            Console.Write("Type in a whole number: ");
            int input1 = 0;
            try
            {
                input1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only input a whole number");
            }
            Console.Write("Type in another whole number, or just hit enter without typing anything: ");
            string rawInput2 = Console.ReadLine();
            EvenMoreMath mathObject = new EvenMoreMath();
            try
            {
                if (rawInput2 == "")
                {
                    Console.WriteLine("Your first integer times my secret integer is: " + mathObject.SometimesMultipleParams(input1));
                }
                else
                {
                    Console.WriteLine("Your first integer times your second integer is: " + mathObject.SometimesMultipleParams(input1, Convert.ToInt32(rawInput2)));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type in only either a whole number, or nothing.");
            }
            Console.ReadLine();
        }
    }
}
