namespace Students
{
    using System;
    using System.Linq;

    class StudentsByGroup
    {
        static void Main(string[] args)
        {
            var studentsByGroup = from student in StudentList.students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName
                                  select student;

            foreach (var student in studentsByGroup)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
        }
    }
}
