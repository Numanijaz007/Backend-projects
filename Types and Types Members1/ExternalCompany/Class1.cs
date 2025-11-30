using System;
using Types_and_Types_Members1;

namespace ExternalCompany
{
    public class Class1 : FinanceDepartment
    {
        public void PrintAll()
        {
            HRDepartment fin = new HRDepartment();
            fin.Print1();
            fin.Print2();
        }
    }
}
