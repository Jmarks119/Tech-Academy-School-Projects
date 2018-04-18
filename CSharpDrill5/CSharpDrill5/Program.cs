using System;
using System.Collections.Generic;

namespace CSharpDrill5
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "first", "second", "third", "fourth", "fifth", "sixth" };
            try
            {
                Console.WriteLine("Type an integer between 0 and 5 to recieve the value at that index.");
                int inputStringArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stringArray[inputStringArray]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number must be between 0 and 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must type an integer.");
            }
            Console.ReadLine();
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            try
            {
                Console.WriteLine("Type an integer between 0 and 5 to recieve the value at that index.");
                int inputIntegerArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intArray[inputIntegerArray]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number must be between 0 and 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must type an integer.");
            }
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.AddRange(stringArray);
            try
            {
                Console.WriteLine("Type an integer between 0 and 5 to recieve the value at that index.");
                int inputStringList = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stringList[inputStringList]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number must be between 0 and 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must type an integer.");
            }
            Console.ReadLine();
        }
    }
}
