using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill15
{
    class Program
    {
        static void Main()
        {
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
