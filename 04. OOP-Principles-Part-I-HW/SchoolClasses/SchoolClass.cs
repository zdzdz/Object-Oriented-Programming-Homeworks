﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class SchoolClass
    {
        // Fields
        private List<Student> students;
        private List<Teacher> teachers;
        private string textID;
        // Constructors
        public SchoolClass()
            : this("A", new List<Student>(), new List<Teacher>())
        {
        }
        public SchoolClass(string textID, List<Student> students, List<Teacher> teachers)
        {
            this.TextID = textID;
            this.Students = students;
            this.Teachers = teachers;
        }
        // Properties
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string TextID { get; set; }
        // Methods
        public double GetAverageNote()
        {
            int stundentsCount = Students.Count;
            return this.Students.SelectMany(student => student.Notes).Sum() / stundentsCount;
        }
        
        
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Class unique text identifier: {0}\n", TextID);
            result.AppendFormat("Number of students in class: {0}\n", Students.Count);
            return result.ToString();
        }
        
    }
}
