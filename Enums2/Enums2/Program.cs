namespace Enums2
{
    public enum TrafficLights
    {
        Red = 1,
        Yellow,
        Green
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to change traffic lights : ");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case (int)TrafficLights.Red:
                    Console.WriteLine("Stop");
                    break;

                    case (int)TrafficLights.Yellow:
                    Console.WriteLine("Wait");
                    break;

                    case (int)TrafficLights.Green:
                    Console.WriteLine("Go");
                    break;

            }

        }
    }
}
