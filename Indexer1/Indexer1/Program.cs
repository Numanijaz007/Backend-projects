using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace Indexer1
{
    public class StudentMarks
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
    }

    public class School
    {
        private string[] students = new string[5];
      
        public string this[int studentId]
        {
            get
            {
                return students[studentId];
            }
            set
            {
                students[studentId] = value;
            }

        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school[0] = "Numan";
            school[1] = "Ijaz";
            Console.WriteLine(school[0]);
            Console.WriteLine(school[1]);
        }
    }
}
