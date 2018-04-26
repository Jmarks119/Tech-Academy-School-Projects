using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill18
{
    class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.Amount = 1209312098.0918209825m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
