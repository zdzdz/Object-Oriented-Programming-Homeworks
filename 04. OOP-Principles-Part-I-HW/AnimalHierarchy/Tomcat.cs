using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Animal
    {
        public Tomcat(string name, byte age)
            : base(name, age, true) { }
        
        public override void SaySomething()
        {
            Console.WriteLine("Tomcat miao, miao, miao...");
        }
    }
}
