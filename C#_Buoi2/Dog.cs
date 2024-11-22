using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Buoi2
{
    internal class Dog:Animal
    { 

        public Dog(String name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} is speaking Groof Groff");
        }
    }
}
