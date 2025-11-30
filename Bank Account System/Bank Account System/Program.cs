namespace Bank_Account_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ob = new Student();
            ob.SetStudentInfo("Nauman", "M", "Bahria Enclave", "Beacon House");
            ob.GetStudentInfo();

            BankSystem obj = new BankSystem("", 0, 0);
            obj.Break();
            
            Student ob2 = new Student();
            ob2.SetStudentInfo("Salman", "M", "Bahria Enclave Islamabad", "Al Rehman School System");
            ob2.GetStudentInfo();
        }
    }
}
