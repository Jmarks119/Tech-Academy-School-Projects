using System;
using System.IO;

namespace CSharpDrill20
{
    class Program
    {
        static void Main()
        {
            StreamWriter logWriter = new StreamWriter(@"C:\Users\Jmark\Documents\Coding Projects\Sample Logs\log.txt", true);
            Console.Write("Please type in a number: ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                logWriter.WriteLine(input + "\n");
                logWriter.Close();
                StreamReader logReader = new StreamReader(@"C:\Users\Jmark\Documents\Coding Projects\Sample Logs\log.txt");
                Console.WriteLine("Here's the whole log file so far:");
                Console.Write(logReader.ReadToEnd());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only type in a whole number!");
            }
            Console.Read();
        }
    }
}
