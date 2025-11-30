namespace Reflection3
{
    public class Student
    {
        public string Name { get; set; } = "Unknown Person";
        public int Age { get; set; } = 30;
        public string Grade { get; set; } = "A+";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Type type = typeof(Student);
            object obj = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine($"{item} {item.GetValue(obj)}");
            }            
        }
    }
}
