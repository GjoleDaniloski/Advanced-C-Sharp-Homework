using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05.Entities
{
    public class Subscriber2
    {
        public void Email(string str)
        {
            Console.WriteLine($"I got the message through Email with the message: {str}"));
        }
    }
}
