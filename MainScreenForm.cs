using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ManufacturingInventorySystem.Models;

namespace ManufacturingInventorySystem
{
    public partial class MainScreen : Form
    {

        Inventory inventory = new Inventory();
        Outsourced part = new Outsourced();
        Inhouse part1 = new Inhouse();

        public MainScreen()
        {
            InitializeComponent();
        }

        public void MainScreen_Load(object sender, EventArgs e)
        {
            List<Part> list = Inventory.AllParts.ToList();
            list.Sort((x, y) => x.PartId.CompareTo(y.PartId));
            BindingList<Part> partList = new BindingList<Part>(list);
            PartsDataGrid.DataSource = partList;

            List<Product> productList = Inventory.Products.ToList();
            productList.Sort((x, y) => x.ProductId.CompareTo(y.ProductId));
            BindingList<Product> productList1 = new BindingList<Product>(productList);
            ProductsDataGrid.DataSource = Inventory.Products;
        }
        public void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductsModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow productRow = ProductsDataGrid.SelectedRows[0];
                ModifyProduct modifyProduct = new ModifyProduct(productRow);
                modifyProduct.Show();
                Visible = false;
            } catch
            {
                MessageBox.Show("Please select a product to modify.");
            }
            
        }

        public void ProductsAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.Show();
            Visible = false;
        }

        private void PartsModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow oneRow = PartsDataGrid.SelectedRows[0];
                DataGridTextBoxColumn dataGridTextBoxColumn = new DataGridTextBoxColumn();
                if (dataGridTextBoxColumn.HeaderText == "Machine ID")
                {
                    ModifyPart modifyPart = new ModifyPart(oneRow, "Machine ID");
                    modifyPart.Show();
                    Visible = false;
                }
                else
                {
                    ModifyPart modifyPart = new ModifyPart(oneRow, "Company Name");
                    modifyPart.Show();
                    Visible = false;
                }
            } catch
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        public void PartsAddButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
            Visible = false;
        }

        public void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oneRow in PartsDataGrid.SelectedRows)
            {
                PartsDataGrid.Rows.RemoveAt(oneRow.Index);
            }
        }

        public void PartsSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = PartsSearchTextBox.Text.ToLower();
            var filtered = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
            Inventory.FilteredList = new BindingList<Part>(filtered);
            PartsDataGrid.DataSource = Inventory.FilteredList;

        }

        public void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = ProductsSearchTextBox.Text.ToLower();
            var filtered = Inventory.Products.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
            Inventory.ProductFilteredList= new BindingList<Product>(filtered);
            ProductsDataGrid.DataSource = Inventory.ProductFilteredList;
        }
        public void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow oneRow in ProductsDataGrid.SelectedRows)
            {
                
                ProductsDataGrid.Rows.RemoveAt(oneRow.Index);
            }
        }
    }
}
