namespace ManufacturingInventorySystem
{
    partial class AddPart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddPartGroupBox = new System.Windows.Forms.GroupBox();
            this.validationlabel = new System.Windows.Forms.Label();
            this.MachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.inhouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MachineCompany = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.MaskedTextBox();
            this.NameField = new System.Windows.Forms.MaskedTextBox();
            this.InventoryField = new System.Windows.Forms.MaskedTextBox();
            this.PriceCostField = new System.Windows.Forms.MaskedTextBox();
            this.AddPartMinField = new System.Windows.Forms.MaskedTextBox();
            this.MaxField = new System.Windows.Forms.MaskedTextBox();
            this.AddPartMinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxFieldLabel = new System.Windows.Forms.Label();
            this.PriceCostFieldLabel = new System.Windows.Forms.Label();
            this.InventoryFieldLabel = new System.Windows.Forms.Label();
            this.NameFieldLabel = new System.Windows.Forms.Label();
            this.IDFieldLabel = new System.Windows.Forms.Label();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPartGroupBox
            // 
            this.AddPartGroupBox.Controls.Add(this.validationlabel);
            this.AddPartGroupBox.Controls.Add(this.MachineCompanyTextBox);
            this.AddPartGroupBox.Controls.Add(this.AddPartLabel);
            this.AddPartGroupBox.Controls.Add(this.OutsourcedRadioButton);
            this.AddPartGroupBox.Controls.Add(this.MachineCompany);
            this.AddPartGroupBox.Controls.Add(this.SaveButton);
            this.AddPartGroupBox.Controls.Add(this.InHouseRadioButton);
            this.AddPartGroupBox.Controls.Add(this.CancelButton);
            this.AddPartGroupBox.Controls.Add(this.IDField);
            this.AddPartGroupBox.Controls.Add(this.NameField);
            this.AddPartGroupBox.Controls.Add(this.InventoryField);
            this.AddPartGroupBox.Controls.Add(this.PriceCostField);
            this.AddPartGroupBox.Controls.Add(this.AddPartMinField);
            this.AddPartGroupBox.Controls.Add(this.MaxField);
            this.AddPartGroupBox.Controls.Add(this.AddPartMinLabel);
            this.AddPartGroupBox.Controls.Add(this.label1);
            this.AddPartGroupBox.Controls.Add(this.MaxFieldLabel);
            this.AddPartGroupBox.Controls.Add(this.PriceCostFieldLabel);
            this.AddPartGroupBox.Controls.Add(this.InventoryFieldLabel);
            this.AddPartGroupBox.Controls.Add(this.NameFieldLabel);
            this.AddPartGroupBox.Controls.Add(this.IDFieldLabel);
            this.AddPartGroupBox.Location = new System.Drawing.Point(32, 19);
            this.AddPartGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartGroupBox.Name = "AddPartGroupBox";
            this.AddPartGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.AddPartGroupBox.Size = new System.Drawing.Size(544, 443);
            this.AddPartGroupBox.TabIndex = 0;
            this.AddPartGroupBox.TabStop = false;
            // 
            // validationlabel
            // 
            this.validationlabel.AutoSize = true;
            this.validationlabel.Location = new System.Drawing.Point(404, 190);
            this.validationlabel.Name = "validationlabel";
            this.validationlabel.Size = new System.Drawing.Size(118, 20);
            this.validationlabel.TabIndex = 25;
            this.validationlabel.Text = "ValidationLabel";
            this.validationlabel.Visible = false;
            // 
            // MachineCompanyTextBox
            // 
            this.MachineCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "MachineID", true));
            this.MachineCompanyTextBox.Location = new System.Drawing.Point(206, 321);
            this.MachineCompanyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MachineCompanyTextBox.Name = "MachineCompanyTextBox";
            this.MachineCompanyTextBox.Size = new System.Drawing.Size(145, 26);
            this.MachineCompanyTextBox.TabIndex = 6;
            // 
            // inhouseBindingSource
            // 
            this.inhouseBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Inhouse);
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddPartLabel.Location = new System.Drawing.Point(4, 12);
            this.AddPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(124, 32);
            this.AddPartLabel.TabIndex = 24;
            this.AddPartLabel.Text = "Add Part";
            // 
            // OutsourcedRadioButton
            // 
            this.OutsourcedRadioButton.AutoSize = true;
            this.OutsourcedRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.outsourcedBindingSource, "CompanyName", true));
            this.OutsourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OutsourcedRadioButton.Location = new System.Drawing.Point(305, 57);
            this.OutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            this.OutsourcedRadioButton.Size = new System.Drawing.Size(117, 24);
            this.OutsourcedRadioButton.TabIndex = 7;
            this.OutsourcedRadioButton.TabStop = true;
            this.OutsourcedRadioButton.Text = "Outsourced";
            this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.OutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // outsourcedBindingSource
            // 
            this.outsourcedBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Outsourced);
            // 
            // MachineCompany
            // 
            this.MachineCompany.AutoSize = true;
            this.MachineCompany.Location = new System.Drawing.Point(70, 326);
            this.MachineCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MachineCompany.Name = "MachineCompany";
            this.MachineCompany.Size = new System.Drawing.Size(90, 20);
            this.MachineCompany.TabIndex = 12;
            this.MachineCompany.Text = "Machine ID";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(290, 371);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 46);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Checked = true;
            this.InHouseRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inhouseBindingSource, "MachineID", true));
            this.InHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.InHouseRadioButton.Location = new System.Drawing.Point(177, 57);
            this.InHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(100, 24);
            this.InHouseRadioButton.TabIndex = 6;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(417, 371);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 46);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDField
            // 
            this.IDField.Location = new System.Drawing.Point(206, 111);
            this.IDField.Margin = new System.Windows.Forms.Padding(2);
            this.IDField.Name = "IDField";
            this.IDField.ReadOnly = true;
            this.IDField.Size = new System.Drawing.Size(163, 26);
            this.IDField.TabIndex = 19;
            // 
            // NameField
            // 
            this.NameField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Name", true));
            this.NameField.Location = new System.Drawing.Point(206, 153);
            this.NameField.Margin = new System.Windows.Forms.Padding(2);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(163, 26);
            this.NameField.TabIndex = 1;
            // 
            // InventoryField
            // 
            this.InventoryField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "InStock", true));
            this.InventoryField.Location = new System.Drawing.Point(206, 194);
            this.InventoryField.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryField.Name = "InventoryField";
            this.InventoryField.Size = new System.Drawing.Size(163, 26);
            this.InventoryField.TabIndex = 2;
            // 
            // PriceCostField
            // 
            this.PriceCostField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Price", true));
            this.PriceCostField.Location = new System.Drawing.Point(206, 236);
            this.PriceCostField.Margin = new System.Windows.Forms.Padding(2);
            this.PriceCostField.Name = "PriceCostField";
            this.PriceCostField.Size = new System.Drawing.Size(163, 26);
            this.PriceCostField.TabIndex = 3;
            // 
            // AddPartMinField
            // 
            this.AddPartMinField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Min", true));
            this.AddPartMinField.Location = new System.Drawing.Point(404, 278);
            this.AddPartMinField.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartMinField.Name = "AddPartMinField";
            this.AddPartMinField.Size = new System.Drawing.Size(84, 26);
            this.AddPartMinField.TabIndex = 5;
            // 
            // MaxField
            // 
            this.MaxField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inhouseBindingSource, "Max", true));
            this.MaxField.Location = new System.Drawing.Point(206, 278);
            this.MaxField.Margin = new System.Windows.Forms.Padding(2);
            this.MaxField.Name = "MaxField";
            this.MaxField.Size = new System.Drawing.Size(84, 26);
            this.MaxField.TabIndex = 4;
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Location = new System.Drawing.Point(333, 280);
            this.AddPartMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.AddPartMinLabel.TabIndex = 11;
            this.AddPartMinLabel.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Machine ID";
            // 
            // MaxFieldLabel
            // 
            this.MaxFieldLabel.AutoSize = true;
            this.MaxFieldLabel.Location = new System.Drawing.Point(70, 276);
            this.MaxFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxFieldLabel.Name = "MaxFieldLabel";
            this.MaxFieldLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxFieldLabel.TabIndex = 10;
            this.MaxFieldLabel.Text = "Max";
            // 
            // PriceCostFieldLabel
            // 
            this.PriceCostFieldLabel.AutoSize = true;
            this.PriceCostFieldLabel.Location = new System.Drawing.Point(70, 234);
            this.PriceCostFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceCostFieldLabel.Name = "PriceCostFieldLabel";
            this.PriceCostFieldLabel.Size = new System.Drawing.Size(89, 20);
            this.PriceCostFieldLabel.TabIndex = 9;
            this.PriceCostFieldLabel.Text = "Price / Cost";
            // 
            // InventoryFieldLabel
            // 
            this.InventoryFieldLabel.AutoSize = true;
            this.InventoryFieldLabel.Location = new System.Drawing.Point(70, 191);
            this.InventoryFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryFieldLabel.Name = "InventoryFieldLabel";
            this.InventoryFieldLabel.Size = new System.Drawing.Size(74, 20);
            this.InventoryFieldLabel.TabIndex = 8;
            this.InventoryFieldLabel.Text = "Inventory";
            // 
            // NameFieldLabel
            // 
            this.NameFieldLabel.AutoSize = true;
            this.NameFieldLabel.Location = new System.Drawing.Point(70, 149);
            this.NameFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFieldLabel.Name = "NameFieldLabel";
            this.NameFieldLabel.Size = new System.Drawing.Size(51, 20);
            this.NameFieldLabel.TabIndex = 13;
            this.NameFieldLabel.Text = "Name";
            // 
            // IDFieldLabel
            // 
            this.IDFieldLabel.AutoSize = true;
            this.IDFieldLabel.Location = new System.Drawing.Point(70, 106);
            this.IDFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDFieldLabel.Name = "IDFieldLabel";
            this.IDFieldLabel.Size = new System.Drawing.Size(26, 20);
            this.IDFieldLabel.TabIndex = 14;
            this.IDFieldLabel.Text = "ID";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Part);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 487);
            this.Controls.Add(this.AddPartGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddParts_Load);
            this.AddPartGroupBox.ResumeLayout(false);
            this.AddPartGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddPartGroupBox;
        private System.Windows.Forms.RadioButton OutsourcedRadioButton;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox IDField;
        private System.Windows.Forms.MaskedTextBox NameField;
        private System.Windows.Forms.MaskedTextBox InventoryField;
        private System.Windows.Forms.MaskedTextBox PriceCostField;
        private System.Windows.Forms.MaskedTextBox AddPartMinField;
        private System.Windows.Forms.MaskedTextBox MaxField;
        private System.Windows.Forms.Label AddPartMinLabel;
        private System.Windows.Forms.Label MaxFieldLabel;
        private System.Windows.Forms.Label PriceCostFieldLabel;
        private System.Windows.Forms.Label InventoryFieldLabel;
        private System.Windows.Forms.Label NameFieldLabel;
        private System.Windows.Forms.Label IDFieldLabel;
        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.Label MachineCompany;
        private System.Windows.Forms.TextBox MachineCompanyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource outsourcedBindingSource;
        private System.Windows.Forms.BindingSource inhouseBindingSource;
        private System.Windows.Forms.Label validationlabel;
    }
}