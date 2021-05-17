using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entites
{
    public class Dog : Animal
    {

        public string Breed { get; set; }

        public Dog() { }

        public Dog(string breed, string name, int age, string color)
            :base(name, age, color)
        {
            Breed = breed;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }

        public void Bark()
        {
            Console.WriteLine("BARK BARK");
        }
    }
}
