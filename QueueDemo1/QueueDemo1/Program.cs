using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace QueueDemo1
{
     public enum PrintStatus
    {
        Waiting = 1,
        Printing,
        Completed
    }
    public class User
    {
        public string DocName { get; set; }
        public string Owner { get; set; }
        public PrintStatus Status { get; set; }

        public void GetDetails()
        {
            Console.Write("Enter Your Name : ");
            Owner = Console.ReadLine();

            Console.Write("Enter Your Document Name : ");
            DocName = Console.ReadLine();
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{DocName}               {PrintStatus.Waiting}          {Owner}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<User> usersQueue = new Queue<User>();
            List<string> completeJobs = new List<string>();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n------Printer Job Queue------");
                Console.WriteLine("1 : Enter Your Print Details");
                Console.WriteLine("2 : Serve Print Order");
                Console.WriteLine("3 : View All Waiting Print Orders");
                Console.WriteLine("4 : View All Completed Print Orders");
                Console.WriteLine("5 : Exit");

                Console.Write("Enter Your Choice : ");
                int userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        User us = new User();
                        us.GetDetails();
                        usersQueue.Enqueue(us);
                        Console.WriteLine("Your Print Order is recieved in Queue");
                        break;

                    case 2:
                        Console.WriteLine("\nNow Printing >>>>");

                        if (usersQueue.Count > 0)
                        {
                            User ss = usersQueue.Dequeue();
                            Console.WriteLine("\nDocument Name            Status            Owner");
                            Console.WriteLine($"{ss.DocName}             {ss.Status}           {ss.Owner}");
                        }
                        else
                        {
                            Console.WriteLine("User Order Not Recieved Yet.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Waiting Orders>>>>");
                        if (usersQueue.Count > 0)
                        {
                            Console.WriteLine("\nDocument Name            Status            Owner");

                            foreach (var item in usersQueue)
                            {
                                Console.WriteLine($"{item.DocName}             {item.Status}           {item.Owner}");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("No User Waiting");
                        }
                        break;

                    case 4:

                        Console.WriteLine("Completed Orders>>>>");

                        if (usersQueue.Count > 0)
                        {
                            User usa = usersQueue.Dequeue();

                            Console.WriteLine("\nDocument Name            Status            Owner");
                            foreach (var item in usersQueue)
                            {
                                Console.WriteLine($"{item.DocName}            {item.Status}            {item.Owner}");
                            }
                        }

                        else
                        {
                            Console.WriteLine("No User Completed");
                        }

                        break;


                    case 5:
                        Console.WriteLine("Exit");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice Please Try Again");
                        break;
                }

            }
        }
    }
}
