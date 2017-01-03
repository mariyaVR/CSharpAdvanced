namespace Students
{
    using System;
    using System.Linq;
    
    class WeakStudents
    {
        static void Main(string[] args)
        {
            var weekStudents = StudentList.students.Where(student => student.Marks.Count(mark => mark == 2) == 2)
                .Select(student => new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });

            foreach (var student in weekStudents)
            {
                Console.WriteLine("{0} - Marks: {1}", student.FullName, String.Join(", ", student.Marks));
            }
        }
    }
}
