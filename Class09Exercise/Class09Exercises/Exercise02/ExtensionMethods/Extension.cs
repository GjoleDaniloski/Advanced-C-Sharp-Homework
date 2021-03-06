using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise02.ExtensionMethods
{
    public static class Extension
    {
        public static char GetFirstLetter(this string str)
        {
            return str[0];
        }

        public static char LastLetter(this string str)
        {
            return str[str.Length - 1];
        }

        public static bool IsEven(this int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static List<T> GetNFromList<T>(this List<T> something, int num)
        {
            return something.Take(num).ToList();
        }
    }
}
