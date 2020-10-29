using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SavingsAccount mySavingsAccount = new SavingsAccount(); //created an instance of SavingsAccount. name of instance: mySavingsAccount

            mySavingsAccount.Balance = 1000;
            mySavingsAccount.InterestRate = 5;
            double interestInEuro = mySavingsAccount.CalculateInterest();*/

            //BankAccount b = new BankAccount("5746348534958", 100);
            SavingsAccount s = new SavingsAccount("58439689", 1000, myUser, 1.5);

            double updatedBalance = s.Withdraw(100);    

        }
    }
}
