// Written by Dante
// 1/15/2025

using System;
using System.Collections.Generic;

namespace FirstProjectSpring2025A
{
    public class Student
    {
        // class variables or member variables
        private int studentId = -1;
        //private string starId = "n/a";
        private string firstName = "n/a";
        private string middleName = "n/a";
        private string lastName = "n/a";
        private string major = "n/a";
        // this is meant to be freshman, sophomore, junior or senior
        // this would actually be calculated
        // private string year = "n/a";

        // Gets and Sets
        public int StudentId
        {
            // This is the bare bones get and set
            // they usually will have checks and if statements inside
            get { return this.studentId; }
            set { this.studentId = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Major
        {
            get { return this.major; }
            set { this.major = value; }
        }

        // Constuctors

        // When you have two Methods with the SAME NAME but different prameters
        // It is called Overloading

        public Student() : this(-1, "n/a", "n/a", "n/a", "undecided")   
        {
           // This is called the empty construcor
           // It is called emepty because it has no paramenters
           // it MAY have significant amounts of code
        }
        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName, string aMajor)
        {
            // This is called the full construcuotr, it has all the properties
            // this is not quite an industry standard
            // that ism not everyone would know the term full construtor
            this.StudentId = aStudentId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.MiddleName = aMiddleName;
            this.Major = aMajor;    
        }

        // This is another constructor with 4 parameters
        // Now this one doesn't have major
        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName): this(aStudentId, aFirstName, aLastName, aMiddleName, "undecided")
        {
            // This is called the full construcustor, it has all the properties
            // this is not quite an industry standard
            // that ism not everyone would know the term full construtor

            // We no loger eed this code because we are CHAINING Construcstors

            // this.StudentId = aStudentId;
            // this.FirstName = aFirstName;
            // this.LastName = aLastName;
            // this.MiddleName = aMiddleName;
            // this.Major = "undecided";
        }

        // Methods

        public override string ToString()
        {
            string message = "";
            message = message + "studentId: " + this.studentId + "\n";
            message = message + "First Name: " + this.firstName + "\n";
            message = message + "Middle Name: " + this.middleName + "\n";
            message = message + "Last Name: " + this.lastName + "\n";
            message = message + "Major: " + this.major + "\n";
            return message;
        }
    }
}

