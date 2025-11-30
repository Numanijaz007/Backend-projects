namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userDecision ;
            int i = 0;
            do
            {
                Console.WriteLine("Choose one option : ");
                Console.WriteLine("1 : Convert Celsius --> Fahrenheit");
                Console.WriteLine("2 : Convert Fahrenheit --> Celsius");

                int userOption = int.Parse(Console.ReadLine());

                if (userOption == 1)
                {
                    Console.WriteLine("Enter value to check temperature in Fahrenhiet: ");
                    int userInput = int.Parse(Console.ReadLine());
                    float mulbycel = 1.8F;
                    int addbycel = 32;

                    float.TryParse(Convert.ToString(userInput * mulbycel + addbycel), out float result);
                    Console.WriteLine("Converted {0} °C to Fahrenheit = {1} °F", userInput, result);
                }
                else if (userOption == 2)
                {
                    Console.WriteLine("Enter value to check temperature in Celsius: ");
                    int userInput = int.Parse(Console.ReadLine());
                    float divbycel = 1.8F;
                    int subbycel = 32;

                    float.TryParse(Convert.ToString((userInput - subbycel) / divbycel), out float result1);
                    Console.WriteLine("Converted {0} °F to Celsius = {1} °C", userInput, result1);
                }
                else
                {
                    Console.WriteLine("Please enter valid value!");
                }

                Console.WriteLine("Do you want another try...[y/n]");
                userDecision = Console.ReadLine();

                i++;
            }while (userDecision.ToUpper() == "Y");

        }
    }
}
