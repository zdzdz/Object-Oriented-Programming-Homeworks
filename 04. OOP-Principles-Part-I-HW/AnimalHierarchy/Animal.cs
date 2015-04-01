using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Animal : ISound
    {
        private byte age;
        private string name;
        private bool isMale;
        protected Animal()
            : this("Unknown species", 10, true)
        { }
        protected Animal(string name, byte age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }
        public byte Age { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        
        public override string ToString()
        {
            return string.Format("I am a {0} {1}.\nMy name is {2}.\nI'm {3} years old.",
            this.IsMale ? "male" : "female",
            this.GetType().Name,
            this.Name,
            this.Age);
        }
        
        public virtual void SaySomething()
        {
            Console.WriteLine(this.GetType().Name + " said something.");
        }
        public static decimal AverageAge(Animal[] arr)
        {
            return arr.Average(x => (decimal)x.Age);
        }
    }
}
