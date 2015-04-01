using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, byte age, bool isMale)
            : base(name, age, isMale) { }
        
        public override void SaySomething()
        {
            Console.WriteLine("Rabbit, rabbit, rabbit...");
        }
    }
}
