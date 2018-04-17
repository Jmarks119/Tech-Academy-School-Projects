using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.Read();
            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.WriteLine("Your favorite number + 5 is: " + total);
            Console.ReadLine();
        }
    }
}