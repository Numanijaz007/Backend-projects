namespace Properties
{

    public class Person
    {
        public string Name { get; set; }

        public virtual string GetInfo()
        {
            return $"Name: {Name}";
        }

    }

    public class Student:Person
    {
        public string SchoolName { get; set; }

        public override string GetInfo()
        {
            return $"Name: {Name} \nSchool Name: {SchoolName}";
        }


        //private int salary; 
        //public int Salary
        //{
        //    get { return salary-10; }
        //    set { salary = value; }
        //}
    }

    internal class Program
    {
        public static int Add(params int[]  numbers)
        {
           return numbers.Sum();
        }

        static void Main(string[] args)
        {
            Person p=new Person();
            p.Name = "Salman Ahmed";
            Console.WriteLine(p.GetInfo());

            //student ob=new student();

            //Add(1, 2, 3, 4, 5, 6, 7);

            Student student=new Student();
            string nme = Console.ReadLine();
            student.Name = nme;
            student.SchoolName = "Al rehman school";
            Console.WriteLine(student.GetInfo());

        }
    }
}
