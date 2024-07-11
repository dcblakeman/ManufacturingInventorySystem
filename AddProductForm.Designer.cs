namespace ManufacturingInventorySystem
{
    partial class AddProductForm
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
            this.AddProductIDField = new System.Windows.Forms.MaskedTextBox();
            this.AddProductNameField = new System.Windows.Forms.MaskedTextBox();
            this.AddProductInventoryField = new System.Windows.Forms.MaskedTextBox();
            this.AddProductPriceCostField = new System.Windows.Forms.MaskedTextBox();
            this.AddProductMinField = new System.Windows.Forms.MaskedTextBox();
            this.AddProductMaxField = new System.Windows.Forms.MaskedTextBox();
            this.MinFieldLabel = new System.Windows.Forms.Label();
            this.MaxFieldLabel = new System.Windows.Forms.Label();
            this.PriceFieldLabel = new System.Windows.Forms.Label();
            this.InventoryFieldLabel = new System.Windows.Forms.Label();
            this.NameFieldLabel = new System.Windows.Forms.Label();
            this.IDFieldLabel = new System.Windows.Forms.Label();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.AddProductsCandidatePartsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.AddProductAddButton = new System.Windows.Forms.Button();
            this.AddProductDeleteButton = new System.Windows.Forms.Button();
            this.AddProductCancelButton = new System.Windows.Forms.Button();
            this.AddProductSaveButton = new System.Windows.Forms.Button();
            this.AddProductSearchBar = new System.Windows.Forms.TextBox();
            this.AddProductsSearchButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.validationlabel = new System.Windows.Forms.Label();
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductIDField
            // 
            this.AddProductIDField.Location = new System.Drawing.Point(207, 250);
            this.AddProductIDField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductIDField.Name = "AddProductIDField";
            this.AddProductIDField.ReadOnly = true;
            this.AddProductIDField.Size = new System.Drawing.Size(163, 26);
            this.AddProductIDField.TabIndex = 13;
            // 
            // AddProductNameField
            // 
            this.AddProductNameField.Location = new System.Drawing.Point(207, 292);
            this.AddProductNameField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductNameField.Name = "AddProductNameField";
            this.AddProductNameField.Size = new System.Drawing.Size(163, 26);
            this.AddProductNameField.TabIndex = 14;
            // 
            // AddProductInventoryField
            // 
            this.AddProductInventoryField.Location = new System.Drawing.Point(207, 334);
            this.AddProductInventoryField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductInventoryField.Name = "AddProductInventoryField";
            this.AddProductInventoryField.Size = new System.Drawing.Size(163, 26);
            this.AddProductInventoryField.TabIndex = 15;
            // 
            // AddProductPriceCostField
            // 
            this.AddProductPriceCostField.Location = new System.Drawing.Point(207, 375);
            this.AddProductPriceCostField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductPriceCostField.Name = "AddProductPriceCostField";
            this.AddProductPriceCostField.Size = new System.Drawing.Size(163, 26);
            this.AddProductPriceCostField.TabIndex = 16;
            // 
            // AddProductMinField
            // 
            this.AddProductMinField.Location = new System.Drawing.Point(404, 417);
            this.AddProductMinField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductMinField.Name = "AddProductMinField";
            this.AddProductMinField.Size = new System.Drawing.Size(84, 26);
            this.AddProductMinField.TabIndex = 18;
            // 
            // AddProductMaxField
            // 
            this.AddProductMaxField.Location = new System.Drawing.Point(207, 417);
            this.AddProductMaxField.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductMaxField.Name = "AddProductMaxField";
            this.AddProductMaxField.Size = new System.Drawing.Size(84, 26);
            this.AddProductMaxField.TabIndex = 19;
            // 
            // MinFieldLabel
            // 
            this.MinFieldLabel.AutoSize = true;
            this.MinFieldLabel.Location = new System.Drawing.Point(334, 419);
            this.MinFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinFieldLabel.Name = "MinFieldLabel";
            this.MinFieldLabel.Size = new System.Drawing.Size(34, 20);
            this.MinFieldLabel.TabIndex = 7;
            this.MinFieldLabel.Text = "Min";
            // 
            // MaxFieldLabel
            // 
            this.MaxFieldLabel.AutoSize = true;
            this.MaxFieldLabel.Location = new System.Drawing.Point(70, 415);
            this.MaxFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxFieldLabel.Name = "MaxFieldLabel";
            this.MaxFieldLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxFieldLabel.TabIndex = 8;
            this.MaxFieldLabel.Text = "Max";
            // 
            // PriceFieldLabel
            // 
            this.PriceFieldLabel.AutoSize = true;
            this.PriceFieldLabel.Location = new System.Drawing.Point(70, 373);
            this.PriceFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceFieldLabel.Name = "PriceFieldLabel";
            this.PriceFieldLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceFieldLabel.TabIndex = 9;
            this.PriceFieldLabel.Text = "Price";
            // 
            // InventoryFieldLabel
            // 
            this.InventoryFieldLabel.AutoSize = true;
            this.InventoryFieldLabel.Location = new System.Drawing.Point(70, 330);
            this.InventoryFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryFieldLabel.Name = "InventoryFieldLabel";
            this.InventoryFieldLabel.Size = new System.Drawing.Size(74, 20);
            this.InventoryFieldLabel.TabIndex = 10;
            this.InventoryFieldLabel.Text = "Inventory";
            // 
            // NameFieldLabel
            // 
            this.NameFieldLabel.AutoSize = true;
            this.NameFieldLabel.Location = new System.Drawing.Point(70, 288);
            this.NameFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFieldLabel.Name = "NameFieldLabel";
            this.NameFieldLabel.Size = new System.Drawing.Size(51, 20);
            this.NameFieldLabel.TabIndex = 11;
            this.NameFieldLabel.Text = "Name";
            // 
            // IDFieldLabel
            // 
            this.IDFieldLabel.AutoSize = true;
            this.IDFieldLabel.Location = new System.Drawing.Point(70, 246);
            this.IDFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDFieldLabel.Name = "IDFieldLabel";
            this.IDFieldLabel.Size = new System.Drawing.Size(26, 20);
            this.IDFieldLabel.TabIndex = 12;
            this.IDFieldLabel.Text = "ID";
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddProductLabel.Location = new System.Drawing.Point(19, 21);
            this.AddProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(145, 29);
            this.AddProductLabel.TabIndex = 22;
            this.AddProductLabel.Text = "Add Product";
            // 
            // AddProductsCandidatePartsLabel
            // 
            this.AddProductsCandidatePartsLabel.AutoSize = true;
            this.AddProductsCandidatePartsLabel.Location = new System.Drawing.Point(525, 44);
            this.AddProductsCandidatePartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductsCandidatePartsLabel.Name = "AddProductsCandidatePartsLabel";
            this.AddProductsCandidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.AddProductsCandidatePartsLabel.TabIndex = 25;
            this.AddProductsCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // CandidatePartsGridView
            // 
            this.CandidatePartsGridView.AllowUserToAddRows = false;
            this.CandidatePartsGridView.AllowUserToDeleteRows = false;
            this.CandidatePartsGridView.AllowUserToResizeColumns = false;
            this.CandidatePartsGridView.AllowUserToResizeRows = false;
            this.CandidatePartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatePartsGridView.Location = new System.Drawing.Point(529, 86);
            this.CandidatePartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CandidatePartsGridView.Name = "CandidatePartsGridView";
            this.CandidatePartsGridView.RowHeadersVisible = false;
            this.CandidatePartsGridView.RowHeadersWidth = 82;
            this.CandidatePartsGridView.RowTemplate.Height = 33;
            this.CandidatePartsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatePartsGridView.Size = new System.Drawing.Size(582, 180);
            this.CandidatePartsGridView.TabIndex = 23;
            // 
            // AssociatedPartsGridView
            // 
            this.AssociatedPartsGridView.AllowUserToAddRows = false;
            this.AssociatedPartsGridView.AllowUserToDeleteRows = false;
            this.AssociatedPartsGridView.AllowUserToResizeColumns = false;
            this.AssociatedPartsGridView.AllowUserToResizeRows = false;
            this.AssociatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGridView.Location = new System.Drawing.Point(529, 386);
            this.AssociatedPartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AssociatedPartsGridView.Name = "AssociatedPartsGridView";
            this.AssociatedPartsGridView.RowHeadersVisible = false;
            this.AssociatedPartsGridView.RowHeadersWidth = 82;
            this.AssociatedPartsGridView.RowTemplate.Height = 33;
            this.AssociatedPartsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGridView.Size = new System.Drawing.Size(582, 184);
            this.AssociatedPartsGridView.TabIndex = 26;
            // 
            // AddProductAddButton
            // 
            this.AddProductAddButton.Location = new System.Drawing.Point(1017, 286);
            this.AddProductAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductAddButton.Name = "AddProductAddButton";
            this.AddProductAddButton.Size = new System.Drawing.Size(82, 46);
            this.AddProductAddButton.TabIndex = 21;
            this.AddProductAddButton.Text = "Add";
            this.AddProductAddButton.UseVisualStyleBackColor = true;
            this.AddProductAddButton.Click += new System.EventHandler(this.AddProductAddButton_Click);
            // 
            // AddProductDeleteButton
            // 
            this.AddProductDeleteButton.Location = new System.Drawing.Point(1017, 598);
            this.AddProductDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductDeleteButton.Name = "AddProductDeleteButton";
            this.AddProductDeleteButton.Size = new System.Drawing.Size(82, 46);
            this.AddProductDeleteButton.TabIndex = 21;
            this.AddProductDeleteButton.Text = "Delete";
            this.AddProductDeleteButton.UseVisualStyleBackColor = true;
            this.AddProductDeleteButton.Click += new System.EventHandler(this.AddProductDeleteButton_Click);
            // 
            // AddProductCancelButton
            // 
            this.AddProductCancelButton.Location = new System.Drawing.Point(1017, 665);
            this.AddProductCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductCancelButton.Name = "AddProductCancelButton";
            this.AddProductCancelButton.Size = new System.Drawing.Size(82, 46);
            this.AddProductCancelButton.TabIndex = 21;
            this.AddProductCancelButton.Text = "Cancel";
            this.AddProductCancelButton.UseVisualStyleBackColor = true;
            this.AddProductCancelButton.Click += new System.EventHandler(this.AddProductCancelButton_Click);
            // 
            // AddProductSaveButton
            // 
            this.AddProductSaveButton.Location = new System.Drawing.Point(904, 665);
            this.AddProductSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductSaveButton.Name = "AddProductSaveButton";
            this.AddProductSaveButton.Size = new System.Drawing.Size(82, 46);
            this.AddProductSaveButton.TabIndex = 21;
            this.AddProductSaveButton.Text = "Save";
            this.AddProductSaveButton.UseVisualStyleBackColor = true;
            this.AddProductSaveButton.Click += new System.EventHandler(this.AddProductSaveButton_Click);
            // 
            // AddProductSearchBar
            // 
            this.AddProductSearchBar.Location = new System.Drawing.Point(873, 39);
            this.AddProductSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductSearchBar.Name = "AddProductSearchBar";
            this.AddProductSearchBar.Size = new System.Drawing.Size(238, 26);
            this.AddProductSearchBar.TabIndex = 28;
            // 
            // AddProductsSearchButton
            // 
            this.AddProductsSearchButton.Location = new System.Drawing.Point(746, 31);
            this.AddProductsSearchButton.Name = "AddProductsSearchButton";
            this.AddProductsSearchButton.Size = new System.Drawing.Size(91, 42);
            this.AddProductsSearchButton.TabIndex = 0;
            this.AddProductsSearchButton.Text = "Search";
            this.AddProductsSearchButton.Click += new System.EventHandler(this.AddProductsSearchButton_Click);
            // 
            // validationlabel
            // 
            this.validationlabel.AutoSize = true;
            this.validationlabel.Location = new System.Drawing.Point(389, 337);
            this.validationlabel.Name = "validationlabel";
            this.validationlabel.Size = new System.Drawing.Size(118, 20);
            this.validationlabel.TabIndex = 29;
            this.validationlabel.Text = "ValidationLabel";
            this.validationlabel.Visible = false;
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(ManufacturingInventorySystem.Models.Part);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Part);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(ManufacturingInventorySystem.Models.Product);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Inventory);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 756);
            this.Controls.Add(this.validationlabel);
            this.Controls.Add(this.AddProductsSearchButton);
            this.Controls.Add(this.AddProductSearchBar);
            this.Controls.Add(this.AssociatedPartsGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductsCandidatePartsLabel);
            this.Controls.Add(this.CandidatePartsGridView);
            this.Controls.Add(this.AddProductLabel);
            this.Controls.Add(this.AddProductSaveButton);
            this.Controls.Add(this.AddProductCancelButton);
            this.Controls.Add(this.AddProductDeleteButton);
            this.Controls.Add(this.AddProductAddButton);
            this.Controls.Add(this.AddProductIDField);
            this.Controls.Add(this.AddProductNameField);
            this.Controls.Add(this.AddProductInventoryField);
            this.Controls.Add(this.AddProductPriceCostField);
            this.Controls.Add(this.AddProductMinField);
            this.Controls.Add(this.AddProductMaxField);
            this.Controls.Add(this.MinFieldLabel);
            this.Controls.Add(this.MaxFieldLabel);
            this.Controls.Add(this.PriceFieldLabel);
            this.Controls.Add(this.InventoryFieldLabel);
            this.Controls.Add(this.NameFieldLabel);
            this.Controls.Add(this.IDFieldLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox AddProductIDField;
        private System.Windows.Forms.MaskedTextBox AddProductNameField;
        private System.Windows.Forms.MaskedTextBox AddProductInventoryField;
        private System.Windows.Forms.MaskedTextBox AddProductPriceCostField;
        private System.Windows.Forms.MaskedTextBox AddProductMinField;
        private System.Windows.Forms.MaskedTextBox AddProductMaxField;
        private System.Windows.Forms.Label MinFieldLabel;
        private System.Windows.Forms.Label MaxFieldLabel;
        private System.Windows.Forms.Label PriceFieldLabel;
        private System.Windows.Forms.Label InventoryFieldLabel;
        private System.Windows.Forms.Label NameFieldLabel;
        private System.Windows.Forms.Label IDFieldLabel;
        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.Label AddProductsCandidatePartsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductCandidatePartsPartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductCandidatePartsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductCandidatePartsInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductCandidatePartsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductsCandidatePartsMaxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductAssociatedPartsMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddProductAssociateProductDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView CandidatePartsGridView;
        private System.Windows.Forms.DataGridView AssociatedPartsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button AddProductAddButton;
        private System.Windows.Forms.Button AddProductDeleteButton;
        private System.Windows.Forms.Button AddProductCancelButton;
        private System.Windows.Forms.Button AddProductSaveButton;
        private System.Windows.Forms.TextBox AddProductSearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Button AddProductsSearchButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label validationlabel;
    }
}