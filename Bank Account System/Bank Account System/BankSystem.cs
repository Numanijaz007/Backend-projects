using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank_Account_System
{
    public class BankSystem
    {
        static string _BankName;
        static int _BankInterest;
        static int _TotalNumAcc;

        public string HolderName { get; set; }
        public int AccountNum { get; set; }
        public int Balance { get; set; }

        static BankSystem()
        {

            _BankName = "United Bank Limited";
            _BankInterest = 10;
            _TotalNumAcc = 5;
        }

        public BankSystem(string holderName, int accountNum, int balance)
        {

            this.HolderName = holderName;
            this.AccountNum = accountNum;
            this.Balance = balance;
        }

        public void Print()
        {

        }

        public void Break()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
        }
    }

    public class Student
    {
        protected string _Name;
        private string _Gender;
        private string _Address;
        private string _SchoolName;
        private MemoryStream ms;
        public Student()
        {
            this._Name = "";
            this._Gender = "";
            this._Address = "";
            this._SchoolName = "Al Rehman School";
        }
        ~Student()
        {
            ms.Dispose();
        }

        //public Student(string name, string gender, string address, string schoolName)
        //{
        //    this._Name = name;
        //    this._Gender = gender;
        //    this._Address = address;
        //    this._SchoolName = schoolName;
        //}

        public void SetStudentInfo(string name, string gender, string address, string schoolName)
        {
            this._Name = name;
            this._Gender = gender;
            this._Address = address;
            this._SchoolName = schoolName;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine($"Student Name: {_Name}");
            Console.WriteLine($"Gender: {_Gender}");
            Console.WriteLine($"Address: {_Address}");
            Console.WriteLine($"School Name: {_SchoolName}");
        }

    }


    public class ZZ : Student
    {
        public void ss()
        {

        }


    }



}