using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.GenericMethods
{
    public class GenMethods
    {
        public void PrintList<T>(List<T> lists)
        {
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintAnimals<T>(List<T> lists) where T : Animal
        {
            foreach (var item in lists)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
