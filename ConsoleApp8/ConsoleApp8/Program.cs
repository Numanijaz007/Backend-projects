namespace ConsoleApp8
{
    public class Person
    {
        public Person(string firstName,string lastName)
        {
            FirstName= firstName;
            LastName= lastName;
            //AccountNumber= accountNumber;   
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string AccountNumber { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            ////queue.Dequeue();
            ////queue.Dequeue();
            ////queue.Dequeue();

            //var ss = queue.Dequeue();
            //Console.WriteLine(ss);
            //var ssd = queue.Dequeue();
            //Console.WriteLine(ssd);

            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(new Person("Token","1"));
            queue.Enqueue(new Person("Token", "2"));
            queue.Enqueue(new Person("Token", "3"));

            var frontPerson = queue.Peek();
            Console.WriteLine(frontPerson.FirstName+" "+frontPerson.LastName);

            var midPerson = queue.Peek();
            Console.WriteLine(midPerson.FirstName + " " + midPerson.LastName);

            var endPerson = queue.Peek();
            Console.WriteLine(endPerson.FirstName + " " + endPerson.LastName);

        }
    }
}
