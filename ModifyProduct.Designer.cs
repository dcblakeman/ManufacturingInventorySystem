namespace ManufacturingInventorySystem
{
    partial class ModifyProduct
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
            this.ModifyProductIDField = new System.Windows.Forms.MaskedTextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifyProductNameField = new System.Windows.Forms.MaskedTextBox();
            this.ModifyProductInventoryField = new System.Windows.Forms.MaskedTextBox();
            this.ModifyProductPriceCostField = new System.Windows.Forms.MaskedTextBox();
            this.ModifyProductMaxField = new System.Windows.Forms.MaskedTextBox();
            this.MinFieldLabel = new System.Windows.Forms.Label();
            this.MaxFieldLabel = new System.Windows.Forms.Label();
            this.PriceCostFieldLabel = new System.Windows.Forms.Label();
            this.InventoryFieldLabel = new System.Windows.Forms.Label();
            this.NameFieldLabel = new System.Windows.Forms.Label();
            this.IDFieldLabel = new System.Windows.Forms.Label();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.ModifyProductCandidatePartSearchButton = new System.Windows.Forms.Button();
            this.ModifyProductCandidatePartSearchBar = new System.Windows.Forms.TextBox();
            this.AddProductsCandidatePartsLabel = new System.Windows.Forms.Label();
            this.AddProductAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyProductSaveButton = new System.Windows.Forms.Button();
            this.ModifyProductCancelButton = new System.Windows.Forms.Button();
            this.ModifyProductDeleteButton = new System.Windows.Forms.Button();
            this.CandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifyProductMinField = new System.Windows.Forms.MaskedTextBox();
            this.validationlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductIDField
            // 
            this.ModifyProductIDField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductId", true));
            this.ModifyProductIDField.Location = new System.Drawing.Point(199, 255);
            this.ModifyProductIDField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductIDField.Name = "ModifyProductIDField";
            this.ModifyProductIDField.ReadOnly = true;
            this.ModifyProductIDField.Size = new System.Drawing.Size(163, 26);
            this.ModifyProductIDField.TabIndex = 26;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ManufacturingInventorySystem.Models.Product);
            // 
            // ModifyProductNameField
            // 
            this.ModifyProductNameField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.ModifyProductNameField.Location = new System.Drawing.Point(199, 297);
            this.ModifyProductNameField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductNameField.Name = "ModifyProductNameField";
            this.ModifyProductNameField.Size = new System.Drawing.Size(163, 26);
            this.ModifyProductNameField.TabIndex = 27;
            // 
            // ModifyProductInventoryField
            // 
            this.ModifyProductInventoryField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "InStock", true));
            this.ModifyProductInventoryField.Location = new System.Drawing.Point(199, 338);
            this.ModifyProductInventoryField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductInventoryField.Name = "ModifyProductInventoryField";
            this.ModifyProductInventoryField.Size = new System.Drawing.Size(163, 26);
            this.ModifyProductInventoryField.TabIndex = 28;
            // 
            // ModifyProductPriceCostField
            // 
            this.ModifyProductPriceCostField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.ModifyProductPriceCostField.Location = new System.Drawing.Point(199, 380);
            this.ModifyProductPriceCostField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductPriceCostField.Name = "ModifyProductPriceCostField";
            this.ModifyProductPriceCostField.Size = new System.Drawing.Size(163, 26);
            this.ModifyProductPriceCostField.TabIndex = 29;
            // 
            // ModifyProductMaxField
            // 
            this.ModifyProductMaxField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Max", true));
            this.ModifyProductMaxField.Location = new System.Drawing.Point(113, 420);
            this.ModifyProductMaxField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductMaxField.Name = "ModifyProductMaxField";
            this.ModifyProductMaxField.Size = new System.Drawing.Size(84, 26);
            this.ModifyProductMaxField.TabIndex = 31;
            // 
            // MinFieldLabel
            // 
            this.MinFieldLabel.AutoSize = true;
            this.MinFieldLabel.Location = new System.Drawing.Point(246, 423);
            this.MinFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinFieldLabel.Name = "MinFieldLabel";
            this.MinFieldLabel.Size = new System.Drawing.Size(34, 20);
            this.MinFieldLabel.TabIndex = 20;
            this.MinFieldLabel.Text = "Min";
            // 
            // MaxFieldLabel
            // 
            this.MaxFieldLabel.AutoSize = true;
            this.MaxFieldLabel.Location = new System.Drawing.Point(62, 420);
            this.MaxFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxFieldLabel.Name = "MaxFieldLabel";
            this.MaxFieldLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxFieldLabel.TabIndex = 21;
            this.MaxFieldLabel.Text = "Max";
            // 
            // PriceCostFieldLabel
            // 
            this.PriceCostFieldLabel.AutoSize = true;
            this.PriceCostFieldLabel.Location = new System.Drawing.Point(62, 378);
            this.PriceCostFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceCostFieldLabel.Name = "PriceCostFieldLabel";
            this.PriceCostFieldLabel.Size = new System.Drawing.Size(89, 20);
            this.PriceCostFieldLabel.TabIndex = 22;
            this.PriceCostFieldLabel.Text = "Price / Cost";
            // 
            // InventoryFieldLabel
            // 
            this.InventoryFieldLabel.AutoSize = true;
            this.InventoryFieldLabel.Location = new System.Drawing.Point(62, 335);
            this.InventoryFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryFieldLabel.Name = "InventoryFieldLabel";
            this.InventoryFieldLabel.Size = new System.Drawing.Size(74, 20);
            this.InventoryFieldLabel.TabIndex = 23;
            this.InventoryFieldLabel.Text = "Inventory";
            // 
            // NameFieldLabel
            // 
            this.NameFieldLabel.AutoSize = true;
            this.NameFieldLabel.Location = new System.Drawing.Point(62, 293);
            this.NameFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFieldLabel.Name = "NameFieldLabel";
            this.NameFieldLabel.Size = new System.Drawing.Size(51, 20);
            this.NameFieldLabel.TabIndex = 24;
            this.NameFieldLabel.Text = "Name";
            // 
            // IDFieldLabel
            // 
            this.IDFieldLabel.AutoSize = true;
            this.IDFieldLabel.Location = new System.Drawing.Point(62, 250);
            this.IDFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDFieldLabel.Name = "IDFieldLabel";
            this.IDFieldLabel.Size = new System.Drawing.Size(26, 20);
            this.IDFieldLabel.TabIndex = 25;
            this.IDFieldLabel.Text = "ID";
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModifyProductLabel.Location = new System.Drawing.Point(24, 25);
            this.ModifyProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(173, 29);
            this.ModifyProductLabel.TabIndex = 32;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProductCandidatePartSearchButton
            // 
            this.ModifyProductCandidatePartSearchButton.Location = new System.Drawing.Point(807, 22);
            this.ModifyProductCandidatePartSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductCandidatePartSearchButton.Name = "ModifyProductCandidatePartSearchButton";
            this.ModifyProductCandidatePartSearchButton.Size = new System.Drawing.Size(81, 39);
            this.ModifyProductCandidatePartSearchButton.TabIndex = 35;
            this.ModifyProductCandidatePartSearchButton.Text = "Search";
            this.ModifyProductCandidatePartSearchButton.UseVisualStyleBackColor = true;
            this.ModifyProductCandidatePartSearchButton.Click += new System.EventHandler(this.ModifyProductCandidatePartSearchButton_Click);
            // 
            // ModifyProductCandidatePartSearchBar
            // 
            this.ModifyProductCandidatePartSearchBar.Location = new System.Drawing.Point(909, 30);
            this.ModifyProductCandidatePartSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductCandidatePartSearchBar.Name = "ModifyProductCandidatePartSearchBar";
            this.ModifyProductCandidatePartSearchBar.Size = new System.Drawing.Size(259, 26);
            this.ModifyProductCandidatePartSearchBar.TabIndex = 34;
            // 
            // AddProductsCandidatePartsLabel
            // 
            this.AddProductsCandidatePartsLabel.AutoSize = true;
            this.AddProductsCandidatePartsLabel.Location = new System.Drawing.Point(446, 37);
            this.AddProductsCandidatePartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductsCandidatePartsLabel.Name = "AddProductsCandidatePartsLabel";
            this.AddProductsCandidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.AddProductsCandidatePartsLabel.TabIndex = 33;
            this.AddProductsCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // AddProductAddButton
            // 
            this.AddProductAddButton.Location = new System.Drawing.Point(1085, 310);
            this.AddProductAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductAddButton.Name = "AddProductAddButton";
            this.AddProductAddButton.Size = new System.Drawing.Size(82, 46);
            this.AddProductAddButton.TabIndex = 36;
            this.AddProductAddButton.Text = "Add";
            this.AddProductAddButton.UseVisualStyleBackColor = true;
            this.AddProductAddButton.Click += new System.EventHandler(this.AddProductAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // ModifyProductSaveButton
            // 
            this.ModifyProductSaveButton.Location = new System.Drawing.Point(970, 677);
            this.ModifyProductSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductSaveButton.Name = "ModifyProductSaveButton";
            this.ModifyProductSaveButton.Size = new System.Drawing.Size(82, 46);
            this.ModifyProductSaveButton.TabIndex = 38;
            this.ModifyProductSaveButton.Text = "Save";
            this.ModifyProductSaveButton.UseVisualStyleBackColor = true;
            this.ModifyProductSaveButton.Click += new System.EventHandler(this.ModifyProductSaveButton_Click);
            // 
            // ModifyProductCancelButton
            // 
            this.ModifyProductCancelButton.Location = new System.Drawing.Point(1085, 677);
            this.ModifyProductCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductCancelButton.Name = "ModifyProductCancelButton";
            this.ModifyProductCancelButton.Size = new System.Drawing.Size(82, 46);
            this.ModifyProductCancelButton.TabIndex = 39;
            this.ModifyProductCancelButton.Text = "Cancel";
            this.ModifyProductCancelButton.UseVisualStyleBackColor = true;
            this.ModifyProductCancelButton.Click += new System.EventHandler(this.ModifyProductCancelButton_Click);
            // 
            // ModifyProductDeleteButton
            // 
            this.ModifyProductDeleteButton.Location = new System.Drawing.Point(1085, 610);
            this.ModifyProductDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductDeleteButton.Name = "ModifyProductDeleteButton";
            this.ModifyProductDeleteButton.Size = new System.Drawing.Size(82, 46);
            this.ModifyProductDeleteButton.TabIndex = 40;
            this.ModifyProductDeleteButton.Text = "Delete";
            this.ModifyProductDeleteButton.UseVisualStyleBackColor = true;
            this.ModifyProductDeleteButton.Click += new System.EventHandler(this.ModifyProductDeleteButton_Click);
            // 
            // CandidatePartsGridView
            // 
            this.CandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatePartsGridView.Location = new System.Drawing.Point(450, 78);
            this.CandidatePartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CandidatePartsGridView.Name = "CandidatePartsGridView";
            this.CandidatePartsGridView.RowHeadersVisible = false;
            this.CandidatePartsGridView.RowHeadersWidth = 82;
            this.CandidatePartsGridView.RowTemplate.Height = 33;
            this.CandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CandidatePartsGridView.Size = new System.Drawing.Size(745, 214);
            this.CandidatePartsGridView.TabIndex = 41;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            // 
            // AssociatedPartsGridView
            // 
            this.AssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGridView.Location = new System.Drawing.Point(450, 380);
            this.AssociatedPartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AssociatedPartsGridView.Name = "AssociatedPartsGridView";
            this.AssociatedPartsGridView.RowHeadersVisible = false;
            this.AssociatedPartsGridView.RowHeadersWidth = 82;
            this.AssociatedPartsGridView.RowTemplate.Height = 33;
            this.AssociatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGridView.Size = new System.Drawing.Size(745, 200);
            this.AssociatedPartsGridView.TabIndex = 41;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // ModifyProductMinField
            // 
            this.ModifyProductMinField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Min", true));
            this.ModifyProductMinField.Location = new System.Drawing.Point(297, 423);
            this.ModifyProductMinField.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductMinField.Name = "ModifyProductMinField";
            this.ModifyProductMinField.Size = new System.Drawing.Size(84, 26);
            this.ModifyProductMinField.TabIndex = 31;
            // 
            // validationlabel
            // 
            this.validationlabel.AutoSize = true;
            this.validationlabel.Location = new System.Drawing.Point(367, 345);
            this.validationlabel.Name = "validationlabel";
            this.validationlabel.Size = new System.Drawing.Size(118, 20);
            this.validationlabel.TabIndex = 42;
            this.validationlabel.Text = "ValidationLabel";
            this.validationlabel.Visible = false;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 851);
            this.Controls.Add(this.validationlabel);
            this.Controls.Add(this.AssociatedPartsGridView);
            this.Controls.Add(this.CandidatePartsGridView);
            this.Controls.Add(this.ModifyProductSaveButton);
            this.Controls.Add(this.ModifyProductCancelButton);
            this.Controls.Add(this.ModifyProductDeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductAddButton);
            this.Controls.Add(this.ModifyProductCandidatePartSearchButton);
            this.Controls.Add(this.ModifyProductCandidatePartSearchBar);
            this.Controls.Add(this.AddProductsCandidatePartsLabel);
            this.Controls.Add(this.ModifyProductLabel);
            this.Controls.Add(this.ModifyProductIDField);
            this.Controls.Add(this.ModifyProductNameField);
            this.Controls.Add(this.ModifyProductInventoryField);
            this.Controls.Add(this.ModifyProductPriceCostField);
            this.Controls.Add(this.ModifyProductMinField);
            this.Controls.Add(this.ModifyProductMaxField);
            this.Controls.Add(this.MinFieldLabel);
            this.Controls.Add(this.MaxFieldLabel);
            this.Controls.Add(this.PriceCostFieldLabel);
            this.Controls.Add(this.InventoryFieldLabel);
            this.Controls.Add(this.NameFieldLabel);
            this.Controls.Add(this.IDFieldLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ModifyProductIDField;
        private System.Windows.Forms.MaskedTextBox ModifyProductNameField;
        private System.Windows.Forms.MaskedTextBox ModifyProductInventoryField;
        private System.Windows.Forms.MaskedTextBox ModifyProductPriceCostField;
        private System.Windows.Forms.MaskedTextBox ModifyProductMaxField;
        private System.Windows.Forms.Label MinFieldLabel;
        private System.Windows.Forms.Label MaxFieldLabel;
        private System.Windows.Forms.Label PriceCostFieldLabel;
        private System.Windows.Forms.Label InventoryFieldLabel;
        private System.Windows.Forms.Label NameFieldLabel;
        private System.Windows.Forms.Label IDFieldLabel;
        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Button ModifyProductCandidatePartSearchButton;
        private System.Windows.Forms.TextBox ModifyProductCandidatePartSearchBar;
        private System.Windows.Forms.Label AddProductsCandidatePartsLabel;
        private System.Windows.Forms.Button AddProductAddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModifyProductSaveButton;
        private System.Windows.Forms.Button ModifyProductCancelButton;
        private System.Windows.Forms.Button ModifyProductDeleteButton;
        private System.Windows.Forms.DataGridView CandidatePartsGridView;
        //private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        //private InventoryDatabaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView AssociatedPartsGridView;
        private System.Windows.Forms.BindingSource productsBindingSource;
        //private InventoryDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.MaskedTextBox ModifyProductMinField;
        private System.Windows.Forms.Label validationlabel;
    }
}