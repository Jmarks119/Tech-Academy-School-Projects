using System;

namespace CSharpDrill2
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your latitude purely in degrees? ");
            float userLatitude = Convert.ToSingle(Console.ReadLine());
            if (userLatitude < 23.43691f)
            {
                Console.WriteLine("You live in the tropics!");
            }
            else if (userLatitude > 66.57f)
            {
                Console.WriteLine("You live inside of the arctic or antarctic circle!");
            }
            string equatorResult = userLatitude == 0f ? "You live at the equator!" : "You don't live at the equator...";
            Console.WriteLine(equatorResult);
            Console.ReadLine();
        }
    }
}
