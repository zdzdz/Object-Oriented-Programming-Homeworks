using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        // Fields
        private string firstName;
        private string lastName;
        // Constructors
        protected Human()
            : this("Unknown", "Unknown")
        {
        }
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
