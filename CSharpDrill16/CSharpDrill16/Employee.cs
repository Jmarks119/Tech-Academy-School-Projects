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

        public static Boolean operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static Boolean operator!= (Employee employee1, Employee employee2)
        {
            if (employee1 == employee2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
