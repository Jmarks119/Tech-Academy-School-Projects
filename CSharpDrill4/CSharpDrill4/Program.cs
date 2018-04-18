using System;

namespace CSharpDrill4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is a string. " + "This is a second string. " + "And this is a third, all concatenated.");
            Console.Write("Enter some text: ");
            string toUpperCase = Console.ReadLine();
            Console.Write("This is your text in uppercase: ");
            Console.WriteLine(toUpperCase.ToUpper());
            Console.ReadLine();

            System.Text.StringBuilder paragraph = new System.Text.StringBuilder();
            paragraph.Append("This is the first sentance of the paragraph. ");
            paragraph.Append("This is the second sentance of the paragraph, but it was added by an append method. ");
            paragraph.Append("And this is the third sentance, added once more by an append method. ");
            paragraph.Append("Having an append method demonstrates that StringBuilder objects are mutable.");
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
