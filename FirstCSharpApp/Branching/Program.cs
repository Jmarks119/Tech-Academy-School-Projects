using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            Console.ReadLine();

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temperature" : "It is not room temperature.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();
        }
    }
}
