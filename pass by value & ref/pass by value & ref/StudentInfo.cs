using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value___ref1
{
    public class StudentInfo
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public void NameFun(string name)
        {
            Name = name.ToLower();
        }
        public void MarkFun(int marks)
        {
            Marks = marks;
        }


        static void Main(string[] args)
        {
            StudentInfo studentInfo = new StudentInfo();
            Console.Write("Your Name is : ");
            string d = Console.ReadLine();
            studentInfo.NameFun(d);

            StudentInfo mar = new StudentInfo();
            Console.Write("Your Marks is : ");
            int m = int.Parse(Console.ReadLine());
            studentInfo.MarkFun(m);
            Console.WriteLine("{0} marks is {1}", d,m);

        }
    }
}
