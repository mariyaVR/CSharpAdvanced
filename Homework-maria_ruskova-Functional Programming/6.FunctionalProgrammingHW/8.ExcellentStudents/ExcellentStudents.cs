namespace Students
{
    using System;    
    using System.Linq;   
   
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            var excellentStudents = StudentList.students.Where(student => student.Marks.Contains(6))
                .Select(student => new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });
            
            foreach(var student in excellentStudents)
            {
                Console.WriteLine("{0} - Marks: {1}", student.FullName, String.Join(", ", student.Marks));
            }
        }
    }
}
