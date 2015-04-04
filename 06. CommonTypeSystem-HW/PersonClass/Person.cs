using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person()
        {
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.age != null)
            {
                sb.AppendLine(string.Format("Name: {0}", this.Name));
                sb.AppendLine(string.Format("Age: {0}", this.Age));
            }
            else
            {
                sb.AppendLine(string.Format("Name: {0}", this.Name));
                sb.AppendLine(string.Format("Age: <unknown>"));
            }

            return sb.ToString();
        }
    }
}
