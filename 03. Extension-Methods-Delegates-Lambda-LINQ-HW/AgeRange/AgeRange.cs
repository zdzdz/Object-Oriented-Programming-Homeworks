//Problem 4. Age range

//    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


using System;
using System.Linq;
class AgeRange
{
    static void Main()
    {
        var students = new[]
        {
            new {FirstName = "Filip", LastName = "Georgiev", Age = 19},
            new {FirstName = "Dimityr", LastName = "Cvetkov", Age = 18},
            new {FirstName = "Cvetelina", LastName = "Dimitrova", Age = 25},
            new {FirstName = "Boris", LastName = "Angelov", Age = 22},
            new {FirstName = "Angel", LastName = "Borisov", Age = 17}
        };

        var sortedStudents =
        from student in students
        where student.Age >= 18 && student.Age <= 24
        select student;
        Console.WriteLine("1. Using LINQ query:");
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));
        Console.WriteLine();
    }
}