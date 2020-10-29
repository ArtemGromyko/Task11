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
                
        }
    }
}
