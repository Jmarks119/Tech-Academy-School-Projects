using System;

namespace CSharpDrill17
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Please type in the current day of the week: ");
                DayOfTheWeek day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), Console.ReadLine());
                Console.WriteLine("You put in " + day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please provide a correct day of the week. (Capitalize correctly)");
            }
            Console.ReadLine();
        }
        public enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
