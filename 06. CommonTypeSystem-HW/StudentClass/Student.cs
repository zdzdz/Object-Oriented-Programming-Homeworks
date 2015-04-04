using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private string course;

        public Student()
        {  
        }

        public Student(string firstName, string middleName, string lastName, int ssn, string address,
            string mobilePhone, string email, string course, Specialties specialty, Universities uni, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = uni;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name input cannot be null or empty");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name input cannot be null or empty");
                }
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name input cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public int SSN
        {
            get { return this.ssn; }
            private set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("SSN name input cannot be null or empty");
                }
                this.ssn = value;
            }
        }
        public string Address
        {
            get { return this.address; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address name input cannot be null or empty");
                }
                this.address = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email name input cannot be null or empty");
                }
                this.email = value;
            }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Mobile phone number input cannot be null or empty");
                }
                this.mobilePhone = value;
            }
        }
        public string Course
        {
            get { return this.course; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name input cannot be null or empty");
                }
                this.course = value;
            }
        }

        public Universities University { get; private set; }
        public Specialties Specialty { get; private set; }
        public Faculties Faculty { get; private set; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!this.FirstName.Equals(student.FirstName)) return false;
            if (!this.MiddleName.Equals(student.MiddleName)) return false;
            if (!this.LastName.Equals(student.LastName)) return false;
            if (!this.SSN.Equals(student.SSN)) return false;
            if (!this.MobilePhone.Equals(student.MobilePhone)) return false;
            if (!this.Address.Equals(student.Address)) return false;
            if (!this.Email.Equals(student.Email)) return false;
            if (!this.Faculty.Equals(student.Faculty)) return false;
            if (!this.Course.Equals(student.Course)) return false;
            if (!this.University.Equals(student.University)) return false;
            if (!this.Specialty.Equals(student.Specialty)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.MobilePhone.GetHashCode();
        }

        public override string ToString()
        {
            int signs = 30;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(new string('=', signs)));
            sb.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName ?? "<unnamed>", this.MiddleName, this.LastName));
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Mobile Phone: " + this.MobilePhone);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("Speciality: " + this.Specialty);
            sb.AppendLine("University: " + this.University);
            sb.AppendLine("Faculty: " + this.Faculty);
            sb.AppendLine(string.Format(new string('=', signs)));
            return sb.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone,
                               this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo((other as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((other as Student).FirstName);
            }
            if (this.MiddleName.CompareTo((other as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((other as Student).MiddleName);
            }
            if (this.LastName.CompareTo((other as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((other as Student).LastName);
            }
            if (this.SSN.CompareTo((other as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((other as Student).SSN);
            }
            return 0;
        }
    }
}
