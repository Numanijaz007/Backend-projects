namespace QueueDemo
{
    public class Customer
    {
        private static int NextToken { get; set; } = 1;
        public int Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountNumber { get; set; }

        public Customer()
        {
            Token = NextToken++;
        }
        public void GetDetails()
        {
            Console.Write("First Name : ");
            FirstName = Console.ReadLine();

            Console.Write("Last Name : ");
            LastName = Console.ReadLine();

            Console.Write("Email : ");
            Email = Console.ReadLine();

            Console.Write("Gender : ");
            Gender = Console.ReadLine();

            Console.Write("Phone Number : ");
            PhoneNumber = Console.ReadLine();

            Console.Write("Account Number : ");
            AccountNumber = Console.ReadLine();

        }

        public void PrintDetails()
        {
            //Console.WriteLine($"Token No : {Token}");
            Console.WriteLine($"Full Name : {FirstName} {LastName}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
            Console.WriteLine($"Account Number : {AccountNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> customerToken = new Queue<Customer>();
            bool running = true;


            while (running)
            {
                Console.WriteLine("\n-----BANKING QUEUE SYSTEM-----");
                Console.WriteLine("1 : Add New Customer");
                Console.WriteLine("2 : Serve Next Customer");
                Console.WriteLine("3 : View Waiting Customers");
                Console.WriteLine("4 : Exit"); 
                Console.Write("Enter Your Choice : ");
                int userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.WriteLine("\nEnter Customer Details");
                        Console.WriteLine();
                        customer.GetDetails();
                        customerToken.Enqueue(customer);
                        Console.WriteLine($"Token Generated : {customer.Token}");
                        break;


                    case 2:
                        if (customerToken.Count > 0)
                        {
                            Customer serving = customerToken.Dequeue();
                            Console.WriteLine("\nNow Serving...");
                            serving.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("No Customer to be serving!");

                        }
                        break;


                    case 3:
                        Console.WriteLine("\nCurrent Waiting Queue");
                        if (customerToken.Count > 0)
                        {
                            foreach (var waiting in customerToken)
                            {
                                Console.WriteLine($"Waiting Customer : {waiting.FirstName} {waiting.LastName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Customers");
                        }
                        break;


                    case 4:

                        Console.WriteLine("Exit!");
                        running = false;
                        break;



                    default:
                        Console.WriteLine("Not");
                        break;
                }
            }
        }
    }
}
