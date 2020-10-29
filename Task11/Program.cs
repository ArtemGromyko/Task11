using System;
using System.Collections.Generic;
using System.Linq;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>()
            {
                new Horse("Moroccan Barb", 4, "Aidan"),
                new Dog("english setter", 3, "Corbin"),
                new Cat("australian mist", 2, "Tom"),
                new Dog("bulldog", 3, "Shetter")
            };

            Console.WriteLine("new list: ");
            var newList = from l in list
                          where l.Age % 2 == 0
                          select l;
            foreach (var n in newList)
                n.PrintInfo();

            var species = from l in list
                          select l.Species;

            Console.WriteLine("\nspecies: ");
            foreach(string s in species)
                Console.WriteLine(s);

            var sortedList = from l in list
                             orderby l.Species, l.Age
                             select l;
            Console.WriteLine("\nsorted list: ");
            foreach (var s in sortedList)
                s.PrintInfo();

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("bull terrier", 2, "George "),
                new Dog("bulldog", 3, "Damien"),
                new Dog("Damien ", 4, "Benson"),
                new Dog("bulldog", 1, "Waite"),
                new Dog("bull terrier", 3, "bull terrier")
            };

            var newDogs = from d in dogs
                          group d by d.Species;

            Console.WriteLine("\ngroup by species: ");
            foreach(IGrouping<string, Dog> g in newDogs)
            {
                foreach (var t in g)
                    t.PrintInfo();
                Console.WriteLine();
            }

            List<Dog> dogs1 = new List<Dog>()
            {
                new Dog("bull terrier", 2, "George "),
                new Dog("bulldog", 3, "Damien"),
                new Dog("Damien ", 4, "Benson"),
                new Dog("bulldog", 1, "Waite"),
                new Dog("bull terrier", 3, "bull terrier"),
                new Dog("mastiff", 5, "Benson")
            };

            var max = dogs1.Max(n => n.Age);
            Console.WriteLine("\nmax age: "+max);

            var sw = dogs1.SkipWhile(n => n.Age < 4);
            Console.WriteLine("\nskip while age < 4");
            foreach (var s in sw)
                s.PrintInfo();

            var except = dogs1.Except(dogs);
            Console.WriteLine("\nexcept: ");
            foreach (var e in except)
                e.PrintInfo();
        }
    }
}
