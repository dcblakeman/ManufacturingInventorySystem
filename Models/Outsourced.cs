using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingInventorySystem.Models
{
    internal class Outsourced : Part
    {
        [Browsable(true)]
        public string CompanyName { get; set; }

        public Outsourced()
        {
            PartId = 0;
            Name = "";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;
            CompanyName = "";
        }

        public Outsourced(int partid, string name, int inStock, decimal price, int min, int max, string companyName)
        {
            PartId = partid;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
        
    }
}
