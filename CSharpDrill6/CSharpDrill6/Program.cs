using System;
using System.Collections.Generic;

namespace CSharpDrill6
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[4];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write("Write some text: ");
                stringArray[i] = Console.ReadLine();
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //while (true)
            //{

            //}

            while (true)
            {
                break;
            }

            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            

            List<string> fruits = new List<string>() { "apple", "banana", "mango", "cherry", "blueberry", "strawberry" };
            Console.Write("enter the name of a fruit in lowercase to recieve that fruit's stock #: ");
            string fruitInput = Console.ReadLine();
            bool fruitFound = false;
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == fruitInput)
                {
                    Console.WriteLine("The stock # of " + fruits[i] + " is " + i);
                    fruitFound = true;
                    break;
                }
            }
            if (fruitFound == false)
            {
                Console.WriteLine("I'm afraid we don't carry " + fruitInput);
            }

            List<string> employees = new List<string>() { "bob", "bill", "kevin", "sandra", "monty", "debra", "bob", "michael", "kathy" };
            Console.Write("enter a name to recieve all the employe numbers of employees with that name: ");
            string employeeInput = Console.ReadLine();
            bool employeeFound = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] == employeeInput)
                {
                    Console.WriteLine("An employee named " + employeeInput + " has an employee number of " + i);
                    employeeFound = true;
                }
            }
            if (employeeFound == false)
            {
                Console.WriteLine("We don't have any employees named " + employeeInput + "!");
            }
            Console.ReadLine();

            List<string> weekWeather = new List<string>() { "sunny", "rainy", "rainy", "stormy", "cloudy", "sunny", "windy" };
            List<string> seenWeather = new List<string>();
            int day = 1;

            Console.WriteLine("Here's a list of all the weather for the past week:");
            foreach (string weather in weekWeather)
            {
                Console.WriteLine("On day " + day + " it was " + weather);
                if (seenWeather.Contains(weather))
                {
                    Console.WriteLine("It had already been " + weather + " that week.");
                }
                else
                {
                    seenWeather.Add(weather);
                    Console.WriteLine("It was the first time that week it had been " + weather);
                }
                day += 1;
            }

            Console.ReadLine();
        }
    }
}
