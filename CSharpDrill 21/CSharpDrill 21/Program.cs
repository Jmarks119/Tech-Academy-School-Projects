using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill_21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("It is currently " + DateTime.Now);
            Console.Write("Please type in a number: ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                TimeSpan timeSpan = new TimeSpan(input, 0, 0);
                Console.WriteLine("In " + input + " hours it will be " + (DateTime.Now + timeSpan));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only type in a whole number!");
            }
            Console.Read();
        }
    }
}
