using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05.Entities
{
    public class Subscriber1
    {
        public void Sms(string str)
        {
            Console.WriteLine($"I got the message through SMS with the message: {str}");
        }
    }
}
