using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill15
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: [{0} {1}]", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Exiting now...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
