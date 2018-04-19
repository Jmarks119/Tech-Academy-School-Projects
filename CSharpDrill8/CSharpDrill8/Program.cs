using System;

namespace CSharpDrill8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, let's do a little math!");
            try
            {
                Console.Write("Please type in a whole number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number + 5 is: " + MathClass.SomeAddition(userInput));
                Console.WriteLine("Your number - 11 is: " + MathClass.SomeSubtraction(userInput));
                Console.WriteLine("Your number * 21 is " + MathClass.SomeMultiplication(userInput));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only type in a whole number.");
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
                Console.ReadLine();
            }
        }
    }
}
