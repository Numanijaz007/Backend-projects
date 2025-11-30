namespace Coffee_Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalCoffeeCost = 0;

        Start:
            Console.WriteLine("1-Small , 2-Medium , 3-Large ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;

                case 2:
                    totalCoffeeCost += 2;
                    break;

                case 3:
                    totalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("Your Choice is Invalid ${0}", userInput);
                    break;
            }

        Decide:
            Console.WriteLine("Do You Want To Continue Shopping : Yes or No");
            string? userDecision = Console.ReadLine();
            switch (userDecision!.ToUpper())
            {
                case "YES":
                    goto Start;

                case "NO":
                    break;

                default:
                    Console.WriteLine("You entered Invalid choice {0}...... Please Try Again!", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Your Bill Amount is ${0}", totalCoffeeCost);
            Console.WriteLine("Thanks For Shopping With Us");
        }
    }
}
