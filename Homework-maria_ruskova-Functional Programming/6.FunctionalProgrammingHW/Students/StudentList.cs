namespace Students
{
    using System;
    using System.Collections.Generic;

    public class StudentList
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Gary", "Foster", 23, "777213", "+359 877 923 671", "gfosterf@abv.bg", new List<int>() {5, 6, 4, 5}, 2),
            new Student("Sean", "Castillo", 21, "742712", "+3592 445 874", "scastillon@dot.gov", new List<int>() {3, 2, 4, 4}, 1),
            new Student("Gerald", "Diaz", 25, "776114", "+359 884 093 214", "gdiaz10@amazonaws.com", new List<int>() {6, 6, 5, 5}, 3),
            new Student("Anna", "Hernandez", 22, "709314", "+359 883 953 613", "ahernandez1i@aol.com", new List<int>() {2, 3, 2, 4}, 3),
            new Student("Marilyn", "Clark", 27, "701215", "+359 887 873 634", "mclark1t@abv.bg", new List<int>() {5, 6, 4, 5}, 2),
            new Student("William", "Garcia", 20, "723811", "02 956 34 81", "wgarcia22@marketwatch.com", new List<int>() {6, 6, 5, 6}, 1),
        };

        static void Main()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
