using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class TestPerson
    {
        static void Main()
        {
            var person = new Person();
            person.Name = "Jim";
            person.Age = null;

            Console.WriteLine(person);
        }
    }
}
