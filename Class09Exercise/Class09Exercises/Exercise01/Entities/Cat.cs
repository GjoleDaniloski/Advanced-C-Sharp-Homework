using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entites
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat() { }

        public Cat(bool isLazy, string name, int age, string color)
            : base(name, age, color)
        {
            IsLazy = isLazy;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is the cat lazy? - {IsLazy}");
        }

        public void Meow()
        {
            Console.WriteLine("MEOW MEOW");
        }
    }
}
