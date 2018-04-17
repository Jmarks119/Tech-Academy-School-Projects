using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();
            int othertotal = 12 + 22;
            int combined = total + othertotal;
            Console.WriteLine("That, plus another number is: " + combined.ToString());
            Console.ReadLine();

            int difference = 12 - 5;
            Console.WriteLine("Twelve minus five is: " + difference.ToString());
            Console.ReadLine();

            int product = 20 * 4;
            Console.WriteLine("Twenty times Four is: " + product.ToString());
            Console.ReadLine();

            double quotient = 60.0 / 7.0;
            Console.WriteLine("Sixty divided by Seven is: " + quotient.ToString());
            Console.ReadLine();

            int remainder = 23 % 4;
            Console.WriteLine("The remainder of 23 divided by 4 is: " + remainder.ToString());
            Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.WriteLine("Is 12 less than 5?: " + trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
