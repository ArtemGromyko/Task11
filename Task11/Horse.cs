
using System;
using System.Collections.Generic;
using System.Text;

namespace Task11
{
    class Horse : Animal, IPet
    {
        public string Name { get; set; }
        public Horse(string s, int a, string n) : base(s, a)
        {
            Name = n;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("name: " + Name);
        }
    }
}
