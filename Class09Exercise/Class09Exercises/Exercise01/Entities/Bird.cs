using Exercise01.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entities
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }

        public Bird() { }

        public Bird(bool isWild, string name, int age, string color)
            :base(name, age, color)
        {
            IsWild = isWild;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is the bird wild? - {IsWild}");
        }

        public void FlySouth()
        {
            if (IsWild)
            {
                Console.WriteLine("Flying South");
            }
            else
            {
                Console.WriteLine("Domesticated Bird");
            }
        }
    }
}
