using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingInventorySystem.Models
{
    internal class Inhouse : Part
    {
        [Browsable(true)]
        public int MachineID { get; set; }

        public Inhouse()
        {
            PartId = 0;
            Name = "";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;
            MachineID = 0;
        }

        public Inhouse(int partid, string name, int inStock, decimal price, int min, int max, int machineID)
        {
            PartId = partid;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }




    }
}
