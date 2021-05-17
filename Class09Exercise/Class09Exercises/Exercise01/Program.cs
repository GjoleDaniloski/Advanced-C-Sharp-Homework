using Exercise01.Entites;
using Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        public void PrintAnimals<T>(List<T> lists) where T : Animal
        {
            foreach (var item in lists)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====== Dog ======");
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Staford","Ajs", 2, "black"),
                new Dog("Terrier", "Lordi", 3, "black"),
                new Dog("Chi Chi", "Baron", 5, "brown" )
            };

            Console.WriteLine("====== Cat ======");
            List<Cat> cats = new List<Cat>
            {
                new Cat(true, "Lea", 2, "white"),
                new Cat(false, "Luna", 3, "black"),
                new Cat(true, "Lily", 4, "white" )
            };

            Console.WriteLine("====== Bird ======");
            List<Bird> birds = new List<Bird>
            {
                new Bird(true, "Pikachu", 1, "yellow"),
                new Bird(false, "Charlie", 1, "grey"),
                new Bird(true, "Coco", 4, "white" )
            };

            Console.WriteLine("====== Linq ======");

            List<Dog> allDogs = dogs
                                .Where(x => x.Breed == "Staford")
                                .ToList();
            Console.WriteLine("Staford dogs is:");
            allDogs.ForEach(x => Console.WriteLine(x.Name));

            Cat lastLAzyCat = cats
                              .Where(x => x.IsLazy == true)
                              .LastOrDefault();
            Console.WriteLine("Lazy cat is: ");
            Console.WriteLine(lastLAzyCat.Name);

            List<Bird> getBirds = birds
                                  .Where(x => x.Age < 3)
                                  .OrderBy(y => y.Name)
                                  .ToList();
            Console.WriteLine("Bird younger than 3 ordered by name is:");
            getBirds.ForEach(x => Console.WriteLine(x.Name));

            Console.ReadLine();
        }
    }
}
