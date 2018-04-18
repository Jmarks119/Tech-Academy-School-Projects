using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int NumberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / NumberTwo;
                Console.WriteLine(numberOne + " divided by " + NumberTwo + " equals " + numberThree);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
