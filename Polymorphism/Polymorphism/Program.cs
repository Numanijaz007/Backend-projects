namespace Polymorphism
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Sounds");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("\"Dog says Woof!\"");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("\"Cat says Meoww!\"");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();
            Dog dog = new Dog();
            dog.Speak();
            Cat cat = new Cat();
            cat.Speak();
        }
    }
}
