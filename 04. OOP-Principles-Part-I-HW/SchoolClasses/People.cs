﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    abstract class People
    {
        // Fields
        private string fullName;
        private byte age;
        private string gender;
        // Constructors => protected in abstract classes
        protected People() { }
        protected People(string fullname, byte age, string gender)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Gender = gender;
        }
        // Properties => can be made protected in abstract classes
        protected string Fullname { get; set; }
        protected byte Age { get; set; }
        protected string Gender { get; set; }
    }
}
