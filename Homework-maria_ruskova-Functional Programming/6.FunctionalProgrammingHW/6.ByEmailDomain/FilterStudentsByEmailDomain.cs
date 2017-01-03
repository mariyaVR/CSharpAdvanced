namespace Students
{
    using System;
    using System.Linq; 

    class FilterStudentsByEmailDomain
    {
        static void Main(string[] args)
        {
            var studentsWithAbvEmail = StudentList.students.Where(student => student.Email.Contains("abv.bg"));

            foreach(var student in studentsWithAbvEmail)
            {
                Console.WriteLine("{0} {1} - Email: {2}", student.FirstName, student.LastName, student.Email);
            }
        }
    }
}
