using System.CodeDom;

namespace ManufacturingInventorySystem
{
    partial class MainScreen
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
            this.InventoryManagementSystemLabel = new System.Windows.Forms.Label();
            this.PartsAddButton = new System.Windows.Forms.Button();
            this.PartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsModifyButton = new System.Windows.Forms.Button();
            this.PartsDeleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ProductsExitButton = new System.Windows.Forms.Button();
            this.ProductsModifyButton = new System.Windows.Forms.Button();
            this.ProductsDeleteButton = new System.Windows.Forms.Button();
            this.ProductsSearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductsAddButton = new System.Windows.Forms.Button();
            this.PartsTableLabel = new System.Windows.Forms.Label();
            this.ProductsTableLabel = new System.Windows.Forms.Label();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.ProductsSearchButton = new System.Windows.Forms.Button();
            this.inventoryBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryManagementSystemLabel
            // 
            this.InventoryManagementSystemLabel.AutoSize = true;
            this.InventoryManagementSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InventoryManagementSystemLabel.Location = new System.Drawing.Point(21, 26);
            this.InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
            this.InventoryManagementSystemLabel.Size = new System.Drawing.Size(404, 32);
            this.InventoryManagementSystemLabel.TabIndex = 0;
            this.InventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // PartsAddButton
            // 
            this.PartsAddButton.Location = new System.Drawing.Point(370, 498);
            this.PartsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.PartsAddButton.Name = "PartsAddButton";
            this.PartsAddButton.Size = new System.Drawing.Size(79, 46);
            this.PartsAddButton.TabIndex = 3;
            this.PartsAddButton.Text = "Add";
            this.PartsAddButton.UseVisualStyleBackColor = true;
            this.PartsAddButton.Click += new System.EventHandler(this.PartsAddButton_Click);
            // 
            // PartsSearchTextBox
            // 
            this.PartsSearchTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Part_ID",
            "Name",
            "Price",
            "Inventory",
            "Min",
            "Max"});
            this.PartsSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PartsSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.PartsSearchTextBox.Location = new System.Drawing.Point(403, 179);
            this.PartsSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PartsSearchTextBox.Name = "PartsSearchTextBox";
            this.PartsSearchTextBox.Size = new System.Drawing.Size(228, 26);
            this.PartsSearchTextBox.TabIndex = 4;
            // 
            // PartsModifyButton
            // 
            this.PartsModifyButton.Location = new System.Drawing.Point(464, 498);
            this.PartsModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.PartsModifyButton.Name = "PartsModifyButton";
            this.PartsModifyButton.Size = new System.Drawing.Size(79, 46);
            this.PartsModifyButton.TabIndex = 3;
            this.PartsModifyButton.Text = "Modify";
            this.PartsModifyButton.UseVisualStyleBackColor = true;
            this.PartsModifyButton.Click += new System.EventHandler(this.PartsModifyButton_Click);
            // 
            // PartsDeleteButton
            // 
            this.PartsDeleteButton.Location = new System.Drawing.Point(556, 498);
            this.PartsDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.PartsDeleteButton.Name = "PartsDeleteButton";
            this.PartsDeleteButton.Size = new System.Drawing.Size(79, 46);
            this.PartsDeleteButton.TabIndex = 3;
            this.PartsDeleteButton.Text = "Delete";
            this.PartsDeleteButton.UseVisualStyleBackColor = true;
            this.PartsDeleteButton.Click += new System.EventHandler(this.PartsDeleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1124, 498);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1216, 498);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 46);
            this.button6.TabIndex = 3;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ProductsExitButton
            // 
            this.ProductsExitButton.Location = new System.Drawing.Point(1217, 613);
            this.ProductsExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsExitButton.Name = "ProductsExitButton";
            this.ProductsExitButton.Size = new System.Drawing.Size(79, 46);
            this.ProductsExitButton.TabIndex = 3;
            this.ProductsExitButton.Text = "Exit";
            this.ProductsExitButton.UseVisualStyleBackColor = true;
            this.ProductsExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProductsModifyButton
            // 
            this.ProductsModifyButton.Location = new System.Drawing.Point(1124, 498);
            this.ProductsModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsModifyButton.Name = "ProductsModifyButton";
            this.ProductsModifyButton.Size = new System.Drawing.Size(79, 46);
            this.ProductsModifyButton.TabIndex = 3;
            this.ProductsModifyButton.Text = "Modify";
            this.ProductsModifyButton.UseVisualStyleBackColor = true;
            this.ProductsModifyButton.Click += new System.EventHandler(this.ProductsModifyButton_Click);
            // 
            // ProductsDeleteButton
            // 
            this.ProductsDeleteButton.Location = new System.Drawing.Point(1216, 498);
            this.ProductsDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsDeleteButton.Name = "ProductsDeleteButton";
            this.ProductsDeleteButton.Size = new System.Drawing.Size(79, 46);
            this.ProductsDeleteButton.TabIndex = 3;
            this.ProductsDeleteButton.Text = "Delete";
            this.ProductsDeleteButton.UseVisualStyleBackColor = true;
            this.ProductsDeleteButton.Click += new System.EventHandler(this.ProductsDeleteButton_Click);
            // 
            // ProductsSearchTextBox
            // 
            this.ProductsSearchTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Product_ID",
            "Name",
            "Price",
            "Inventory",
            "Min",
            "Max"});
            this.ProductsSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductsSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ProductsSearchTextBox.Location = new System.Drawing.Point(1068, 179);
            this.ProductsSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsSearchTextBox.Name = "ProductsSearchTextBox";
            this.ProductsSearchTextBox.Size = new System.Drawing.Size(228, 26);
            this.ProductsSearchTextBox.TabIndex = 4;
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.Location = new System.Drawing.Point(1028, 498);
            this.ProductsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(79, 46);
            this.ProductsAddButton.TabIndex = 3;
            this.ProductsAddButton.Text = "Add";
            this.ProductsAddButton.UseVisualStyleBackColor = true;
            this.ProductsAddButton.Click += new System.EventHandler(this.ProductsAddButton_Click);
            // 
            // PartsTableLabel
            // 
            this.PartsTableLabel.AutoSize = true;
            this.PartsTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PartsTableLabel.Location = new System.Drawing.Point(12, 179);
            this.PartsTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsTableLabel.Name = "PartsTableLabel";
            this.PartsTableLabel.Size = new System.Drawing.Size(63, 26);
            this.PartsTableLabel.TabIndex = 5;
            this.PartsTableLabel.Text = "Parts";
            // 
            // ProductsTableLabel
            // 
            this.ProductsTableLabel.AutoSize = true;
            this.ProductsTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ProductsTableLabel.Location = new System.Drawing.Point(670, 179);
            this.ProductsTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductsTableLabel.Name = "ProductsTableLabel";
            this.ProductsTableLabel.Size = new System.Drawing.Size(98, 26);
            this.ProductsTableLabel.TabIndex = 5;
            this.ProductsTableLabel.Text = "Products";
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.AllowUserToAddRows = false;
            this.PartsDataGrid.AllowUserToDeleteRows = false;
            this.PartsDataGrid.AllowUserToResizeColumns = false;
            this.PartsDataGrid.AllowUserToResizeRows = false;
            this.PartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataGrid.ColumnHeadersHeight = 46;
            this.PartsDataGrid.Location = new System.Drawing.Point(17, 222);
            this.PartsDataGrid.MultiSelect = false;
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.ReadOnly = true;
            this.PartsDataGrid.RowHeadersVisible = false;
            this.PartsDataGrid.RowHeadersWidth = 82;
            this.PartsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PartsDataGrid.RowTemplate.Height = 33;
            this.PartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGrid.Size = new System.Drawing.Size(620, 249);
            this.PartsDataGrid.TabIndex = 2;
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToResizeColumns = false;
            this.ProductsDataGrid.AllowUserToResizeRows = false;
            this.ProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGrid.ColumnHeadersHeight = 46;
            this.ProductsDataGrid.Location = new System.Drawing.Point(675, 222);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersVisible = false;
            this.ProductsDataGrid.RowHeadersWidth = 82;
            this.ProductsDataGrid.RowTemplate.Height = 33;
            this.ProductsDataGrid.RowTemplate.ReadOnly = true;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.Size = new System.Drawing.Size(620, 249);
            this.ProductsDataGrid.TabIndex = 2;
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(268, 178);
            this.SearchPartsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(73, 30);
            this.SearchPartsButton.TabIndex = 6;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // ProductsSearchButton
            // 
            this.ProductsSearchButton.Location = new System.Drawing.Point(934, 177);
            this.ProductsSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsSearchButton.Name = "ProductsSearchButton";
            this.ProductsSearchButton.Size = new System.Drawing.Size(73, 30);
            this.ProductsSearchButton.TabIndex = 6;
            this.ProductsSearchButton.Text = "Search";
            this.ProductsSearchButton.UseVisualStyleBackColor = true;
            this.ProductsSearchButton.Click += new System.EventHandler(this.ProductsSearchButton_Click);
            // 
            // inventoryBindingSource8
            // 
            this.inventoryBindingSource8.DataSource = typeof(ManufacturingInventorySystem.Models.Inventory);
            // 
            // inventoryBindingSource9
            // 
            this.inventoryBindingSource9.DataSource = typeof(ManufacturingInventorySystem.Models.Inventory);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1307, 730);
            this.Controls.Add(this.ProductsSearchButton);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.ProductsTableLabel);
            this.Controls.Add(this.PartsTableLabel);
            this.Controls.Add(this.ProductsSearchTextBox);
            this.Controls.Add(this.PartsSearchTextBox);
            this.Controls.Add(this.ProductsDeleteButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.PartsDeleteButton);
            this.Controls.Add(this.ProductsModifyButton);
            this.Controls.Add(this.ProductsExitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PartsModifyButton);
            this.Controls.Add(this.ProductsAddButton);
            this.Controls.Add(this.PartsAddButton);
            this.Controls.Add(this.PartsDataGrid);
            this.Controls.Add(this.ProductsDataGrid);
            this.Controls.Add(this.InventoryManagementSystemLabel);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventoryManagementSystemLabel;
        private System.Windows.Forms.Button PartsAddButton;
        private System.Windows.Forms.TextBox PartsSearchTextBox;
        private System.Windows.Forms.Button PartsModifyButton;
        private System.Windows.Forms.Button PartsDeleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ProductsExitButton;
        private System.Windows.Forms.Button ProductsModifyButton;
        private System.Windows.Forms.Button ProductsDeleteButton;
        private System.Windows.Forms.TextBox ProductsSearchTextBox;
        private System.Windows.Forms.Button ProductsAddButton;
        private System.Windows.Forms.Label PartsTableLabel;
        private System.Windows.Forms.Label ProductsTableLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsPart_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Button ProductsSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.BindingSource inventoryBindingSource8;
        private System.Windows.Forms.BindingSource inventoryBindingSource9;
    }
}

