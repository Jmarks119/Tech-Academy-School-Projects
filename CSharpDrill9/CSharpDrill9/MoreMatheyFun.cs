using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill9
{
    class MoreMatheyFun
    {
        public int MathOverload(int number)
        {
            int newNumber = number % 3;
            return newNumber;
        }
        public int MathOverload(decimal number)
        {
            int newNumber = Convert.ToInt32(number * 23);
            return newNumber;
        }
        public int MathOverload(string number)
        {
            try
            {
                int newNumber = Convert.ToInt32(number) + 5;
                return newNumber;
            }
            catch (FormatException)
            {
                return 5;
            }
        }
    }
}
