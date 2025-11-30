namespace Dictionary2
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
            Dictionary<int, Students> studentsid = new Dictionary<int, Students>();

            Students student1 = new Students();
            student1.ID = 127;
            student1.Marks = 90;
            studentsid[127] = student1;
            var info1 = studentsid[127];

            Students student2 = new Students();
            student2.ID = 190;
            student2.Marks = 88;
            studentsid[190] = student2;
            var info2 = studentsid[190];

            Students student3 = new Students();
            student3.ID = 107;
            student3.Marks = 80;
            studentsid[107] = student3;
            var info3 = studentsid[107];

            Students student4 = new Students();
            student4.ID = 171;
            student4.Marks = 70;
            studentsid[171] = student4;
            var info4 = studentsid[171];

            Students student5 = new Students();
            student5.ID = 209;
            student5.Marks = 77;
            studentsid[209] = student5;
            var info5 = studentsid[209];


            Console.WriteLine("Student ID : " + info1.ID + ", Student Marks : " + info1.Marks);
            Console.WriteLine("Student ID : " + info2.ID + ", Student Marks : " + info2.Marks);
            Console.WriteLine("Student ID : " + info3.ID + ", Student Marks : " + info3.Marks);
            Console.WriteLine("Student ID : " + info4.ID + ", Student Marks : " + info4.Marks);
            Console.WriteLine("Student ID : " + info5.ID + ", Student Marks : " + info5.Marks);
        }
    }
}
