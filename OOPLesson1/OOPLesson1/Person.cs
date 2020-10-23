using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOPLesson1
{
    //Class is a blueprint (template) that defines an entity sturcture. An entity (usually) represents a real life-model
    //or object which is described using characteristics.

    //Use Pascal casing for public members or objects

    //field: is a variable which describes something about the model/object

    //use camel casing for field names

    //property - Is (usually) declared as public and controls the accesibility to the field
    class Person //an exmaple of a class
    {
        string idCardNo;        //when declaring something in a class, it is private. Type public to make it public
        private string name; //an example of a field
        string surname;
        int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public String IdCard
        {
            get { return idCardNo; }
            set
            {
                switch (value.ToString().Length)
                {
                    case 5:
                        idCardNo = "00" + value;
                        break;
                    case 6:
                        idCardNo = "0" + value;
                        break;
                    default:
                        idCardNo = value.ToString();
                        break;
                }
                idCardNo = value.ToString().ToUpper();
            }
        }

        public String FullName //read-only property
        {
            get { return Name + " " + Surname; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Address { get; set; } //taking a shortcut (if we know that we don't need ant particular implimentation for this particular member

        public string MobileNo { get; set; }

        public string TelNo { get; set; }

        public DateTime DateOfBirth { get; set; }


        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            return today.Year - DateOfBirth.Year;
        }

        public string DelimitAddress(char c)
        {
            string [] delimitedAddress = Address.Split(new char[] {  ' ' });
            string output = "";
            foreach (string s in delimitedAddress) 
            {
                output += s + c + " ";
            }
            return output.Remove(output.Length - 2);
        }
    }
}
