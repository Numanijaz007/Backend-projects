using System.Security.Cryptography.X509Certificates;

namespace QueueProject
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string AccountNumber { get; set; }
        public string SelectedService { get; set; }
        public int TokenNo { get; set; }
        public DateTime ArrivalTime { get; set; }


        public string EnterDetails()
        {
            Console.WriteLine("Enter Your Details First");
            Console.WriteLine();


            return FirstName;


            //string firstname = Console.ReadLine();


            Console.WriteLine($"LastName : {LastName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Account Number : {AccountNumber}");
        }

        public void SelectService()
        {
            Console.WriteLine($"1 : Cash Deposit   2 : Cash Withdrawl   3 : Account Opening");
            Console.Write($"Select Service : {SelectedService}");
        }

    }
     
    public class Token : Customer
    {
        public string ServiceType { get; set; }
        public DateTime DateTimeIssued { get; set; }
        public string Status { get; set; }



        public void GenerateToken()
        {
            Console.WriteLine($"Token Number : {TokenNo}");
            Console.WriteLine($"Service Type : {ServiceType}");
        }

        public void AssignToQueue()
        {

        }

        public void MarkCompleted()
        {
            Console.WriteLine($"");
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName();
            customer.LastName = "Ijaz";
            customer.Gender = "Male";
            customer.AccountNumber = "M12319048Z";
            customer.EnterDetails();
        }
    }
}
