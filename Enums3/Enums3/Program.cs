namespace Enums3
{
    public enum PaymentMethod
    {
        Cash = 1,
        CreditCard,
        PayPal,
        BankTransfer
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Payment Method : 1 : Cash   2 : Credit Card   3 : PayPal   4 : Bank Transfer");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case (int)PaymentMethod.Cash:
                    Console.WriteLine("You selected Cash on delivery.");
                    break;

                    case (int)PaymentMethod.CreditCard:
                    Console.WriteLine("You redirecting to Credit Card.");
                    break;

                    case (int)PaymentMethod.PayPal:
                    Console.WriteLine("You redirecting to PayPal.");
                    break;

                    case (int)PaymentMethod.BankTransfer:
                    Console.WriteLine("You redirecting to Bank Transfer.");
                    break;

                    default:
                    Console.WriteLine("You Enter Invalid Payment Method!!!");
                    break;
            }
        }
    }
}
