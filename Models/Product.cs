using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingInventorySystem.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product()
        {
            ProductId = 0;
            Name = "";
            InStock = 0;
            Price = 0;
            Min = 0;
            Max = 0;
        }

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductId = productId;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            Console.WriteLine("Adding part to product");
            AssociatedParts.Add(part);

        }

        public bool RemoveAssociatedPart(int partId)
        {
            Part part = LookupAssociatedPart(partId);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }

    }
}
