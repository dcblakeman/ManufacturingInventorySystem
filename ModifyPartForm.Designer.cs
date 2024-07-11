namespace ManufacturingInventorySystem
{
    partial class ModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ModifyPartGroup = new System.Windows.Forms.GroupBox();
            this.ModifyPartMinField = new System.Windows.Forms.MaskedTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.ModifyPartIDField = new System.Windows.Forms.MaskedTextBox();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.ModifyPartNameField = new System.Windows.Forms.MaskedTextBox();
            this.IDFieldLabel = new System.Windows.Forms.Label();
            this.ModifyPartInventoryField = new System.Windows.Forms.MaskedTextBox();
            this.NameFieldLabel = new System.Windows.Forms.Label();
            this.ModifyPartPriceField = new System.Windows.Forms.MaskedTextBox();
            this.InventoryFieldLabel = new System.Windows.Forms.Label();
            this.ModifyPartMachineIDCompanyField = new System.Windows.Forms.MaskedTextBox();
            this.PriceCostFieldLabel = new System.Windows.Forms.Label();
            this.MaxFieldLabel = new System.Windows.Forms.Label();
            this.ModifyPartMaxField = new System.Windows.Forms.MaskedTextBox();
            this.MinFieldLabel = new System.Windows.Forms.Label();
            this.MachineCompany = new System.Windows.Forms.Label();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validationlabel = new System.Windows.Forms.Label();
            this.inhouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outsourcedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifyPartGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyPartGroup
            // 
            this.ModifyPartGroup.Controls.Add(this.validationlabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartMinField);
            this.ModifyPartGroup.Controls.Add(this.CancelButton);
            this.ModifyPartGroup.Controls.Add(this.InHouseRadioButton);
            this.ModifyPartGroup.Controls.Add(this.SaveButton);
            this.ModifyPartGroup.Controls.Add(this.OutsourcedRadioButton);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartIDField);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartLabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartNameField);
            this.ModifyPartGroup.Controls.Add(this.IDFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartInventoryField);
            this.ModifyPartGroup.Controls.Add(this.NameFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartPriceField);
            this.ModifyPartGroup.Controls.Add(this.InventoryFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartMachineIDCompanyField);
            this.ModifyPartGroup.Controls.Add(this.PriceCostFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.MaxFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.ModifyPartMaxField);
            this.ModifyPartGroup.Controls.Add(this.MinFieldLabel);
            this.ModifyPartGroup.Controls.Add(this.MachineCompany);
            this.ModifyPartGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Min", true));
            this.ModifyPartGroup.Location = new System.Drawing.Point(44, 34);
            this.ModifyPartGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartGroup.Name = "ModifyPartGroup";
            this.ModifyPartGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ModifyPartGroup.Size = new System.Drawing.Size(520, 458);
            this.ModifyPartGroup.TabIndex = 25;
            this.ModifyPartGroup.TabStop = false;            // 
            // ModifyPartMinField
            // 
            this.ModifyPartMinField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Min", true));
            this.ModifyPartMinField.Location = new System.Drawing.Point(425, 298);
            this.ModifyPartMinField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartMinField.Name = "ModifyPartMinField";
            this.ModifyPartMinField.Size = new System.Drawing.Size(84, 26);
            this.ModifyPartMinField.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(426, 397);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 46);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Location = new System.Drawing.Point(205, 26);
            this.InHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(100, 24);
            this.InHouseRadioButton.TabIndex = 6;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(308, 397);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 46);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OutsourcedRadioButton
            // 
            this.OutsourcedRadioButton.AutoSize = true;
            this.OutsourcedRadioButton.Location = new System.Drawing.Point(342, 27);
            this.OutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            this.OutsourcedRadioButton.Size = new System.Drawing.Size(117, 24);
            this.OutsourcedRadioButton.TabIndex = 7;
            this.OutsourcedRadioButton.Text = "Outsourced";
            this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.OutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // ModifyPartIDField
            // 
            this.ModifyPartIDField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "PartId", true));
            this.ModifyPartIDField.Location = new System.Drawing.Point(228, 131);
            this.ModifyPartIDField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartIDField.Name = "ModifyPartIDField";
            this.ModifyPartIDField.ReadOnly = true;
            this.ModifyPartIDField.Size = new System.Drawing.Size(163, 26);
            this.ModifyPartIDField.TabIndex = 21;
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModifyPartLabel.Location = new System.Drawing.Point(9, 21);
            this.ModifyPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(133, 29);
            this.ModifyPartLabel.TabIndex = 8;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPartNameField
            // 
            this.ModifyPartNameField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Name", true));
            this.ModifyPartNameField.Location = new System.Drawing.Point(228, 173);
            this.ModifyPartNameField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartNameField.Name = "ModifyPartNameField";
            this.ModifyPartNameField.Size = new System.Drawing.Size(163, 26);
            this.ModifyPartNameField.TabIndex = 20;
            // 
            // IDFieldLabel
            // 
            this.IDFieldLabel.AutoSize = true;
            this.IDFieldLabel.Location = new System.Drawing.Point(92, 126);
            this.IDFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDFieldLabel.Name = "IDFieldLabel";
            this.IDFieldLabel.Size = new System.Drawing.Size(26, 20);
            this.IDFieldLabel.TabIndex = 9;
            this.IDFieldLabel.Text = "ID";
            // 
            // ModifyPartInventoryField
            // 
            this.ModifyPartInventoryField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "InStock", true));
            this.ModifyPartInventoryField.Location = new System.Drawing.Point(228, 214);
            this.ModifyPartInventoryField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartInventoryField.Name = "ModifyPartInventoryField";
            this.ModifyPartInventoryField.Size = new System.Drawing.Size(163, 26);
            this.ModifyPartInventoryField.TabIndex = 19;
            // 
            // NameFieldLabel
            // 
            this.NameFieldLabel.AutoSize = true;
            this.NameFieldLabel.Location = new System.Drawing.Point(92, 169);
            this.NameFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFieldLabel.Name = "NameFieldLabel";
            this.NameFieldLabel.Size = new System.Drawing.Size(51, 20);
            this.NameFieldLabel.TabIndex = 10;
            this.NameFieldLabel.Text = "Name";
            // 
            // ModifyPartPriceField
            // 
            this.ModifyPartPriceField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Price", true));
            this.ModifyPartPriceField.Location = new System.Drawing.Point(228, 256);
            this.ModifyPartPriceField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartPriceField.Name = "ModifyPartPriceField";
            this.ModifyPartPriceField.Size = new System.Drawing.Size(163, 26);
            this.ModifyPartPriceField.TabIndex = 18;
            // 
            // InventoryFieldLabel
            // 
            this.InventoryFieldLabel.AutoSize = true;
            this.InventoryFieldLabel.Location = new System.Drawing.Point(92, 211);
            this.InventoryFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryFieldLabel.Name = "InventoryFieldLabel";
            this.InventoryFieldLabel.Size = new System.Drawing.Size(74, 20);
            this.InventoryFieldLabel.TabIndex = 11;
            this.InventoryFieldLabel.Text = "Inventory";
            // 
            // ModifyPartMachineIDCompanyField
            // 
            this.ModifyPartMachineIDCompanyField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "MachineID", true));
            this.ModifyPartMachineIDCompanyField.Location = new System.Drawing.Point(228, 339);
            this.ModifyPartMachineIDCompanyField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartMachineIDCompanyField.Name = "ModifyPartMachineIDCompanyField";
            this.ModifyPartMachineIDCompanyField.Size = new System.Drawing.Size(163, 26);
            this.ModifyPartMachineIDCompanyField.TabIndex = 17;
            // 
            // PriceCostFieldLabel
            // 
            this.PriceCostFieldLabel.AutoSize = true;
            this.PriceCostFieldLabel.Location = new System.Drawing.Point(92, 254);
            this.PriceCostFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceCostFieldLabel.Name = "PriceCostFieldLabel";
            this.PriceCostFieldLabel.Size = new System.Drawing.Size(89, 20);
            this.PriceCostFieldLabel.TabIndex = 12;
            this.PriceCostFieldLabel.Text = "Price / Cost";
            // 
            // MaxFieldLabel
            // 
            this.MaxFieldLabel.AutoSize = true;
            this.MaxFieldLabel.Location = new System.Drawing.Point(92, 296);
            this.MaxFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxFieldLabel.Name = "MaxFieldLabel";
            this.MaxFieldLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxFieldLabel.TabIndex = 13;
            this.MaxFieldLabel.Text = "Max";
            // 
            // ModifyPartMaxField
            // 
            this.ModifyPartMaxField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Max", true));
            this.ModifyPartMaxField.Location = new System.Drawing.Point(228, 298);
            this.ModifyPartMaxField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartMaxField.Name = "ModifyPartMaxField";
            this.ModifyPartMaxField.Size = new System.Drawing.Size(84, 26);
            this.ModifyPartMaxField.TabIndex = 22;
            // 
            // MinFieldLabel
            // 
            this.MinFieldLabel.AutoSize = true;
            this.MinFieldLabel.Location = new System.Drawing.Point(355, 300);
            this.MinFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinFieldLabel.Name = "MinFieldLabel";
            this.MinFieldLabel.Size = new System.Drawing.Size(34, 20);
            this.MinFieldLabel.TabIndex = 14;
            this.MinFieldLabel.Text = "Min";
            // 
            // MachineCompany
            // 
            this.MachineCompany.AutoSize = true;
            this.MachineCompany.Location = new System.Drawing.Point(94, 338);
            this.MachineCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MachineCompany.Name = "MachineCompany";
            this.MachineCompany.Size = new System.Drawing.Size(40, 20);
            this.MachineCompany.TabIndex = 15;
            this.MachineCompany.Text = "Test";
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            // 
            // validationlabel
            // 
            this.validationlabel.AutoSize = true;
            this.validationlabel.Location = new System.Drawing.Point(402, 214);
            this.validationlabel.Name = "validationlabel";
            this.validationlabel.Size = new System.Drawing.Size(118, 20);
            this.validationlabel.TabIndex = 30;
            this.validationlabel.Text = "ValidationLabel";
            this.validationlabel.Visible = false;
            // 
            // inhouseBindingSource
            // 
            this.inhouseBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Inhouse);
            // 
            // outsourcedBindingSource
            // 
            this.outsourcedBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Outsourced);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 533);
            this.Controls.Add(this.ModifyPartGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ModifyPartGroup.ResumeLayout(false);
            this.ModifyPartGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        //#endregion
        private System.Windows.Forms.GroupBox ModifyPartGroup;
        private System.Windows.Forms.MaskedTextBox ModifyPartMinField;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton OutsourcedRadioButton;
        private System.Windows.Forms.MaskedTextBox ModifyPartIDField;
        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.MaskedTextBox ModifyPartNameField;
        private System.Windows.Forms.Label IDFieldLabel;
        private System.Windows.Forms.MaskedTextBox ModifyPartInventoryField;
        private System.Windows.Forms.Label NameFieldLabel;
        private System.Windows.Forms.MaskedTextBox ModifyPartPriceField;
        private System.Windows.Forms.Label InventoryFieldLabel;
        private System.Windows.Forms.MaskedTextBox ModifyPartMachineIDCompanyField;
        private System.Windows.Forms.Label PriceCostFieldLabel;
        private System.Windows.Forms.Label MaxFieldLabel;
        private System.Windows.Forms.MaskedTextBox ModifyPartMaxField;
        private System.Windows.Forms.Label MinFieldLabel;
        //private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        //private InventoryDatabaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        public System.Windows.Forms.RadioButton InHouseRadioButton;
        private System.Windows.Forms.BindingSource outsourcedBindingSource;
        private System.Windows.Forms.BindingSource inhouseBindingSource;
        private System.Windows.Forms.Label MachineCompany;
        private System.Windows.Forms.Label validationlabel;
    }
}