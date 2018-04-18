using System;

namespace CSharpDrill3
{
    class Program
    {
        static void Main()
        {
            int number = 23;
            while (number > 0)
            {
                Console.WriteLine(Convert.ToString(number));
                number -= 1;
            }
            Console.ReadLine();

            int inputNumber = 0;
            do
            {
                Console.WriteLine("You're trapped in a loop! Type in the correct number to escape:");
                inputNumber = Convert.ToInt32(Console.ReadLine());
            } while (inputNumber != 23);
        }
    }
}
