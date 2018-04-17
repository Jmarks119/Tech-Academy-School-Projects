using System;

namespace CSharpDrill1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please Type in an integer: ");
            try
            {
                int multiplicationInput = Convert.ToInt32(Console.ReadLine());
                int multiplicationResult = multiplicationInput * 50;
                Console.WriteLine(Convert.ToString(multiplicationInput) + " multiplied by 50 is: " + Convert.ToString(multiplicationResult));
            }
            catch (FormatException)
            {
                Console.WriteLine("Only type characters 0-9");
            }
            Console.ReadLine();

            Console.Write("Please Type in an integer: ");
            try
            {
                int additionInput = Convert.ToInt32(Console.ReadLine());
                int additionResult = additionInput + 25;
                Console.WriteLine(Convert.ToString(additionInput) + " added to 25 is: " + Convert.ToString(additionResult));
            }
            catch (FormatException)
            {
                Console.WriteLine("Only type characters 0-9");
            }
            Console.ReadLine();

            Console.Write("Please Type in a number: ");
            try
            {
                float divisionInput = Convert.ToSingle(Console.ReadLine());
                float divisionResult = divisionInput / 12.5f;
                Console.WriteLine(Convert.ToString(divisionInput) + " divided by 12.5 is: " + Convert.ToString(divisionResult));
            }
            catch (FormatException)
            {
                Console.WriteLine("Only type characters 0-9 and .");
            }
            Console.ReadLine();

            Console.Write("Please Type in an integer: ");
            try
            {
                int booleanInput = Convert.ToInt32(Console.ReadLine());
                if (booleanInput > 50)
                {
                    Console.WriteLine(Convert.ToString(booleanInput) + " is greater than 50.");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(booleanInput) + " is not greater than 50.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Only type characters 0-9");
            }
            Console.ReadLine();

            Console.Write("Please Type in an integer: ");
            try
            {
                int moduloInput = Convert.ToInt32(Console.ReadLine());
                int moduloResult = moduloInput % 7;
                Console.WriteLine("The remainder of " + Convert.ToString(moduloInput) + " divided by 7 is: " + Convert.ToString(moduloResult));
            }
            catch (FormatException)
            {
                Console.WriteLine("Only type characters 0-9");
            }
            Console.ReadLine();
        }
    }
}
