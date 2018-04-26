using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill16
{
    class Program
    {
        static void Main()
        {
            Employee<String> SampleEmployee = new Employee<string>
            {
                FirstName = "Sample",
                LastName = "Sampleson",
                things = new List<string> { "stuff", "and", "things" }
            };
            Employee<int> MathEmployee = new Employee<int>
            {
                FirstName = "Math",
                LastName = "Matherson",
                things = new List<int> { 2, 2, 5 }
            };
        }
    }
}