using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    //inheritance means that the class in quesiton is inheriting/getting all the public OR protected members of the base class
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string iban, double balance, User owner, double interestRate)
            :base(iban, balance, owner)
        {
            interestRate = interestRate;
        }
        public double InterestRate { get; set; }   

        public double CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }
    }
}
