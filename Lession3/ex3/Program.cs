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
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 },
        new Student() { StudentID = 6, StudentName = "Peter" , Age = 17 }};

        Console.WriteLine("Count() method");
        var totalStudents = studentList.Count();
        Console.WriteLine("---Total Students: {0}", totalStudents);
        var adultStudents = studentList.Count(s => s.Age >= 18);
        Console.WriteLine("---Number of Adult Students: {0}", adultStudents);
        Console.WriteLine("Max() method");
        var oldest = studentList.Max(s => s.Age);
        Console.WriteLine("---Oldest Student Age: {0}", oldest);
        Console.WriteLine("Sum() method");
        var sumOfAge = studentList.Sum(s => s.Age);
        Console.WriteLine("---Sum of all student's age: {0}", sumOfAge);
        var numOfAdults = studentList.Sum(s => {
            if (s.Age >= 18)
                return 1;
            else
                return 0;
        });
        Console.WriteLine("---Total Adult Students: {0}", numOfAdults);
        Console.WriteLine("Agerage method");
        var avgAge = studentList.Average(s => s.Age);
        Console.WriteLine("---Average Age of Student: {0}", avgAge);
        Console.WriteLine("OrderBy");
        var orderByResult = from s in studentList
                            orderby s.StudentName //Sorts the studentList collection in ascending order
                            select s;
        var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
        orderby s.StudentName descending
        select s;
        Console.WriteLine("---Ascending Order:");
        foreach (var std in orderByResult)
            Console.WriteLine(std.StudentName);
        Console.WriteLine("---Descending Order:");
        foreach (var std in orderByDescendingResult)
            Console.WriteLine(std.StudentName);

    }
}
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }