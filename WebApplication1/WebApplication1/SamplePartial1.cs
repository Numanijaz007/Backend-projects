using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public partial class SamplePartial
    {
        public void GetFullName()
        {
            Console.WriteLine($"Your Full name is {FirstName} {LastName}");
        }
    }
}