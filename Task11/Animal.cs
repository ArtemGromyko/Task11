using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    abstract class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public Animal() { }
        public Animal(string s, int a)
        {
            Species = s;
            Age = a;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("species: " + Species + " age: " + Age);
        }
    }
}
