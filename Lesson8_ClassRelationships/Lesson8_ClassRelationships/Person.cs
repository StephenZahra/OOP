using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ClassRelationships
{
    public class Person
    {
        public string IdCardNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Location ContactInfo { get; set; }

        //when you use a class without never storing it directly in the class it is Association
        public int CalculateAge(DateTime dob)
        {
            return DateTime.Now.Year - dob.Year;
        }
    }
}
