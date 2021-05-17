using System;
using System.Collections.Generic;

namespace Exercise03
{
    class Program
    {
        public static void PrintList<T>(List<T> lists)
        {
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
        }

        // Nemozev da e povrzam so klasata Animal i ja staviv vo Exercise01 

        //public void PrintAnimals<T>(List<T> lists) where T : Animal
        //{
        //    foreach (var item in lists)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //}
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "trajko", "petko", "goran" };
            List<int> intList = new List<int>() { 2, 4, 6, 8, 10 };
            List<bool> boolList = new List<bool>() { true, false, false, true };

            PrintList(stringList);
            PrintList(intList);
            PrintList(boolList);


            Console.ReadLine();
        }

        
    }
}
