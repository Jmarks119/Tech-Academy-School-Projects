using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main()
        {

            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };


            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //string[] names = { "Jackson", "Erik", "Michael", "Allan", "Chris" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Jackson")
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Jackson", "Erik", "Michael", "Allan", "Chris" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);   
            //}
            //Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
