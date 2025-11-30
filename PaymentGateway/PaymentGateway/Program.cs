namespace PaymentGateway
{
    public interface IPaymentGateway
    {
        void Pay(int amount);
        void Refund(int amount);
        int GetBalance();

    }

    public abstract class Person
    {
        public abstract string GetDesignation();
        public string Name { get; set; }
        public string GetName()
        {
            return Name;    
        }
    }

    public class SoftwareEngineer:Person
    {
        public override string GetDesignation()
        {
            return "Software Engineer";
        }
    }

    public class JazzCash : IPaymentGateway
    {
        private int balance = 0;
        public int GetBalance()
        {
            Console.WriteLine("Your jazz cash balance is:"+ balance);
            return balance;
        }

        public void Pay(int amount)
        {
            balance+= amount;
        }

        public void Refund(int amount)
        {
            balance -= amount;

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Person ss = new SoftwareEngineer();
            ss.Name = "Salman";
            ss.GetName();
            ss.GetDesignation();


            IPaymentGateway jazzCash = new JazzCash();
            jazzCash.Pay(1);

            //Console.WriteLine();


        }
    }
}
