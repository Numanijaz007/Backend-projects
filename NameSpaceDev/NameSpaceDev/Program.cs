
namespace NameSpaceDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAccount salman = new UserAccount();
            Console.WriteLine("My balance is:"+salman.GetBalance());
            Util.PrintSeperator();

            salman.Desposit(1000);
            Console.WriteLine("My balance is:" + salman.GetBalance());
            Util.PrintSeperator();

            salman.Desposit(50000);
            Console.WriteLine("My balance is:" + salman.GetBalance());
            Util.PrintSeperator();

            salman.WithDraw(20000);
            Console.WriteLine("My balance is:" + salman.GetBalance());
            Util.PrintSeperator();

            salman.WithDraw(20000);
            Console.WriteLine("My balance is:" + salman.GetBalance());
            Util.PrintSeperator();

            salman.WithDraw(50000);
            Console.WriteLine("My balance is:" + salman.GetBalance());
            Util.PrintSeperator();



        }
    }
     
}
 