using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Buoi2
{
    internal class Animal
    {
        public String Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking: ");
        }
    }
}
