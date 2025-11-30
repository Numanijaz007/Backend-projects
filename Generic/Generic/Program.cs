namespace Generic
{

    public interface  IBox<T>
    {
        void Fruit();
        void Book();
        void Toy();
    }

    public class Box<T> : IBox<T>
    {
        public void Book()
        {

            Console.WriteLine($"are added");
        }

        public void Fruit()
        {
            Console.WriteLine($"are added");
        }

        public void Toy()
        {
            Console.WriteLine($"are added");
        }

        
    }

    public class Input
    {
        public string ToyName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<Input> box = new Box<Input>();

        }
    }
}
