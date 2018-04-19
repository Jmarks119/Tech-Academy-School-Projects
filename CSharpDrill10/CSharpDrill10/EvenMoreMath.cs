using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill10
{
    class EvenMoreMath
    {
        public int SometimesMultipleParams(int input1, int input2 = 42)
        {
            int newNumber = input1 * input2;
            return newNumber;
        }
    }
}
