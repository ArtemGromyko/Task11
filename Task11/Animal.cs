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
        public override bool Equals(object obj)
        {
            if (!(obj is Animal))
                return false;
            Animal a = (Animal)obj;
            if (this.Age != a.Age)
                return false;
            else if (this.Species != a.Species)
                return false;
            else
                return true;
        }
        public override int GetHashCode()
        {
            return Species.GetHashCode();
        }
    }
}
