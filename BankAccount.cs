using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GA_ConstructorsMethodsOverloading_Hongfei
{
    public class BankAccount
    {
        string _accountNumber;
        string _customerName;
        double _balance;

        public BankAccount(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        public string AccountNumber { get => _accountNumber;}
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance;}

        public void Deposit(double amout)
        {
            if ( amout >= 0 ) 
            {
                _balance += amout;
            }
            else 
            {
                Console.WriteLine("Dposit amout is invalid");
            }
        }

        public void WithDraw(double amout)
        {
            if (amout >0 && amout <= _balance)
            {
                _balance -= amout;
            }
            else 
            {
                Console.WriteLine("You cannnot not overdraw");
            }
        }

        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current Balance:{_balance:C}";
        }

    }

    


    
}
