using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill13
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sampleEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };
            sampleEmployee.SayName();
            Console.ReadLine();
        }
    }
}
