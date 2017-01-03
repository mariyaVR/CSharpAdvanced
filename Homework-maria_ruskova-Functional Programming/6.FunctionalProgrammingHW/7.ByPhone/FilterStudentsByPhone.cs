namespace Students
{
    using System;
    using System.Linq;

    class FilterStudentsByPhone
    {
        static void Main(string[] args)
        {
            var studentsByPhone = StudentList.students.Where(student => student.Phone.StartsWith("02") ||
            student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2"));

            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("{0} {1} - Phone: {2}", student.FirstName, student.LastName, student.Phone);
            }
        }
    }
}
