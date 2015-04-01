using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Test
    {
        static void Main()
        {
            var newSchoolClass = new SchoolClass();
            Console.WriteLine(newSchoolClass);
            var newStudent = new Student();
            Console.WriteLine(newStudent);
            var newTeacher = new Teacher();
            Console.WriteLine(newTeacher);
        }
    }
}
