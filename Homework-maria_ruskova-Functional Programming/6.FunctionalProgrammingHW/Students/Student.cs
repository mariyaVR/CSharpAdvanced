﻿namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, int age, string facultyNumber,
                string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return String.Format(
                "{0} {1}",
                this.FirstName,
                this.LastName);
        }
    }
}
