using System;

namespace MoreStrings
{
    class Program
    {
        static void Main()
        {
            string name = "Jackson";
            string quote = "The man said, \"Hello\", Jackson. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = @"C:\Users\Jackson";

            bool contains = name.Contains("k");
            int length = name.Length;
            string lowerName = name.ToLower();

            Console.WriteLine(quote);
            Console.ReadLine();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("My name is Jackson.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
