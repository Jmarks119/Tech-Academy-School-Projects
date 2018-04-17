using System;

namespace CSharpDrill1._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Is 3 greater than 2 AND 5 greater than 4?");
            Console.WriteLine(Convert.ToString(3 > 2 && 5 > 4));
            Console.WriteLine("Is 3 greater than 2 OR 5 greater than 4?");
            Console.WriteLine(Convert.ToString(3 > 2 || 5 > 4));
            Console.WriteLine("Is 2 + 2 NOT EQUAL to 4?");
            Console.WriteLine(Convert.ToString(2 + 2 != 4));
            Console.ReadLine();
        }
    }
}
