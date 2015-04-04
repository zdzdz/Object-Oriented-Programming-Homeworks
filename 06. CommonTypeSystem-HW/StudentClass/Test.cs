using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Test
    {
        static void Main()
        {
            Student student = new Student(
                "Sam",
                "Sumeragi",
                "Jones",
                569875595,
                "Yavorov 18 A",
                "0885100300",
                "sam.cool@dir.bg",
                "Software engineering",
                Specialties.Mathematics,
                Universities.SofiaUni,
                Faculties.Informatics);

            Console.WriteLine(student);

            var anotherSturdent = new Student();

            Console.WriteLine(student.Equals(anotherSturdent));
            Console.WriteLine(student.GetHashCode());

            var thirdSturdent = student.Clone();

            Console.WriteLine(thirdSturdent);
        }
    }
}
