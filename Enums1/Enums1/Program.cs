namespace Enums1
{
    public enum Days
    {
        Monday = 1,
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to get day name : ");
            int value = int.Parse(Console.ReadLine());
            if (value == (int)Days.Monday)
            {
                Console.WriteLine("You Entered Monday Day!");
            }
            else if(value == (int)Days.Tuesday)
            {
                Console.WriteLine("You Entered Tuesday Day!");
            }
            else if(value == (int)Days.Wednesday)
            {
                Console.WriteLine("You Entered Wednesday Day!");
            }
            else if(value == (int)Days.Thursday)
            {
                Console.WriteLine("You Entered Thursday Day!");
            }
            else if(value == (int)Days.Friday)
            {
                Console.WriteLine("You Entered Friday Day!");
            }
            else if(value == (int)Days.Saturday)
            {
                Console.WriteLine("You Entered Saturday Day!");
            }
            else
            {
                Console.WriteLine("You Entered Sunday Day!");
            }

        }
    }
}
