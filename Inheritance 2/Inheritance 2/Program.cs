using System.Reflection.Metadata.Ecma335;
using System;
using System.Runtime.CompilerServices;

namespace Inheritance_2
{
    public class MughalMehal
    {
        static string HotelName;
        public string Name { get; set; }
        public string Reviews { get; set; }
        public int Adult { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        static MughalMehal()
        {
            MughalMehal.HotelName = "Mughal Mehal";
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Hotel Name : {HotelName}");
            Console.WriteLine($"Customer Name : {Name}");
            Console.WriteLine($"Customer Reviews : {Reviews}");
            Console.WriteLine($"Booking Adults: {Adult}");
            Console.WriteLine($"Status : {Status}");
            Console.WriteLine($"Date/Time : {DateTime.Now}");
        }
        public void Break()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }
    }

    public class VipGuest : MughalMehal
    {
        public string RoomsLot { get; set; }
        public virtual void Room1(string a)
        {
            Console.WriteLine("VIP Room Type: " + a);
        }
    }
    public class VIP1 : VipGuest
    {
        public string Type { get; set; }
        public override void Room1(string i)
        {
            
            Console.WriteLine("VIP1 type is : " + i);
        }
    }
    public class VIP2 : VipGuest
    {
        public string Type { get; set; }
        public override void Room1(string i)
        {
            
            Console.WriteLine($"VIP2 type is : " + i);
        }
    }
    public class Guest : MughalMehal
    {
        public string RoomsLot { get; set; }
        public new void Room2(string b)
        {
            //base.PrintDetails();
            Console.WriteLine("Guest Room : " + b);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            VIP1 vip1 = new VIP1();
            Console.Write("Enter VIP1 Room Type : ");
            string nlps = Console.ReadLine();

            VipGuest vpr = new VipGuest();
            Console.Write("Enter Your Name : ");
            string n = Console.ReadLine();
            vpr.Name = n;
            Console.Write("Enter Your Review : ");
            string nl = Console.ReadLine();
            vpr.Reviews = nl;
            Console.Write("Enter Adults Count : ");
            int nlp = int.Parse(Console.ReadLine());
            vpr.Adult = nlp;
            vpr.Status = "Confirmed";
            vpr.Date = Convert.ToString(DateTime.Now);
            Console.Write("Enter Room Name : ");
            string nlpo = Console.ReadLine();
            vpr.Break();

            Guest guest = new Guest();
            guest.Room2(nlpo);
            vpr.PrintDetails();
            vpr.Room1(nlps.ToUpper());
            vpr.Break();

            
            VIP2 vIP2 = new VIP2();
            Console.Write("Enter VIP2 Room Type : ");
            string nlpss = Console.ReadLine();
            vIP2.Break();

            Guest gr = new Guest();
            gr.Name = "Leo Dicaprio";
            //gr.Room2(nlpss);
            gr.Reviews = "3 starts";
            gr.Adult = 1;
            gr.Status = "Not Confirmed";
            gr.Date = Convert.ToString(DateTime.Now);
            gr.Room2("Guest House Apartment 3");
            gr.PrintDetails();
            vpr.Room1(nlpss.ToUpper());

        }
    }
}
