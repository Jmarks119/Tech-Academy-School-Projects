using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill12
{
    class MethodClass
    {
        public void TheHalver(int number)
        {
            Console.WriteLine(number / 2);
        }
        public static void TheHalver(int number, out int outNumber)
        {
            outNumber = number / 2;
        }
    }
}
