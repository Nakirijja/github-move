namespace sofstoreInventorySystem
{
    partial class sales
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
            System.Windows.Forms.Label salesidLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label cust_idLabel;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label supplier_nameLabel;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label supplier_priceLabel;
            System.Windows.Forms.Label selling_priceLabel;
            System.Windows.Forms.Label balanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.custlbl = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerlbl = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.suppliers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salestbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salestbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new sofstoreInventorySystem.salesDataSet();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.salesidTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.user_idComboBox = new System.Windows.Forms.ComboBox();
            this.admintbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDataSet = new sofstoreInventorySystem.adminDataSet();
            this.cust_idComboBox = new System.Windows.Forms.ComboBox();
            this.customerdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new sofstoreInventorySystem.customerDataSet();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.categorytbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new sofstoreInventorySystem.categoryDataSet();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_nameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataSet = new sofstoreInventorySystem.supplierDataSet();
            this.quantityNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.supplier_priceComboBox = new System.Windows.Forms.ComboBox();
            this.stockdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesDataSet = new sofstoreInventorySystem.purchasesDataSet();
            this.stockdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selling_priceTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.salestbTableAdapter = new sofstoreInventorySystem.salesDataSetTableAdapters.salestbTableAdapter();
            this.tableAdapterManager = new sofstoreInventorySystem.salesDataSetTableAdapters.TableAdapterManager();
            this.salestbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salestbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.admintbTableAdapter = new sofstoreInventorySystem.adminDataSetTableAdapters.admintbTableAdapter();
            this.customer_detailsTableAdapter = new sofstoreInventorySystem.customerDataSetTableAdapters.customer_detailsTableAdapter();
            this.categorytbTableAdapter = new sofstoreInventorySystem.categoryDataSetTableAdapters.categorytbTableAdapter();
            this.stock_detailsTableAdapter = new sofstoreInventorySystem.purchasesDataSetTableAdapters.stock_detailsTableAdapter();
            this.supplier_detailsTableAdapter = new sofstoreInventorySystem.supplierDataSetTableAdapters.supplier_detailsTableAdapter();
            salesidLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            cust_idLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            supplier_nameLabel = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            supplier_priceLabel = new System.Windows.Forms.Label();
            selling_priceLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            this.headerpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.content.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salestbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admintbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorytbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestbBindingNavigator)).BeginInit();
            this.salestbBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesidLabel
            // 
            salesidLabel.AutoSize = true;
            salesidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salesidLabel.Location = new System.Drawing.Point(33, 17);
            salesidLabel.Name = "salesidLabel";
            salesidLabel.Size = new System.Drawing.Size(55, 16);
            salesidLabel.TabIndex = 41;
            salesidLabel.Text = "salesid:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(33, 44);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(38, 16);
            dateLabel.TabIndex = 43;
            dateLabel.Text = "date:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_idLabel.Location = new System.Drawing.Point(33, 69);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(51, 16);
            user_idLabel.TabIndex = 45;
            user_idLabel.Text = "user id:";
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cust_idLabel.Location = new System.Drawing.Point(33, 96);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(49, 16);
            cust_idLabel.TabIndex = 47;
            cust_idLabel.Text = "cust id:";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemLabel.Location = new System.Drawing.Point(33, 123);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(36, 16);
            itemLabel.TabIndex = 49;
            itemLabel.Text = "item:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(33, 150);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(64, 16);
            categoryLabel.TabIndex = 51;
            categoryLabel.Text = "category:";
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplier_nameLabel.Location = new System.Drawing.Point(33, 177);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(96, 16);
            supplier_nameLabel.TabIndex = 53;
            supplier_nameLabel.Text = "supplier name:";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel1.Location = new System.Drawing.Point(33, 201);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(57, 16);
            quantityLabel1.TabIndex = 55;
            quantityLabel1.Text = "quantity:";
            // 
            // supplier_priceLabel
            // 
            supplier_priceLabel.AutoSize = true;
            supplier_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplier_priceLabel.Location = new System.Drawing.Point(33, 230);
            supplier_priceLabel.Name = "supplier_priceLabel";
            supplier_priceLabel.Size = new System.Drawing.Size(92, 16);
            supplier_priceLabel.TabIndex = 57;
            supplier_priceLabel.Text = "supplier price:";
            // 
            // selling_priceLabel
            // 
            selling_priceLabel.AutoSize = true;
            selling_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selling_priceLabel.Location = new System.Drawing.Point(33, 257);
            selling_priceLabel.Name = "selling_priceLabel";
            selling_priceLabel.Size = new System.Drawing.Size(83, 16);
            selling_priceLabel.TabIndex = 59;
            selling_priceLabel.Text = "selling price:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balanceLabel.Location = new System.Drawing.Point(33, 283);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(60, 16);
            balanceLabel.TabIndex = 61;
            balanceLabel.Text = "balance:";
            // 
            // custlbl
            // 
            this.custlbl.AutoSize = true;
            this.custlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.custlbl.Location = new System.Drawing.Point(392, 27);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(44, 18);
            this.custlbl.TabIndex = 2;
            this.custlbl.Text = "SALES";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headerpanel.Controls.Add(this.button6);
            this.headerpanel.Controls.Add(this.panel2);
            this.headerpanel.Controls.Add(this.custlbl);
            this.headerpanel.Controls.Add(this.headerlbl);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(904, 72);
            this.headerpanel.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(127, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 63);
            this.button6.TabIndex = 69;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 72);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sofstoreInventorySystem.Properties.Resources.soflogoo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.Location = new System.Drawing.Point(254, 3);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(384, 24);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "SISTERS OF FAITH CLOTHING STORE";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Purple;
            this.content.Controls.Add(this.panel1);
            this.content.Controls.Add(this.salestbDataGridView);
            this.content.Controls.Add(this.customergroupBox);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(904, 487);
            this.content.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.suppliers);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 487);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 26);
            this.button5.TabIndex = 68;
            this.button5.Text = "Transactions";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 26);
            this.button4.TabIndex = 70;
            this.button4.Text = "Purchases";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 69;
            this.button1.Text = "Categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 24);
            this.button3.TabIndex = 66;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // suppliers
            // 
            this.suppliers.Location = new System.Drawing.Point(0, 139);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(127, 26);
            this.suppliers.TabIndex = 71;
            this.suppliers.Text = "Suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            this.suppliers.Click += new System.EventHandler(this.suppliers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 24);
            this.button2.TabIndex = 67;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salestbDataGridView
            // 
            this.salestbDataGridView.AutoGenerateColumns = false;
            this.salestbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salestbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.salestbDataGridView.DataSource = this.salestbBindingSource;
            this.salestbDataGridView.Location = new System.Drawing.Point(531, 115);
            this.salestbDataGridView.Name = "salestbDataGridView";
            this.salestbDataGridView.Size = new System.Drawing.Size(353, 317);
            this.salestbDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "salesid";
            this.dataGridViewTextBoxColumn2.HeaderText = "salesid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cust_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "cust_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "item";
            this.dataGridViewTextBoxColumn6.HeaderText = "item";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn7.HeaderText = "category";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "supplier_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "supplier_name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "supplier_price";
            this.dataGridViewTextBoxColumn10.HeaderText = "supplier_price";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "selling_price";
            this.dataGridViewTextBoxColumn11.HeaderText = "selling_price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "balance";
            this.dataGridViewTextBoxColumn12.HeaderText = "balance";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // salestbBindingSource
            // 
            this.salestbBindingSource.DataMember = "salestb";
            this.salestbBindingSource.DataSource = this.salesDataSet;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "salesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customergroupBox
            // 
            this.customergroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customergroupBox.Controls.Add(salesidLabel);
            this.customergroupBox.Controls.Add(this.salesidTextBox);
            this.customergroupBox.Controls.Add(dateLabel);
            this.customergroupBox.Controls.Add(this.dateDateTimePicker);
            this.customergroupBox.Controls.Add(user_idLabel);
            this.customergroupBox.Controls.Add(this.user_idComboBox);
            this.customergroupBox.Controls.Add(cust_idLabel);
            this.customergroupBox.Controls.Add(this.cust_idComboBox);
            this.customergroupBox.Controls.Add(itemLabel);
            this.customergroupBox.Controls.Add(this.itemComboBox);
            this.customergroupBox.Controls.Add(categoryLabel);
            this.customergroupBox.Controls.Add(this.categoryComboBox);
            this.customergroupBox.Controls.Add(supplier_nameLabel);
            this.customergroupBox.Controls.Add(this.supplier_nameComboBox);
            this.customergroupBox.Controls.Add(quantityLabel1);
            this.customergroupBox.Controls.Add(this.quantityNumericUpDown1);
            this.customergroupBox.Controls.Add(supplier_priceLabel);
            this.customergroupBox.Controls.Add(this.supplier_priceComboBox);
            this.customergroupBox.Controls.Add(selling_priceLabel);
            this.customergroupBox.Controls.Add(this.selling_priceTextBox);
            this.customergroupBox.Controls.Add(balanceLabel);
            this.customergroupBox.Controls.Add(this.balanceTextBox);
            this.customergroupBox.Location = new System.Drawing.Point(148, 115);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(377, 317);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            // 
            // salesidTextBox
            // 
            this.salesidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "salesid", true));
            this.salesidTextBox.Location = new System.Drawing.Point(147, 14);
            this.salesidTextBox.Name = "salesidTextBox";
            this.salesidTextBox.Size = new System.Drawing.Size(200, 20);
            this.salesidTextBox.TabIndex = 42;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salestbBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(147, 40);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 44;
            // 
            // user_idComboBox
            // 
            this.user_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "user_id", true));
            this.user_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.admintbBindingSource, "fname", true));
            this.user_idComboBox.DataSource = this.admintbBindingSource;
            this.user_idComboBox.DisplayMember = "fname";
            this.user_idComboBox.FormattingEnabled = true;
            this.user_idComboBox.Location = new System.Drawing.Point(147, 66);
            this.user_idComboBox.Name = "user_idComboBox";
            this.user_idComboBox.Size = new System.Drawing.Size(200, 21);
            this.user_idComboBox.TabIndex = 46;
            this.user_idComboBox.ValueMember = "fname";
            // 
            // admintbBindingSource
            // 
            this.admintbBindingSource.DataMember = "admintb";
            this.admintbBindingSource.DataSource = this.adminDataSet;
            // 
            // adminDataSet
            // 
            this.adminDataSet.DataSetName = "adminDataSet";
            this.adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cust_idComboBox
            // 
            this.cust_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "cust_id", true));
            this.cust_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerdetailsBindingSource, "customer_name", true));
            this.cust_idComboBox.DataSource = this.customerdetailsBindingSource;
            this.cust_idComboBox.DisplayMember = "customer_name";
            this.cust_idComboBox.FormattingEnabled = true;
            this.cust_idComboBox.Location = new System.Drawing.Point(147, 93);
            this.cust_idComboBox.Name = "cust_idComboBox";
            this.cust_idComboBox.Size = new System.Drawing.Size(200, 21);
            this.cust_idComboBox.TabIndex = 48;
            this.cust_idComboBox.ValueMember = "customer_name";
            // 
            // customerdetailsBindingSource
            // 
            this.customerdetailsBindingSource.DataMember = "customer_details";
            this.customerdetailsBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "item", true));
            this.itemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockdetailsBindingSource, "stock_name", true));
            this.itemComboBox.DataSource = this.stockdetailsBindingSource;
            this.itemComboBox.DisplayMember = "stock_name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(147, 120);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(200, 21);
            this.itemComboBox.TabIndex = 50;
            this.itemComboBox.ValueMember = "stock_name";
            // 
            // categorytbBindingSource
            // 
            this.categorytbBindingSource.DataMember = "categorytb";
            this.categorytbBindingSource.DataSource = this.categoryDataSet;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "categoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "category", true));
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categorytbBindingSource, "category_desc", true));
            this.categoryComboBox.DataSource = this.categorytbBindingSource;
            this.categoryComboBox.DisplayMember = "category_desc";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(147, 147);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryComboBox.TabIndex = 52;
            this.categoryComboBox.ValueMember = "category_desc";
            // 
            // supplier_nameComboBox
            // 
            this.supplier_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "supplier_name", true));
            this.supplier_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierdetailsBindingSource, "supplier_name", true));
            this.supplier_nameComboBox.DataSource = this.supplierdetailsBindingSource;
            this.supplier_nameComboBox.DisplayMember = "supplier_name";
            this.supplier_nameComboBox.FormattingEnabled = true;
            this.supplier_nameComboBox.Location = new System.Drawing.Point(147, 174);
            this.supplier_nameComboBox.Name = "supplier_nameComboBox";
            this.supplier_nameComboBox.Size = new System.Drawing.Size(200, 21);
            this.supplier_nameComboBox.TabIndex = 54;
            this.supplier_nameComboBox.ValueMember = "supplier_name";
            // 
            // supplierdetailsBindingSource
            // 
            this.supplierdetailsBindingSource.DataMember = "supplier_details";
            this.supplierdetailsBindingSource.DataSource = this.supplierDataSet;
            // 
            // supplierDataSet
            // 
            this.supplierDataSet.DataSetName = "supplierDataSet";
            this.supplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantityNumericUpDown1
            // 
            this.quantityNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salestbBindingSource, "quantity", true));
            this.quantityNumericUpDown1.Location = new System.Drawing.Point(147, 201);
            this.quantityNumericUpDown1.Name = "quantityNumericUpDown1";
            this.quantityNumericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.quantityNumericUpDown1.TabIndex = 56;
            // 
            // supplier_priceComboBox
            // 
            this.supplier_priceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "supplier_price", true));
            this.supplier_priceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockdetailsBindingSource, "company_price", true));
            this.supplier_priceComboBox.DataSource = this.stockdetailsBindingSource1;
            this.supplier_priceComboBox.DisplayMember = "company_price";
            this.supplier_priceComboBox.FormattingEnabled = true;
            this.supplier_priceComboBox.Location = new System.Drawing.Point(147, 227);
            this.supplier_priceComboBox.Name = "supplier_priceComboBox";
            this.supplier_priceComboBox.Size = new System.Drawing.Size(200, 21);
            this.supplier_priceComboBox.TabIndex = 58;
            this.supplier_priceComboBox.ValueMember = "company_price";
            // 
            // stockdetailsBindingSource
            // 
            this.stockdetailsBindingSource.DataMember = "stock_details";
            this.stockdetailsBindingSource.DataSource = this.purchasesDataSet;
            // 
            // purchasesDataSet
            // 
            this.purchasesDataSet.DataSetName = "purchasesDataSet";
            this.purchasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockdetailsBindingSource1
            // 
            this.stockdetailsBindingSource1.DataMember = "stock_details";
            this.stockdetailsBindingSource1.DataSource = this.purchasesDataSet;
            // 
            // selling_priceTextBox
            // 
            this.selling_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "selling_price", true));
            this.selling_priceTextBox.Location = new System.Drawing.Point(147, 254);
            this.selling_priceTextBox.Name = "selling_priceTextBox";
            this.selling_priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.selling_priceTextBox.TabIndex = 60;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salestbBindingSource, "balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(147, 280);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.balanceTextBox.TabIndex = 62;
            // 
            // salestbTableAdapter
            // 
            this.salestbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.salestbTableAdapter = this.salestbTableAdapter;
            this.tableAdapterManager.UpdateOrder = sofstoreInventorySystem.salesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salestbBindingNavigator
            // 
            this.salestbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salestbBindingNavigator.BindingSource = this.salestbBindingSource;
            this.salestbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salestbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salestbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salestbBindingNavigatorSaveItem});
            this.salestbBindingNavigator.Location = new System.Drawing.Point(0, 72);
            this.salestbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salestbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salestbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salestbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salestbBindingNavigator.Name = "salestbBindingNavigator";
            this.salestbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salestbBindingNavigator.Size = new System.Drawing.Size(904, 25);
            this.salestbBindingNavigator.TabIndex = 15;
            this.salestbBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salestbBindingNavigatorSaveItem
            // 
            this.salestbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salestbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salestbBindingNavigatorSaveItem.Image")));
            this.salestbBindingNavigatorSaveItem.Name = "salestbBindingNavigatorSaveItem";
            this.salestbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salestbBindingNavigatorSaveItem.Text = "Save Data";
            this.salestbBindingNavigatorSaveItem.Click += new System.EventHandler(this.salestbBindingNavigatorSaveItem_Click);
            // 
            // admintbTableAdapter
            // 
            this.admintbTableAdapter.ClearBeforeFill = true;
            // 
            // customer_detailsTableAdapter
            // 
            this.customer_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // categorytbTableAdapter
            // 
            this.categorytbTableAdapter.ClearBeforeFill = true;
            // 
            // stock_detailsTableAdapter
            // 
            this.stock_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // supplier_detailsTableAdapter
            // 
            this.supplier_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 487);
            this.Controls.Add(this.salestbBindingNavigator);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.content);
            this.Name = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salestbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admintbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorytbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestbBindingNavigator)).EndInit();
            this.salestbBindingNavigator.ResumeLayout(false);
            this.salestbBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custlbl;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.GroupBox customergroupBox;
        private salesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource salestbBindingSource;
        private salesDataSetTableAdapters.salestbTableAdapter salestbTableAdapter;
        private salesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salestbBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salestbBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView salestbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox salesidTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox user_idComboBox;
        private System.Windows.Forms.ComboBox cust_idComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox supplier_nameComboBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown1;
        private System.Windows.Forms.ComboBox supplier_priceComboBox;
        private System.Windows.Forms.TextBox selling_priceTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button suppliers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private adminDataSet adminDataSet;
        private System.Windows.Forms.BindingSource admintbBindingSource;
        private adminDataSetTableAdapters.admintbTableAdapter admintbTableAdapter;
        private customerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerdetailsBindingSource;
        private customerDataSetTableAdapters.customer_detailsTableAdapter customer_detailsTableAdapter;
        private categoryDataSet categoryDataSet;
        private System.Windows.Forms.BindingSource categorytbBindingSource;
        private categoryDataSetTableAdapters.categorytbTableAdapter categorytbTableAdapter;
        private purchasesDataSet purchasesDataSet;
        private System.Windows.Forms.BindingSource stockdetailsBindingSource;
        private purchasesDataSetTableAdapters.stock_detailsTableAdapter stock_detailsTableAdapter;
        private supplierDataSet supplierDataSet;
        private System.Windows.Forms.BindingSource supplierdetailsBindingSource;
        private supplierDataSetTableAdapters.supplier_detailsTableAdapter supplier_detailsTableAdapter;
        private System.Windows.Forms.BindingSource stockdetailsBindingSource1;
    }
}