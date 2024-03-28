using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class ImportedProduct : Product 
    {
        public double CustomsFree {  get; set; }

        public ImportedProduct(string name, double price, double customsFree)
            :base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return $"{Name} {TotalPrice():C} (Customs fee: {CustomsFree:C})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }
    }
}
