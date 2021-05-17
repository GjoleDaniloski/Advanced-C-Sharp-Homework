using Exercise02.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string workWithString = "C# Advanced is a great subject with great demo code and cool activities!";
            int someNumber = 9;
            List<int> numbers = new List<int> { 20, 4, 6, 9, 38 };

            Console.WriteLine(Extension.GetFirstLetter(workWithString));
            Console.WriteLine(Extension.LastLetter(workWithString)); Extension.LastLetter(workWithString);
            Console.WriteLine(Extension.IsEven(someNumber));
            Console.WriteLine(Extension.GetNFromList(numbers, 20)); 

            Console.ReadLine();
        }
    }
}
