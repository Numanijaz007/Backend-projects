namespace ConsoleApp9
{
    internal class Program
    {

        public static async Task<int> Add(int a,int b, int c=0)
        {
            int z = a + b ;
            return z;
        }

        static async Task Main(string[] args)
        {
            
            int result = await Add(2,5);
            Console.WriteLine("Hello, World!"+ result);
        }
    }
}
