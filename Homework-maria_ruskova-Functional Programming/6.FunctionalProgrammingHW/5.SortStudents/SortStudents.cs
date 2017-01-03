namespace Students
{
    using System;
    using System.Linq;

    class SortStudents
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Query:\n");

            var sortedStudents = from student in StudentList.students
                                 orderby student.FirstName descending,
                                 student.LastName descending
                                 select student;

            foreach(var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nLinq extension method:\n");

            var sortedStudents2 = StudentList.students.OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            foreach(var student in sortedStudents2)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
