namespace Inheritance
{
    public class Student
    {
        public string Institute { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Your Full Name is : {FirstName} {LastName}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Institute Name : {Institute}");
            Console.WriteLine($"Desscription : {Description}");
        }

        public void Break()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
        }

    }

    public class MorningSession : Student
    {
        public int Fees { get; set; }
        public void PrintFee(int f)
        {
            Console.WriteLine($"Student Fee : " + f);
        }
    }

    public class EveningSession : Student
    {
        public int Fees { get; set; }
        public void PrintFee1(int f)
        {
            Console.WriteLine($"Student Fee : " + f);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MorningSession ms = new MorningSession();
            string n = Console.ReadLine();
            ms.FirstName = n;
            string nl = Console.ReadLine();
            ms.LastName = nl;
            string nlp = Console.ReadLine();
            ms.Email = nlp;
            ms.PrintFee(10000);
            ms.Institute = "IISAT";
            ms.Description = "This Student is doing IT degree from IISAT University";
            ms.PrintDetails();
            ms.Break();


            EveningSession es = new EveningSession();
            es.FirstName = "Sami";
            es.LastName = "Rehman";
            es.Email = "samirehman212@gmail.com";
            es.PrintFee1(20000);
            es.Institute = "IISAT";
            es.Description = "This Student is doing CS degree from IISAT University";
            es.PrintDetails();
           
        }
    }
}

