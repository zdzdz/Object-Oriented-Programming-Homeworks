//Problem 3. First before last

//    Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//    Use LINQ query operators.


using System;
using System.Linq;
class LinqMethodsTest
{
    static void Main()
    {
        var students = new[]
        {
            new {FirstName = "Pesho", LastName = "Peshev"},
            new {FirstName = "Gosho", LastName = "Goshev"},
            new {FirstName = "Ivan", LastName = "Ivanov"},
            new {FirstName = "Dobromir", LastName = "Enchev"},
            new {FirstName = "Svetozar", LastName = "Penov"}
        };
            

        var linqQuery =
        from student in students
        where student.FirstName.CompareTo(student.LastName) < 0
        select student;
        var extensionMethod = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
        Console.WriteLine("1. Using LINQ query:");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine(string.Join(Environment.NewLine, linqQuery));
        Console.WriteLine();
        Console.WriteLine("2. Using LINQ extension method:");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine(string.Join(Environment.NewLine, extensionMethod));
    }
}
