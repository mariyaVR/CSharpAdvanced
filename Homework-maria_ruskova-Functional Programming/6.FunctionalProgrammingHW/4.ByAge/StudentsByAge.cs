namespace Students
{
    using System;
    using System.Linq;

    class StudentsByAge
    {
        static void Main(string[] args)
        {
            var studentsInAgeGroup = from student in StudentList.students
                                     where student.Age > 17 && student.Age < 25
                                     select student;

            foreach(var student in studentsInAgeGroup)
            {
                Console.WriteLine("{0} {1} - Age: {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
