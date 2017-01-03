namespace Students
{
    using System;
    using System.Linq;

    class StudentsEnrolledIn2014
    {
        static void Main(string[] args)
        {
            var studentsEnrolledIn2014 = StudentList.students.Where(student => student.FacultyNumber.EndsWith("14"));

            foreach (var student in studentsEnrolledIn2014)
            {
                Console.WriteLine("{0} {1} - Marks: {2}", student.FirstName, student.LastName, String.Join(", ", student.Marks));
            }
        }
    }
}
