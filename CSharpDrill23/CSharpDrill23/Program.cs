using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            try
            {
                int userAge = (Convert.ToInt32(Console.ReadLine()));
                if (userAge < 1) throw new ArgumentOutOfRangeException();
                DateTime birthYear = DateTime.Now.AddYears(-userAge);
                Console.WriteLine("You must have been born in " + birthYear.Year + " if you were born on or before today's date, or " + birthYear.AddYears(-1).Year + " if you were born after.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You must enter a number above 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter only a whole number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error has occured.");
            }
            Console.ReadLine();
        }
    }
}
