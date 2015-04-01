using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        // Fields
        private double grade;
        // Constructors
        public Student()
            : this("Gosho", "Goshov", 2.49)
        {
        }
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        // Properties
        public double Grade { get; set; }
        
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("First name: {0}\n", FirstName);
            result.AppendFormat("Last name: {0}\n", LastName);
            result.AppendFormat("Grade: {0}\n", Grade);
            return result.ToString();
        }
    }
}
