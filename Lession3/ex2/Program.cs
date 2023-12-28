using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
        new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 } ,
        new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };
                IList<Standard> standardList = new List<Standard>() {
        new Standard(){ StandardID = 1, StandardName="Standard 1"},
        new Standard(){ StandardID = 2, StandardName="Standard 2"},
        new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
        Console.WriteLine("Multiple Select and where Operator");
        var studentNames = studentList.Where(s => s.Age > 18)
        .Select(s => s)
        .Where(st => st.StandardID > 0)
        .Select(s => s.StudentName);

        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("Select teen age");
        var teenStudentsName = from s in studentList
                               where s.Age > 12 && s.Age < 20

                               select new { StudentName = s.StudentName };

        teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
        Console.WriteLine("Query returns list students group by StandardID");
        var studentsGroupByStandard = from s in studentList
                                      group s by s.StandardID into sg
                                      orderby sg.Key

                                      select new { sg.Key, sg };

        foreach (var group in studentsGroupByStandard)
        {
            Console.WriteLine("StandardID {0}:", group.Key);
            foreach (var Item in group.sg)
            {
                Console.WriteLine(Item.StudentName);
            }
        }

        Console.WriteLine("List of students by ascending order of StandardID and Age.");
        var sortedStudents = from s in studentList
                             orderby s.StandardID, s.Age
                             select new
                             {
                                 StudentName = s.StudentName,
                                 Age = s.Age,
                                 StandardID = s.StandardID
                             };
        sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: { 1}, StandardID: { 2} ", s.StudentName, s.Age, s.StandardID));
        Console.WriteLine("Nested Query");
        var nestedQueries = from s in studentList
                            where s.Age > 18 && s.StandardID ==
                            (from std in standardList
                             where std.StandardName ==
                            "Standard 1"
                             select std.StandardID).FirstOrDefault()
                            select s;
        nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));
    }
}
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }
        }
        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }