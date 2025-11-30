using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp7
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Add(2);
            //Add(2,3);
            //NewMethod(1, 2);
            //MyTestMethod(1, 2);


            Dictionary<string,string> englishDictionary=new Dictionary<string,string>();
            englishDictionary["Brave"] = "A person who don't fear.";
            englishDictionary["Disgusting"] = "sample test value";

            Console.WriteLine( string.Join(",", englishDictionary.Keys.ToList()));
            Console.WriteLine(string.Join(",", englishDictionary.Values.ToList()));



            //Dictionary<string, Student> studentsData = new Dictionary<string, Student>();
            //Student salman = new Student();
            //salman.FirstName = "Salman";
            //salman.LastName = "Rasheed";
            //salman.Email = "salman14948@gmail.com";
            //studentsData["salman"] = salman;

            //Student ib = new Student();
            //ib.FirstName = "test";
            //ib.LastName = "name";
            //ib.Email = "test@gmail.com";
            //studentsData.Add("test",ib);

            //var info = studentsData["salman"];
            //Console.WriteLine("First Name:" + info.FirstName + " Last Name:" + info.LastName + " Email:" + info.Email);


            if (englishDictionary.ContainsKey("Disgustings"))
            {
                var dd = englishDictionary["Disgustings"];
                Console.WriteLine(dd);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }


        public static void Add(int a ,int b)
        {
            Console.WriteLine("test:"+a+b);
        }

        public static void Add(int a)
        {
            Console.WriteLine("test:" + a );
        }


        public static void MyTestMethod(int a, int b, int c=0)
        {
        }

        public static void NewMethod(int a, int b,[Optional] int c)
        {
        }

    }
}
