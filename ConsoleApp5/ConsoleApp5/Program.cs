namespace ConsoleApp5
{

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Email: {Email}";
        }

        public override bool Equals(object? obj)
        {
            return this.Email == ((Student)obj)?.Email;
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            Student sb = new Student();
            sb.FirstName = "Salman";
            sb.LastName = "Ahmed";
            sb.Email = "salman14048@gmail.com";

            var ss = sb.ToString();
            Student sb1 = new Student();
            sb1.FirstName = "Numan";
            sb1.LastName = "Ahmed";
            sb1.Email = "salman14048@gmail.com";


            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sb1.ToString());
            //string s1 = "sam";
            //string s2 = "sam";
            //Console.WriteLine(s1.Equals(s2)); 
            //Console.WriteLine(sb.Equals(sb1));
            sb1 = null;

            Console.WriteLine(Convert.ToString(sb));
           




        }
    }
}
