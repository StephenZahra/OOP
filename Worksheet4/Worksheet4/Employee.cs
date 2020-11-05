using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet4
{
    class Employee
    {
        public Employee()
        { }

        public string Idcard { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }

        public virtual double CalculateTotalPay()
        {
            return BasePay;
        }

        public override int GetHashCode()
        {
            return Idcard.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else return false;
        }
    }
}
