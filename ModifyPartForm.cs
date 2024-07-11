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
    public partial class ModifyPart : Form
    {
        public string InHouseOrOutsourced { get; private set; }
        private DataGridViewRow oneRow;
        Inventory inventory = new Inventory();
        Part part;
        int partid;
        Inhouse inhousepart;
        Outsourced outsourcedpart;

        public ModifyPart(DataGridViewRow oneRow, string header)
        {
            InitializeComponent();
            this.oneRow = oneRow;
            partid = Convert.ToInt32(oneRow.Cells[0].Value);
            Part part = Inventory.AllParts[partid];

            string type = Convert.ToString(part.GetType());
            if(type == "ManufacturingInventorySystem.Models.Inhouse")
            {
                InHouseRadioButton.Checked = true;
                MachineCompany.Text = "Machine ID";
                ModifyPartMachineIDCompanyField.Text = part.GetType().GetProperty("MachineID").GetValue(part).ToString();
            }
            else
            {
                OutsourcedRadioButton.Checked = true;
                MachineCompany.Text = "Company Name";
                ModifyPartMachineIDCompanyField.Text = part.GetType().GetProperty("CompanyName").GetValue(part).ToString();
            }
            ModifyPartIDField.Text = Convert.ToString(oneRow.Cells[0].Value);
            ModifyPartNameField.Text = Convert.ToString(oneRow.Cells[1].Value);
            ModifyPartPriceField.Text = Convert.ToString(oneRow.Cells[2].Value);
            ModifyPartInventoryField.Text = Convert.ToString(oneRow.Cells[3].Value);
            ModifyPartMinField.Text = Convert.ToString(oneRow.Cells[4].Value);
            ModifyPartMaxField.Text = Convert.ToString(oneRow.Cells[5].Value);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            Visible = false;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Remove Old Part
            inventory.RemovePart(partid);

            if (int.TryParse(ModifyPartInventoryField.Text, out int inventoryvalue) &&
                int.TryParse(ModifyPartMaxField.Text, out int maxvalue) &&
                int.TryParse(ModifyPartMinField.Text, out int minvalue))
            {   
                //Valid Input
                if (maxvalue >= inventoryvalue && minvalue <= inventoryvalue)
                {
                    //Input Values
                    string name = ModifyPartNameField.Text;
                    decimal price = Convert.ToDecimal(ModifyPartPriceField.Text);
                    int instock = Convert.ToInt32(ModifyPartInventoryField.Text);
                    int min = Convert.ToInt32(ModifyPartMinField.Text);
                    int max = Convert.ToInt32(ModifyPartMaxField.Text);

                    if (InHouseRadioButton.Checked)
                    {
                        try
                        {
                            int machineID = Convert.ToInt32(ModifyPartMachineIDCompanyField.Text);
                            inhousepart = new Inhouse(Convert.ToInt32(ModifyPartIDField.Text), name, instock, price, min, max, machineID);
                            inventory.AddPart(inhousepart);
                        } catch (Exception ex)
                        {
                            MessageBox.Show("Please enter a valid Machine ID.");
                        }
                        
                   
                    }
                    else
                    {
                        string companyName = ModifyPartMachineIDCompanyField.Text;
                        outsourcedpart = new Outsourced(Convert.ToInt32(ModifyPartIDField.Text), name, instock, price, min, max, companyName);
                        inventory.AddPart(outsourcedpart);

                    }

                    //Return to Main Screen
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                    Visible = false;
                }
                //Invalid Input
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
