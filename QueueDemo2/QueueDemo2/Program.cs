using System;
using System.Collections.Generic;
using System.Linq;

namespace HelpdeskQueueSystem
{
    // Enum for ticket status
    public enum TicketStatus
    {
        Pending,
        InProgress,
        Completed
    }

    // Ticket class
    public class Ticket
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string IssueDescription { get; set; }
        public TicketStatus Status { get; set; }

        public override string ToString()
        {
            return $"[Ticket #{Id}] {CustomerName} - {IssueDescription} ({Status})";
        }
    }

    class Program
    {
        static void Main()
        {
            Queue<Ticket> ticketQueue = new Queue<Ticket>();
            List<Ticket> completedTickets = new List<Ticket>();

            int ticketCounter = 1;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== HELP DESK MENU =====");
                Console.WriteLine("1. Add New Ticket");
                Console.WriteLine("2. View Next Ticket");
                Console.WriteLine("3. Process Next Ticket");
                Console.WriteLine("4. View Completed Tickets");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Customer Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Issue Description: ");
                        string issue = Console.ReadLine();

                        Ticket newTicket = new Ticket
                        {
                            Id = ticketCounter++,
                            CustomerName = name,
                            IssueDescription = issue,
                            Status = TicketStatus.Pending
                        };

                        ticketQueue.Enqueue(newTicket);
                        Console.WriteLine($"\n✅ Ticket #{newTicket.Id} added to queue.");
                        break;

                    case "2":
                        if (ticketQueue.Any())
                        {
                            Ticket peekTicket = ticketQueue.Peek();
                            Console.WriteLine($"👀 Next Ticket to Process:\n{peekTicket}");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ No tickets available.");
                        }
                        break;

                    case "3":
                        if (ticketQueue.Any())
                        {
                            Ticket current = ticketQueue.Dequeue();
                            current.Status = TicketStatus.InProgress;
                            Console.WriteLine($"🧾 Processing {current}");

                            Console.Write("Mark as completed? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y")
                            {
                                current.Status = TicketStatus.Completed;
                                completedTickets.Add(current);
                                Console.WriteLine($"✅ Ticket #{current.Id} marked as Completed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("⚠️ No pending tickets.");
                        }
                        break;

                    case "4":
                        if (completedTickets.Any())
                        {
                            Console.WriteLine("🏁 Completed Tickets:");
                            foreach (var t in completedTickets)
                                Console.WriteLine(t);
                        }
                        else
                        {
                            Console.WriteLine("❌ No completed tickets yet.");
                        }
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("👋 Exiting Helpdesk System...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
