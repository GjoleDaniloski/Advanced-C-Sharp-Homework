using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Entites
{
    public abstract class Animal
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 175)
                {
                    Console.WriteLine("Age cannot be below 0 or more than 175.Please try again!");
                    return;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string Color { get; set; }

        public Animal()
        {

        }
        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public abstract void Print();
    }
}
