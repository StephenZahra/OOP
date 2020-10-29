using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
        
    public enum AccountStatus { Active, Suspended, Frozen, Disabled, Closed}
    public class BankAccount
    {
        //default constructor (is usually also the parameterless constructor)
        public BankAccount()
        {
            Balance = 0;
            OpeningDate = DateTime.Now;
        }

        public BankAccount(string iban, double balance, User owner) : this() //this() will refer to the default constructor and execute IT first
        {
            Iban = iban;
            Balance = balance;
            Owner = owner;
        }

        public string Iban { get; set; }
        protected double Balance { get; set; } //if you want to allow access to this property ONLY from inherited classes
        public User Owner { get; set; }

        public DateTime OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; } //value stored inside this property/field can also be null

        public AccountStatus Status { get; set; }

        public double Withdraw(double amount)
        {
            //log the withdrawl transaction
            if(amount <= Balance)
            {
                Balance -= amount;
            }

            return Balance;
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
    }
}
