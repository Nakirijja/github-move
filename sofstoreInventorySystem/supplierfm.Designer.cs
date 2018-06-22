namespace sofstoreInventorySystem
{
    partial class supplierfm
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contact1Label;
            System.Windows.Forms.Label contact2Label;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierfm));
            this.custlbl = new System.Windows.Forms.Label();
            this.headerlbl = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.suppliers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_addressTextBox = new System.Windows.Forms.TextBox();
            this.customer_contact1MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.customer_contact2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.supplierDataSet = new sofstoreInventorySystem.supplierDataSet();
            this.supplier_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplier_detailsTableAdapter = new sofstoreInventorySystem.supplierDataSetTableAdapters.supplier_detailsTableAdapter();
            this.tableAdapterManager = new sofstoreInventorySystem.supplierDataSetTableAdapters.TableAdapterManager();
            this.supplier_detailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplier_detailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            fnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contact1Label = new System.Windows.Forms.Label();
            contact2Label = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.headerpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_detailsBindingNavigator)).BeginInit();
            this.supplier_detailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(41, 51);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(50, 16);
            fnameLabel.TabIndex = 0;
            fnameLabel.Text = "NAME:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(41, 83);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(77, 16);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "ADDRESS:";
            // 
            // contact1Label
            // 
            contact1Label.AutoSize = true;
            contact1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact1Label.Location = new System.Drawing.Point(41, 109);
            contact1Label.Name = "contact1Label";
            contact1Label.Size = new System.Drawing.Size(91, 16);
            contact1Label.TabIndex = 6;
            contact1Label.Text = "CONTACT(1):";
            // 
            // contact2Label
            // 
            contact2Label.AutoSize = true;
            contact2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact2Label.Location = new System.Drawing.Point(41, 135);
            contact2Label.Name = "contact2Label";
            contact2Label.Size = new System.Drawing.Size(91, 16);
            contact2Label.TabIndex = 8;
            contact2Label.Text = "CONTACT(2):";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(41, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(73, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "BALANCE:";
            // 
            // custlbl
            // 
            this.custlbl.AutoSize = true;
            this.custlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.custlbl.Location = new System.Drawing.Point(334, 33);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(204, 18);
            this.custlbl.TabIndex = 2;
            this.custlbl.Text = "SUPPLIER REGISTERATION FORM";
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.Location = new System.Drawing.Point(266, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(384, 24);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "SISTERS OF FAITH CLOTHING STORE";
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
            this.headerpanel.Size = new System.Drawing.Size(663, 72);
            this.headerpanel.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(127, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 61);
            this.button6.TabIndex = 70;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 72);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sofstoreInventorySystem.Properties.Resources.soflogoo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Controls.Add(this.panel1);
            this.content.Controls.Add(this.customergroupBox);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(663, 416);
            this.content.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.suppliers);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 416);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-3, 376);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 26);
            this.button7.TabIndex = 68;
            this.button7.Text = "Transactions";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 26);
            this.button5.TabIndex = 68;
            this.button5.Text = "Purchases";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 26);
            this.button4.TabIndex = 70;
            this.button4.Text = "Sales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 69;
            this.button1.Text = "Categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 24);
            this.button3.TabIndex = 66;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // suppliers
            // 
            this.suppliers.Location = new System.Drawing.Point(0, 140);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(127, 26);
            this.suppliers.TabIndex = 71;
            this.suppliers.Text = "Suppliers";
            this.suppliers.UseVisualStyleBackColor = true;
            this.suppliers.Click += new System.EventHandler(this.suppliers_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 24);
            this.button2.TabIndex = 67;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // customergroupBox
            // 
            this.customergroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customergroupBox.Controls.Add(this.customer_nameTextBox);
            this.customergroupBox.Controls.Add(this.customer_addressTextBox);
            this.customergroupBox.Controls.Add(this.customer_contact1MaskedTextBox);
            this.customergroupBox.Controls.Add(this.customer_contact2MaskedTextBox);
            this.customergroupBox.Controls.Add(this.balanceTextBox);
            this.customergroupBox.Controls.Add(fnameLabel);
            this.customergroupBox.Controls.Add(addressLabel);
            this.customergroupBox.Controls.Add(contact1Label);
            this.customergroupBox.Controls.Add(contact2Label);
            this.customergroupBox.Controls.Add(emailLabel);
            this.customergroupBox.Location = new System.Drawing.Point(227, 140);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(348, 225);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "REGISTER FORM";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.Location = new System.Drawing.Point(147, 50);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_nameTextBox.TabIndex = 13;
            // 
            // customer_addressTextBox
            // 
            this.customer_addressTextBox.Location = new System.Drawing.Point(147, 76);
            this.customer_addressTextBox.Name = "customer_addressTextBox";
            this.customer_addressTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_addressTextBox.TabIndex = 15;
            // 
            // customer_contact1MaskedTextBox
            // 
            this.customer_contact1MaskedTextBox.Location = new System.Drawing.Point(147, 102);
            this.customer_contact1MaskedTextBox.Mask = "0000-000000";
            this.customer_contact1MaskedTextBox.Name = "customer_contact1MaskedTextBox";
            this.customer_contact1MaskedTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_contact1MaskedTextBox.TabIndex = 17;
            // 
            // customer_contact2MaskedTextBox
            // 
            this.customer_contact2MaskedTextBox.Location = new System.Drawing.Point(147, 128);
            this.customer_contact2MaskedTextBox.Mask = "0000-000000";
            this.customer_contact2MaskedTextBox.Name = "customer_contact2MaskedTextBox";
            this.customer_contact2MaskedTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_contact2MaskedTextBox.TabIndex = 19;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(147, 154);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(179, 20);
            this.balanceTextBox.TabIndex = 21;
            // 
            // supplierDataSet
            // 
            this.supplierDataSet.DataSetName = "supplierDataSet";
            this.supplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplier_detailsBindingSource
            // 
            this.supplier_detailsBindingSource.DataMember = "supplier_details";
            this.supplier_detailsBindingSource.DataSource = this.supplierDataSet;
            // 
            // supplier_detailsTableAdapter
            // 
            this.supplier_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.supplier_detailsTableAdapter = this.supplier_detailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = sofstoreInventorySystem.supplierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplier_detailsBindingNavigator
            // 
            this.supplier_detailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplier_detailsBindingNavigator.BindingSource = this.supplier_detailsBindingSource;
            this.supplier_detailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplier_detailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplier_detailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplier_detailsBindingNavigatorSaveItem});
            this.supplier_detailsBindingNavigator.Location = new System.Drawing.Point(0, 72);
            this.supplier_detailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplier_detailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplier_detailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplier_detailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplier_detailsBindingNavigator.Name = "supplier_detailsBindingNavigator";
            this.supplier_detailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplier_detailsBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.supplier_detailsBindingNavigator.TabIndex = 9;
            this.supplier_detailsBindingNavigator.Text = "bindingNavigator1";
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
            // supplier_detailsBindingNavigatorSaveItem
            // 
            this.supplier_detailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplier_detailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplier_detailsBindingNavigatorSaveItem.Image")));
            this.supplier_detailsBindingNavigatorSaveItem.Name = "supplier_detailsBindingNavigatorSaveItem";
            this.supplier_detailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.supplier_detailsBindingNavigatorSaveItem.Text = "Save Data";
            this.supplier_detailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplier_detailsBindingNavigatorSaveItem_Click);
            // 
            // supplierfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 416);
            this.Controls.Add(this.supplier_detailsBindingNavigator);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.content);
            this.Name = "supplierfm";
            this.Load += new System.EventHandler(this.supplierfm_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_detailsBindingNavigator)).EndInit();
            this.supplier_detailsBindingNavigator.ResumeLayout(false);
            this.supplier_detailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custlbl;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.GroupBox customergroupBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox customer_addressTextBox;
        private System.Windows.Forms.MaskedTextBox customer_contact1MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox customer_contact2MaskedTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private supplierDataSet supplierDataSet;
        private System.Windows.Forms.BindingSource supplier_detailsBindingSource;
        private supplierDataSetTableAdapters.supplier_detailsTableAdapter supplier_detailsTableAdapter;
        private supplierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplier_detailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplier_detailsBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button suppliers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}