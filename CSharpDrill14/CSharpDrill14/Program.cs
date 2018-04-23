using System;

namespace CSharpDrill14
{
    class Program
    {
        static void Main()
        {
            Employee sampleEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };
            sampleEmployee.SayName();
            Console.ReadLine();
        }
    }
}
