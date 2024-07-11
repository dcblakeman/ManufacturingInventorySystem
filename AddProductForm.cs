using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManufacturingInventorySystem.Models;

namespace ManufacturingInventorySystem
{
    public partial class AddProductForm : Form
    {
        int idfield = 3;
        Inventory inventory = new Inventory();
        BindingList<Part> associatedParts = new BindingList<Part>();
        Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CandidatePartsGridView.DataSource = Inventory.AllParts;
            AssociatedPartsGridView.DataSource = Product.AssociatedParts;
            AddProductIDField.Text = Convert.ToString(idfield);

        }

        private void AddProductDeleteButton_Click(object sender, EventArgs e)
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

        private void AddProductCancelButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            Visible = false;
        }

        private void AddProductsSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = AddProductSearchBar.Text.ToLower();
            var filtered = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
            Inventory.FilteredList = new BindingList<Part>(filtered);
            CandidatePartsGridView.DataSource = Inventory.FilteredList;
        }

        private void AddProductAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow productRow = CandidatePartsGridView.SelectedRows[0];
                Part part = (Part)productRow.DataBoundItem;
                product.AddAssociatedPart(part);
            } catch
            {
                MessageBox.Show("Please select a part to add.");
            }
            

        }

        private void AddProductSaveButton_Click(object sender, EventArgs e)
        {
            //Inventory Validation
            if (int.TryParse(AddProductInventoryField.Text, out int inventoryvalue) &&
                int.TryParse(AddProductMaxField.Text, out int maxvalue) &&
                int.TryParse(AddProductMinField.Text, out int minvalue))
            {
                if (maxvalue >= inventoryvalue && minvalue <= inventoryvalue)
                {
                    validationlabel.Text = "Valid input.";
                    validationlabel.ForeColor = System.Drawing.Color.Green;
                    validationlabel.Visible = true;

                    //Input Values
                    int addproductidfield = idfield;
                    string addproductnamefield = AddProductNameField.Text;
                    decimal addproductpricecostfield = Convert.ToDecimal(AddProductPriceCostField.Text);
                    int addproductinventoryfield = Convert.ToInt32(AddProductInventoryField.Text);
                    int addproductminfield = Convert.ToInt32(AddProductMinField.Text);
                    int addproductmaxfield = Convert.ToInt32(AddProductMaxField.Text);

                    //Create Product
                    product = new Product(addproductidfield, addproductnamefield, addproductpricecostfield, addproductinventoryfield, addproductminfield, addproductmaxfield);
                    inventory.AddProduct(product);

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
    }
}


       

            
            
        

        