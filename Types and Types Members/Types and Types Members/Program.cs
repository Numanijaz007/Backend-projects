using System.Reflection.PortableExecutable;
using System.Security.Authentication.ExtendedProtection;
using AssemblyOne;
using AssemblyTwo;

namespace Types_and_Types_Members
{
    #region Fields
    public class Person
    {

        private string SSN { get; set; }
        public string ssn
        {
            get; set;
        }
        protected string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion

    #region Managers Methods
    public class Manager : Person
    {
        public void PrintPrivate()
        {
            Person prs = new Person();
            prs.Age = 100;
        }

        protected internal void PrintPro()
        { 
            this.Name = "Numan";
        }

        private void PrintPrivat()
        {
            //Person person = new Person();
            

        }

    }
    #endregion

    #region Tester Methods
    public class Tester: Person
    {
        public void Print1()
        {
            Person pr1 = new Person();
            pr1.Age = 100;
        }

        public void Print2()
        {
            this.Name = "Numan";
            //Tester tester = new Tester();
            //tester.Name = "Test";
        }
    }
    #endregion

    #region Main Program Class
    internal class Program
    {
         private static void Main(string[] args)
        {
            Person prs = new Person();
            prs.ssn = "Numan";
            Console.WriteLine(prs.ssn);

            AssemblyTwoClass two = new AssemblyTwoClass();
            two.Print();
        }
    }
    #endregion
}
