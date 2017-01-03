namespace Students
{
    using System;
    using System.Linq;

    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            var firstBeforeLastName = from student in StudentList.students
                                      where student.FirstName.CompareTo(student.LastName) < 0
                                      select student;

            foreach(var student in firstBeforeLastName)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
