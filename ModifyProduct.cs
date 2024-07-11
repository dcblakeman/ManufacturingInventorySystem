using ManufacturingInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManufacturingInventorySystem
{
    public partial class ModifyProduct : Form
    {
        private DataGridViewRow productRow;
        Inventory inventory = new Inventory();
        Product product;
        int productid;
        int associatedproductscounter = 0;
        

        public ModifyProduct()
        {
            InitializeComponent();
        }

        public ModifyProduct(DataGridViewRow productRow)
        {
            InitializeComponent();
            this.productRow = productRow;

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            //Data Sources
            CandidatePartsGridView.DataSource = Inventory.AllParts;
            AssociatedPartsGridView.DataSource = Product.AssociatedParts;

            //Product Data
            ModifyProductIDField.Text = Convert.ToString(productRow.Cells[0].Value);
            ModifyProductNameField.Text = Convert.ToString(productRow.Cells[1].Value);
            ModifyProductPriceCostField.Text = Convert.ToString(productRow.Cells[2].Value);
            ModifyProductInventoryField.Text = Convert.ToString(productRow.Cells[3].Value);
            ModifyProductMinField.Text = Convert.ToString(productRow.Cells[4].Value);
            ModifyProductMaxField.Text = Convert.ToString(productRow.Cells[5].Value);

            //Product ID
            productid = Convert.ToInt32(productRow.Cells[0].Value);
            product = Inventory.Products[productid];
        }

        private void ModifyProductCancelButton_Click(object sender, EventArgs e)
        {
            while (associatedproductscounter > 0)
            {
                Product.AssociatedParts.RemoveAt(0);
                associatedproductscounter--;
            }

            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            Visible = false;
        }

        private void ModifyProductSaveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ModifyProductInventoryField.Text, out int inventoryvalue) &&
                int.TryParse(ModifyProductMaxField.Text, out int maxvalue) &&
                int.TryParse(ModifyProductMinField.Text, out int minvalue))
            {
                if (maxvalue >= inventoryvalue && minvalue <= inventoryvalue)
                {
                    validationlabel.Text = "Valid input.";
                    validationlabel.ForeColor = System.Drawing.Color.Green;
                    validationlabel.Visible = true;

                    //Input Values
                    int idfield = Convert.ToInt32(ModifyProductIDField.Text);
                    string namefield = ModifyProductNameField.Text;
                    int inventoryfield = Convert.ToInt32(ModifyProductInventoryField.Text);
                    decimal pricefield = Convert.ToDecimal(ModifyProductPriceCostField.Text);
                    int minfield = Convert.ToInt32(ModifyProductMinField.Text);
                    int maxfield = Convert.ToInt32(ModifyProductMaxField.Text);
                    //BindingList<Part> associatedParts = product.AssociatedParts;

                    //Create Product
                    product = new Product(productid, namefield, pricefield, inventoryfield, minfield, maxfield);
                    inventory.UpdateProduct(productid, product);

                    //Return to Main Screen
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                    Visible = false;
                }
                else
                {
                    validationlabel.Text = "Invalid input.";
                    validationlabel.ForeColor = System.Drawing.Color.Red;
                    validationlabel.Visible = true;
                }
            }
        }

        private void AddProductAddButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow productRow = CandidatePartsGridView.SelectedRows[0];
            Part part = (Part)productRow.DataBoundItem;
            product.AddAssociatedPart(part);
            associatedproductscounter++;
        }

        private void ModifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow associatedPartRow = AssociatedPartsGridView.SelectedRows[0];
                Part part = (Part)associatedPartRow.DataBoundItem;
                Product.AssociatedParts.Remove(part);
            } catch
            {
                MessageBox.Show("Please select a part to delete.");
            }
            
        }

        private void ModifyProductCandidatePartSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = ModifyProductCandidatePartSearchBar.Text.ToLower();
            var filtered = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
            Inventory.FilteredList = new BindingList<Part>(filtered);
            CandidatePartsGridView.DataSource = Inventory.FilteredList;
        }
    }
}
