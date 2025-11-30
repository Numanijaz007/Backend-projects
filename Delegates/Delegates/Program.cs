namespace enums
{
    public enum OrderStatus
    {
        New=1,
        Pending,
        Preparing,
        Completed,
        Rejected
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Check order status: ");
            int status = int.Parse(Console.ReadLine());
            //int status = 0;
            if(status == (int)OrderStatus.New)
            {
                Console.WriteLine("Order is new");
            }
            else if (status == (int)OrderStatus.Pending)
            {
                Console.WriteLine("Order is pening");
            }
            else if(status== (int)OrderStatus.Preparing)
            {
                Console.WriteLine("Order is preparing");
            }
            else if( status== (int)OrderStatus.Completed)
            {
                Console.WriteLine("Order is completed");
            }
            else if(status== (int)OrderStatus.Rejected)
            {
                Console.WriteLine("order is rejected");
            }
        }
    }
}
