using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class School
    {
        // Fields
        private string name;
        private List<SchoolClass> schoolClasses;
        private string location;
        private double rating;
        // Constructors => protected in abstract classes
        protected School() { }
        protected School(string name, string location, double rating, List<SchoolClass> schoolClasses)
        {
            this.Name = name;
            this.Location = location;
            this.Rating = rating;
            this.SchoolClasses = schoolClasses;
        }
        // Properties
        public string Name { get; set; }
        public List<SchoolClass> SchoolClasses { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
