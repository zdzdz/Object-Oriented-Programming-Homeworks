using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten :Animal
    {
        public Kitten(string name, byte age)
            : base(name, age, false) { }
        
        public override void SaySomething()
        {
            Console.WriteLine("Kitty miao, miao, miao...");
        }
    }
}
