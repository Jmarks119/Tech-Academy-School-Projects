using System;
using System.Collections.Generic;

namespace CSharpDrill7
{
    class Program
    {
        static void Main()
        {
            List<int> dividendList = new List<int>() { 2, 20, 50, 200, 1000, 50000, 400000, 1000000 };
            Console.WriteLine("Here comes a bunch of division!");

            try
            {
                Console.WriteLine("Please enter the divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int number in dividendList)
                {
                    Console.WriteLine(number + " divided by " + divisor + " is equal to: " + (number / divisor));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter a whole number.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Please do not enter 0");
            }
            finally
            {
                Console.WriteLine("Program ended! Have a nice day!");
                Console.ReadLine();
            }
        }
    }
}
