using System.Reflection.Metadata.Ecma335;

namespace Generic3
{
    public class Pair2<T>
    {
        private T _value;
        public Pair2(T value)
        {
            _value = value;
            Console.WriteLine($"{value} stored...");
        }
        public T GetAll()
        {
            return _value;
        }

    }
   
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        
        public TValue Value { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Pair<int, string> ss = new Pair<int, string>();
            ss.Key= 1;
            ss.Value = "Salman";

            Console.WriteLine(ss.Key+" - "+ss.Value);


        }
    }
}
