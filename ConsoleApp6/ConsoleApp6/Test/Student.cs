using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Test
{
    public class Student
    {
        public Student()
        {
            
        }

        public Student(string firstName,string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
            //return $"{firstName} {lastName}";
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void Printname()
        {
            Console.WriteLine("Test print name");
        }

        public string GetInfo()
        {
            return "I am from the Student class";
        }
    }

    public class Person
    {
        public string GetInfo()
        {
            return "I am from the Person class";
        }
    }
}
