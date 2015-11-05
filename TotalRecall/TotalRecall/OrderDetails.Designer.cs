namespace TotalRecall
{
    partial class OrderDetails
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
            System.Windows.Forms.Label shipRegionLabel;
            System.Windows.Forms.Label shipPostalCodeLabel;
            System.Windows.Forms.Label shipNameLabel;
            System.Windows.Forms.Label shipCountryLabel;
            System.Windows.Forms.Label shipCityLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            shipRegionLabel = new System.Windows.Forms.Label();
            shipPostalCodeLabel = new System.Windows.Forms.Label();
            shipNameLabel = new System.Windows.Forms.Label();
            shipCountryLabel = new System.Windows.Forms.Label();
            shipCityLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shipRegionLabel
            // 
            shipRegionLabel.AutoSize = true;
            shipRegionLabel.Location = new System.Drawing.Point(86, 275);
            shipRegionLabel.Name = "shipRegionLabel";
            shipRegionLabel.Size = new System.Drawing.Size(68, 13);
            shipRegionLabel.TabIndex = 19;
            shipRegionLabel.Text = "Ship Region:";
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(86, 249);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(91, 13);
            shipPostalCodeLabel.TabIndex = 17;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipNameLabel
            // 
            shipNameLabel.AutoSize = true;
            shipNameLabel.Location = new System.Drawing.Point(86, 223);
            shipNameLabel.Name = "shipNameLabel";
            shipNameLabel.Size = new System.Drawing.Size(62, 13);
            shipNameLabel.TabIndex = 15;
            shipNameLabel.Text = "Ship Name:";
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(86, 197);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(70, 13);
            shipCountryLabel.TabIndex = 13;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(86, 171);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(51, 13);
            shipCityLabel.TabIndex = 11;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(86, 145);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(72, 13);
            shipAddressLabel.TabIndex = 9;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(86, 15);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 7;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(86, 90);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 5;
            orderDateLabel.Text = "Order Date:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(86, 65);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 3;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(86, 40);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.orderDTOBindingSource;
            // 
            // orderDTOBindingSource
            // 
            this.orderDTOBindingSource.DataSource = typeof(TotalRecall.OrderDTO);
            this.orderDTOBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.orderDTOBindingSource_BindingComplete);
            this.orderDTOBindingSource.DataSourceChanged += new System.EventHandler(this.orderDTOBindingSource_DataSourceChanged);
            this.orderDTOBindingSource.DataMemberChanged += new System.EventHandler(this.orderDTOBindingSource_DataMemberChanged);
            this.orderDTOBindingSource.CurrentChanged += new System.EventHandler(this.orderDTOBindingSource_CurrentChanged);
            this.orderDTOBindingSource.CurrentItemChanged += new System.EventHandler(this.orderDTOBindingSource_CurrentItemChanged);
            this.orderDTOBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.orderDTOBindingSource_ListChanged);
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipRegion", true));
            this.shipRegionTextBox.Location = new System.Drawing.Point(183, 272);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipRegionTextBox.TabIndex = 20;
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(183, 246);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipPostalCodeTextBox.TabIndex = 18;
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipName", true));
            this.shipNameTextBox.Location = new System.Drawing.Point(183, 220);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipNameTextBox.TabIndex = 16;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(183, 194);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCountryTextBox.TabIndex = 14;
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(183, 168);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipCityTextBox.TabIndex = 12;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(183, 142);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.shipAddressTextBox.TabIndex = 10;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(183, 12);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 8;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderDTOBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(183, 87);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 6;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(24, 325);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(562, 245);
            this.itemsDataGridView.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(496, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(496, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerDTOBindingSource
            // 
            this.customerDTOBindingSource.DataSource = typeof(TotalRecall.CustomerDTO);
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderDTOBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataSource = this.employeeDTOBindingSource;
            this.employeeIDComboBox.DisplayMember = "Name";
            this.employeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(183, 62);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeIDComboBox.TabIndex = 25;
            this.employeeIDComboBox.ValueMember = "EmployeeID";
            // 
            // employeeDTOBindingSource
            // 
            this.employeeDTOBindingSource.DataSource = typeof(TotalRecall.EmployeeDTO);
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDTOBindingSource, "CustomerID", true));
            this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderDTOBindingSource, "CustomerID", true));
            this.customerIDComboBox.DataSource = this.customerDTOBindingSource;
            this.customerIDComboBox.DisplayMember = "CustomerID";
            this.customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(183, 37);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.customerIDComboBox.TabIndex = 26;
            this.customerIDComboBox.ValueMember = "CustomerID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // OrderDetails
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(618, 590);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(shipAddressLabel);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(shipCityLabel);
            this.Controls.Add(this.shipCityTextBox);
            this.Controls.Add(shipCountryLabel);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(shipNameLabel);
            this.Controls.Add(this.shipNameTextBox);
            this.Controls.Add(shipPostalCodeLabel);
            this.Controls.Add(this.shipPostalCodeTextBox);
            this.Controls.Add(shipRegionLabel);
            this.Controls.Add(this.shipRegionTextBox);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderDTOBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.BindingSource customerDTOBindingSource;
        private System.Windows.Forms.BindingSource employeeDTOBindingSource;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}