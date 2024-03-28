using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class Usedproduct : Product
    {
       

        public DateTime ManufacturingDate { get; set; }

        public Usedproduct(string name, double price, DateTime manufacturingDate) : 
            base(name, price) 
        {
            ManufacturingDate = manufacturingDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) {Price:C} (Manufacture date: {ManufacturingDate:d})";
        }


    }
}
