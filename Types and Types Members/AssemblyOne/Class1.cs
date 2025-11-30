using AssemblyTwo;

namespace AssemblyOne
{
    public class AssemblyOneClass
    {
        public void Get()
        {
            AssemblyTwoClass two = new AssemblyTwoClass();
            two.Print();
        }
    }
}
