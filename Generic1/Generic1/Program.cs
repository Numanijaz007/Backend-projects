namespace Generic1
{
    public class Calculator<T>
    {
        public static bool AreEqual(T value1 , T value2)
        {
            return value1.Equals(value2);
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool equal = Calculator<string>.AreEqual("N", "N");
            if(equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
