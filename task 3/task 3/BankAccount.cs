using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class BankAccount
    {
        public const string BankCode = "BNK001";

        public readonly DateTime CreatedDate;

        private  int AccountNumber = 10;

        private int _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        private double _balance;

        public string FullName { 
            get
            {
                return _fullName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("invalid name");
                _fullName = value;
            }
                }

        public string NationalID
        {
            get
            {
                return _nationalID;
            }
            set
            {
                if (value.Length != 14 )
                    Console.WriteLine("invalid national id");
                 _nationalID = value;
            }
        }

        public string PhoneNumber {
            get
            {
                return _phoneNumber;

            }
            set
            {
                if (value.Length != 11 || !value.StartsWith("01") )
                    Console.WriteLine("invalid phone number");
                _phoneNumber = value;
            }
        }

        public double Balance {
            get
            {
                return _balance;
            }
                set
            {
                if (value < 0)
                    Console.WriteLine("invalid balance");
                _balance = value;
            }
        }

        public string Address { get; set; }

       
        public BankAccount()
        {
            
           
            _fullName = "";
            _nationalID = "";
            _phoneNumber = "";
            _address = "";
            _balance = 0;
            CreatedDate = DateTime.Now;

        }

       
        public BankAccount(string fullName, string nationalID, string phoneNumber,  double balance, string address)
        {
           
            
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Balance = balance;
            Address = address;
            CreatedDate = DateTime.Now;
        }

        
        public BankAccount(string fullName, string nationalID, string phoneNumber, string address)
            : this(fullName, nationalID, phoneNumber,0,address)
        {  }

       
        public void ShowAccountDetails()
        {
           
            Console.WriteLine($"Full Name: {_fullName}");
            Console.WriteLine($"National ID: {_nationalID}");
            Console.WriteLine($"Phone Number: {_phoneNumber}");
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"Balance: {_balance:C}");
            Console.WriteLine($"Bank Code: {BankCode}");
            Console.WriteLine($"Created Date: {CreatedDate}");
            Console.WriteLine();
        }

        public bool Is_Valid_NationalID()
        {
           
            if (_nationalID.Length == 14 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Is_Valid_PhoneNumber()
        {
           
            if (_phoneNumber.Length == 11 && _phoneNumber.StartsWith("01") )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

