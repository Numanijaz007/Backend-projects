using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GenericQueue
{
    public class BankCustomerInfo
    {
        public BankCustomerInfo(string firstName, string lastName, string gender, string accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            AccountNumber = accountNumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string AccountNumber { get; set; }
        //public int AccountNumber { get; set; }
    }

    //public class Menu
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your details first");

            Console.Write("FirstName : ");
            var firstname = Console.ReadLine();

            Console.Write("LastName : ");
            var lastName = Console.ReadLine();

            Console.Write("Gender : ");
            var gender = Console.ReadLine();

            Console.Write("Account Number : ");
            var accountno = Console.ReadLine();

            Console.Write("Get Token no press T : ");
            var token = Console.ReadLine();


            //    Queue<BankCustomerInfo> bankCustomerInfos = new Queue<BankCustomerInfo>();

            //    bankCustomerInfos.Enqueue();

            //    bankCustomerInfos.Enqueue();
            //}
        }
    }
}
