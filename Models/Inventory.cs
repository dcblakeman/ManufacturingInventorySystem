using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManufacturingInventorySystem.Models


{
    
    internal class Inventory
    {
        //Intialize Product Binding List
        public static BindingList<Product> Products = new BindingList<Product>
        {
            new Product { ProductId = 0, Name = "Mountain Bike", Price = 3.00M, InStock = 11, Min = 5, Max = 15 },
            new Product { ProductId = 1, Name = "Scooter", Price = 4.00M, InStock = 11, Min = 5, Max = 15 },
            new Product { ProductId = 2, Name = "Skateboard", Price = 5.00M, InStock = 11, Min = 5, Max = 15 }, 
        };
        //Products Filtered List
        public static BindingList<Product> ProductFilteredList = new BindingList<Product>(Products);

        //Initialize AllParts Binding List
        public static BindingList<Part> AllParts = new BindingList<Part>
        {
            new Outsourced { PartId = 0, Name = "wheel", Price = 3.00M, InStock = 11, Min = 5, Max = 15, CompanyName = "Hotel" },
            new Inhouse { PartId = 1, Name = "handlebar", Price = 3.00M, InStock = 11, Min = 5, Max = 15, MachineID = 121321 },
            new Outsourced { PartId = 2, Name = "seat", Price = 3.00M, InStock = 11, Min = 5, Max = 15, CompanyName = "Gas Station"},
        };

        //AllParts Filtered List
        public static BindingList<Part> FilteredList = new BindingList<Part>(AllParts);
        public Inventory()
        {
            
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int productId)
        {
            Product product = LookupProduct(productId);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public bool RemovePart(int partId)
        {
            Part part = LookupPart(partId);
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Product LookupProduct(int productId)
        {
            foreach (Product product in Products)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }

        public void UpdateProduct(int productId, Product product)
        {
            Product oldProduct = LookupProduct(productId);
            if (oldProduct != null)
            {
                oldProduct.ProductId = product.ProductId;
                oldProduct.Name = product.Name;
                oldProduct.Price = product.Price;
                oldProduct.InStock = product.InStock;
                oldProduct.Min = product.Min;
                oldProduct.Max = product.Max;
            }
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public Part LookupPart(int partId)
        {
            foreach (Part part in AllParts)
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
