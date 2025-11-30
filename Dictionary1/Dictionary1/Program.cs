using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Dictionary1
{
    public class Students
    {
        public int ID { get; set; }
        public int Marks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var students = new Dictionary<int, int>
            {
                {101, 90},
                {102, 80},
                {103, 88},
                {104, 96},
                {105, 78},
            };

            int studentid1 = 101; 
            int studentid2 = 102; 
            int studentid3 = 103; 
            int studentid4 = 104; 
            int studentid5 = 105;

            Console.Write("Enter Student Id to check marks : ");
            int id = int.Parse(Console.ReadLine());
            if (studentid1 == id)
            {
                Console.WriteLine($"Student Marks : {students[id]}");
            }
            else if (studentid2 == id)
            {
                Console.WriteLine($"Student Marks : {students[id]}");
            }
            else if (studentid3 == id)
            {
                Console.WriteLine($"Student Marks : {students[id]}");
            }
            else if (studentid4 == id)
            {
                Console.WriteLine($"Student Marks : {students[id]}");
            }
            else if (studentid5 == id)
            {
                Console.WriteLine($"Student Marks : {students[id]}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }

           


           
            
        }
        
    }
}
