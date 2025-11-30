using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace indexer2
{
    internal class Program
    {
        public class StudentMarks
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public string Subject { get; set; }
            public int Marks { get; set; }
        }


        public class Student
        {
            private List<StudentMarks> studentsMarks;
            public Student()
            {
                studentsMarks = new List<StudentMarks>();
                studentsMarks.Add(new StudentMarks() { StudentId = 1 , Name = "Numan Ijaz" , Subject = "Programming" , Marks = 78});
                studentsMarks.Add(new StudentMarks() { StudentId = 2 , Name = "Ubad" , Subject = "DSA" , Marks = 80});
                studentsMarks.Add(new StudentMarks() { StudentId = 3 , Name = "Abdul Sami" , Subject = "OOP" , Marks = 85});
                studentsMarks.Add(new StudentMarks() { StudentId = 4 , Name = "Abdul Moiz" , Subject = "ICT" , Marks = 71});
            }

            public string this[int index]
            {
                get
                {
                    return studentsMarks.FirstOrDefault(std => std.StudentId == index).Name;
                }
                set
                {
                    studentsMarks.FirstOrDefault(std => std.StudentId == index).Name = value;
                }
                
            }
        }
        static void Main(string[] args)
        {

           Student student = new Student();
           string userInput = Console.ReadLine();
           Console.WriteLine("Students ID : " + student[1]);
           Console.WriteLine("Students ID : " + student[1]);
           Console.WriteLine("Students ID : " + student[2]);
           Console.WriteLine("Students ID : " + student[3]);
           Console.WriteLine("Students ID : " + student[4]);

        }
    }
}
