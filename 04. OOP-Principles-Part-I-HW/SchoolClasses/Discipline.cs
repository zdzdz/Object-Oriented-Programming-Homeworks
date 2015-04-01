using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Discipline
    {
        // Fields
        private string name;
        private byte numberOfLectures;
        private byte numberOfExercies;
        // Constructors => protected in abstract classes
        public Discipline() { }
        public Discipline(string name, byte numberOfLectures, byte numberOfExercies)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercies;
        }
        // Properties => can be made protected in abstract classes
        protected string Name { get; set; }
        protected byte NumberOfLectures { get; set; }
        protected byte NumberOfExercises { get; set; }
    }
}
