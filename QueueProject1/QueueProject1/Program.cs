using System.Numerics;

namespace QueueProject1
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string AccountNumber { get; set; }


        public string GetFirstName()
        {

            Console.Write("First Name : ");
            string first = Console.ReadLine();
            return first;
        }
        public string GetLastName()
        {
            Console.Write("Last Name : ");
            string last = Console.ReadLine();
            return last;
        }
        public string GetEmail()
        {

            Console.Write("Email : ");
            string email = Console.ReadLine();
            return email;
        }
        public string GetPhoneNumber()
        {
            Console.Write("Phone Number : ");
            string phone = Console.ReadLine();
            return phone;
        }
        public string GetGender()
        {
            Console.Write("Gender : ");
            string gender = Console.ReadLine();
            return gender;
        }
        public string GetAccountNumber()
        {
            Console.Write("Account Number : ");
            string accno = Console.ReadLine().ToUpper();
            return accno;
        }

        //public string PrintDetails()
        //{


        //Console.WriteLine($"First Name : {FirstName}");
        //Console.WriteLine($"Last Name : {LastName}");
        //Console.WriteLine($"Email : {Email}");
        //Console.WriteLine($"Phone Number : {PhoneNumber}");
        //Console.WriteLine($"Gender : {Gender}");
        //Console.WriteLine($"Account Number : {AccountNumber}");
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Your Details");
            //customer.GetFirstName();
            //customer.GetLastName();
            //customer.GetEmail();
            //customer.GetPhoneNumber();
            //customer.GetGender();
            //customer.GetAccountNumber();

            Queue<string> customerToken = new Queue<string>();
            customerToken.Enqueue(customer.GetFirstName());
            customerToken.Enqueue(customer.GetLastName());
            customerToken.Enqueue(customer.GetEmail());
            customerToken.Enqueue(customer.GetGender());
            customerToken.Enqueue(customer.GetPhoneNumber());
            customerToken.Enqueue(customer.GetAccountNumber());
            customerToken.Enqueue("1");



            Console.WriteLine($"\nServing(current) :");
            Console.WriteLine($"Full Name : {customerToken.Peek()} {customerToken.Peek()}");
            Console.WriteLine($"Email : {customerToken.Peek()}");
            Console.WriteLine($"Gender : {customerToken.Peek()}");
            Console.WriteLine($"Phone Number : {customerToken.Peek()}");
            Console.WriteLine($"Account Number : {customerToken.Peek()}");
            Console.WriteLine($"Generated Token Number : {customerToken.Peek()}");

            Console.WriteLine("Total Items in Queue = " + customerToken.Count);


        }
    }
}
