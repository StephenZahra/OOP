using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Publication
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Copies { get; set; }
       
        public int SellCopy(int amount)
        {
            Copies -= amount;
            return Copies;
        }
    }
}
