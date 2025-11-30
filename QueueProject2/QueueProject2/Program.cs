using System;
using System.Collections.Generic;

namespace QueueProject2
{
    // Represents one bank customer
    public class Customer
    {
        private static int nextToken = 1; // Auto token generator

        public int TokenNo { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string AccountNumber { get; set; }

        // Constructor
        public Customer()
        {
            TokenNo = nextToken++;
        }

        // Get user details interactively
        public void GetDetails()
        {
            Console.Write("First Name : ");
            FirstName = Console.ReadLine();

            Console.Write("Last Name : ");
            LastName = Console.ReadLine();

            Console.Write("Email : ");
            Email = Console.ReadLine();

            Console.Write("Phone Number : ");
            PhoneNumber = Console.ReadLine();

            Console.Write("Gender : ");
            Gender = Console.ReadLine();

            Console.Write("Account Number : ");
            AccountNumber = Console.ReadLine().ToUpper();
        }

        // Display customer info
        public void PrintDetails()
        {
            Console.WriteLine($"Token No       : {TokenNo}");
            Console.WriteLine($"Full Name      : {FirstName} {LastName}");
            Console.WriteLine($"Email          : {Email}");
            Console.WriteLine($"Phone Number   : {PhoneNumber}");
            Console.WriteLine($"Gender         : {Gender}");
            Console.WriteLine($"Account Number : {AccountNumber}");
        }
    }

    // Program execution
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> customerQueue = new Queue<Customer>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("-----BANKING QUEUE SYSTEM-----");
                Console.WriteLine("1. Add New Customer");
                Console.WriteLine("2. Serve Next Customer");
                Console.WriteLine("3. View Waiting Queue");
                Console.WriteLine("4. Exit");


                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Customer c = new Customer();
                        Console.WriteLine("\nEnter Customer Details:");
                        c.GetDetails();
                        customerQueue.Enqueue(c);
                        Console.WriteLine($"\nToken Generated: {c.TokenNo} (please wait for your turn)");
                        break;

                    case "2":
                        if (customerQueue.Count > 0)
                        {
                            Customer serving = customerQueue.Dequeue();
                            Console.WriteLine("\nNow Serving:");
                            serving.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("\nNo customers in queue.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nCurrent Waiting Queue:");
                        if (customerQueue.Count > 0)
                        {
                            foreach (var cust in customerQueue)
                            {
                                Console.WriteLine($"\nToken {cust.TokenNo} - {cust.FirstName} {cust.LastName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNo one is waiting right now.");
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("\nExiting... Thank you!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Try again!");
                        break;
                }
            }
        }
    }
}

