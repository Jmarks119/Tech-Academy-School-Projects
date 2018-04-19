using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill11
{
    class Program
    {
        static void Main()
        {
            HiddenMathVoidedParams mathObject = new HiddenMathVoidedParams();
            mathObject.TrashCompactor(69, 42);
            mathObject.TrashCompactor(displayedInteger: 119, eatenInteger: 55);
            Console.ReadLine();
        }
    }
}
