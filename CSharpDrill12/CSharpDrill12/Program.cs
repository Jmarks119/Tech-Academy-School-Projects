using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill12
{
    class Program
    {
        static void Main()
        {
            MethodClass classObject = new MethodClass();
            Console.Write("Enter a whole number to get slashed in half: ");
            int output1;
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Write("When a MethodClass object runs TheHalver, it outputs the input divided by 2 into the console like this: ");
                classObject.TheHalver(input);
                Console.WriteLine("But when TheHalver is called with an out arguement, then it doesn't print it, and instead the out arguement gets stored");
                MethodClass.TheHalver(input, out output1);
                Console.WriteLine("Here it is! " + output1);
                Console.WriteLine("Also, TheHalver with an out arguement is static, so it can be run on the class instead of just an object of that class.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter a whole number.");
            }
            Console.ReadLine();
        }
    }
}
