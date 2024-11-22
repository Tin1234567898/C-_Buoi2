using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Buoi2
{
    internal class Cat:Animal
    {
        public Cat(String name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} is speaking Mew Mew");
        }
    }
}
