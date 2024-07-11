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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ManufacturingInventorySystem.Models;

namespace ManufacturingInventorySystem
{
    public partial class AddPart : Form
    {
        //Variables
        string InHouseOrOutsourced;
        public static int idfield = 3;
        Inventory inventory = new Inventory();

        public AddPart()
        {
            InitializeComponent();
            IDField.Text = Convert.ToString(idfield);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            

        }

        private void AddParts_Load(object sender, EventArgs e)
        {
            MachineCompany.Text = InHouseOrOutsourced;
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InHouseOrOutsourced = "Machine ID";
            MachineCompany.Text = InHouseOrOutsourced;
            
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InHouseOrOutsourced = "Company Name";
            MachineCompany.Text = InHouseOrOutsourced;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            Visible = false;
        }

        private void InventoryField_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(InventoryField.Text, out int inventoryvalue) &&
                int.TryParse(MaxField.Text, out int maxvalue) &&
                int.TryParse(AddPartMinField.Text, out int minvalue))
            {
                if (maxvalue >= inventoryvalue && minvalue <= inventoryvalue)
                {
                    validationlabel.Text = "Valid input.";
                    validationlabel.ForeColor = System.Drawing.Color.Green;
                    validationlabel.Visible = true;
                }
                else
                {
                    validationlabel.Text = "Invalid input.";
                    validationlabel.ForeColor = System.Drawing.Color.Red;
                    validationlabel.Visible = true;
                }
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Input Values
                if (string.IsNullOrWhiteSpace(NameField.Text))
                {
                    MessageBox.Show("Field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameField.Focus(); // Set focus back to the textbox
                }
                    // Proceed with the form submission or other logic
                    string namefield = NameField.Text;
                    int inventoryfield = Convert.ToInt32(InventoryField.Text);
                    decimal pricefield = Convert.ToDecimal(PriceCostField.Text);
                    int minfield = Convert.ToInt32(AddPartMinField.Text);
                    Int32.TryParse(MaxField.Text, out int maxfield);

                

                if (int.TryParse(InventoryField.Text, out int inventoryvalue) &&
                int.TryParse(MaxField.Text, out int maxvalue) &&
                int.TryParse(AddPartMinField.Text, out int minvalue))
                {
                    if (maxvalue >= inventoryvalue && minvalue <= inventoryvalue)
                    {
                        validationlabel.Text = "Valid input.";
                        validationlabel.ForeColor = System.Drawing.Color.Green;
                        validationlabel.Visible = true;

                        if (InHouseRadioButton.Checked)
                        {
                            int machinecompany = Convert.ToInt32(MachineCompanyTextBox.Text);
                            Inhouse part = new Inhouse(idfield, namefield, inventoryfield, pricefield, minfield, maxfield, machinecompany);
                            inventory.AddPart(part);
                            idfield++;
                        }
                        else
                        {
                            string machinecompany = MachineCompanyTextBox.Text;
                            Outsourced part = new Outsourced(idfield, namefield, inventoryfield, pricefield, minfield, maxfield, machinecompany);
                            inventory.AddPart(part);
                            idfield++;
                        }

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
            } catch (FormatException)
            {
                validationlabel.Text = "Invalid input.";
                validationlabel.ForeColor = System.Drawing.Color.Red;
                validationlabel.Visible = true;
                return;
            }
            

            
        }
    }
}
