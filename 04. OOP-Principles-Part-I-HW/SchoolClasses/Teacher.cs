using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teacher : People
    {
        // Fields
        private List<Discipline> disciplines;
        private double ratingAmongStudents;
        // Constructors
        public Teacher()
            : this("Mr. Petrov", 40, "male", new List<Discipline>(), 10.0)
        {
        }
        public Teacher(string fullName, byte age, string gender, List<Discipline> disciplines, double ratingAmongStudents)
        {
            this.Fullname = fullName;
            this.Age = age;
            this.Gender = gender;
            this.Disciplines = disciplines;
            this.RatingAmongStudents = ratingAmongStudents;
        }
        // Properties
        public List<Discipline> Disciplines { get; set; }
        public double RatingAmongStudents { get; set; }
        
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Full name: " + this.Fullname);
            result.AppendLine("Age: " + this.Age);
            result.AppendLine("Gender: " + this.Gender);
            result.AppendLine("Teaching disciplines: " + this.Disciplines.Count);
            result.AppendLine("Rating among stundents: " + this.RatingAmongStudents);
            return result.ToString();
        }
    }
}
