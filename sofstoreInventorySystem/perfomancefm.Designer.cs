namespace sofstoreInventorySystem
{
    partial class perfomancefm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfomancefm));
            this.custlbl = new System.Windows.Forms.Label();
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.headerlbl = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.perfomancetbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfomancetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfomanceDataSet = new sofstoreInventorySystem.perfomanceDataSet();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.cust_requestRichTextBox = new System.Windows.Forms.RichTextBox();
            this.customersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vistorsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.perfomancetbTableAdapter = new sofstoreInventorySystem.perfomanceDataSetTableAdapters.perfomancetbTableAdapter();
            this.tableAdapterManager = new sofstoreInventorySystem.perfomanceDataSetTableAdapters.TableAdapterManager();
            this.perfomancetbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.perfomancetbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            fnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contact1Label = new System.Windows.Forms.Label();
            contact2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomanceDataSet)).BeginInit();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistorsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbBindingNavigator)).BeginInit();
            this.perfomancetbBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(22, 33);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(48, 16);
            fnameLabel.TabIndex = 0;
            fnameLabel.Text = "DATE:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(22, 65);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(73, 16);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "VISITORS:";
            // 
            // contact1Label
            // 
            contact1Label.AutoSize = true;
            contact1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact1Label.Location = new System.Drawing.Point(22, 91);
            contact1Label.Name = "contact1Label";
            contact1Label.Size = new System.Drawing.Size(97, 16);
            contact1Label.TabIndex = 6;
            contact1Label.Text = "CUSTOMERS:";
            // 
            // contact2Label
            // 
            contact2Label.AutoSize = true;
            contact2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact2Label.Location = new System.Drawing.Point(22, 117);
            contact2Label.Name = "contact2Label";
            contact2Label.Size = new System.Drawing.Size(83, 16);
            contact2Label.TabIndex = 8;
            contact2Label.Text = "REQUESTS";
            // 
            // custlbl
            // 
            this.custlbl.AutoSize = true;
            this.custlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.custlbl.Location = new System.Drawing.Point(387, 33);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(131, 18);
            this.custlbl.TabIndex = 2;
            this.custlbl.Text = "DAILY PERFOMANCE";
            // 
            // logopicbox
            // 
            this.logopicbox.Image = global::sofstoreInventorySystem.Properties.Resources.soflogoo;
            this.logopicbox.Location = new System.Drawing.Point(3, 4);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(114, 65);
            this.logopicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopicbox.TabIndex = 1;
            this.logopicbox.TabStop = false;
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.Location = new System.Drawing.Point(284, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(384, 24);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "SISTERS OF FAITH CLOTHING STORE";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headerpanel.Controls.Add(this.panel1);
            this.headerpanel.Controls.Add(this.custlbl);
            this.headerpanel.Controls.Add(this.headerlbl);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(878, 72);
            this.headerpanel.TabIndex = 7;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.perfomancetbDataGridView);
            this.content.Controls.Add(this.customergroupBox);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(878, 446);
            this.content.TabIndex = 8;
            // 
            // perfomancetbDataGridView
            // 
            this.perfomancetbDataGridView.AutoGenerateColumns = false;
            this.perfomancetbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfomancetbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.perfomancetbDataGridView.DataSource = this.perfomancetbBindingSource;
            this.perfomancetbDataGridView.Location = new System.Drawing.Point(479, 116);
            this.perfomancetbDataGridView.Name = "perfomancetbDataGridView";
            this.perfomancetbDataGridView.Size = new System.Drawing.Size(376, 319);
            this.perfomancetbDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vistors";
            this.dataGridViewTextBoxColumn3.HeaderText = "vistors";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customers";
            this.dataGridViewTextBoxColumn4.HeaderText = "customers";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cust_request";
            this.dataGridViewTextBoxColumn5.HeaderText = "cust_request";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // perfomancetbBindingSource
            // 
            this.perfomancetbBindingSource.DataMember = "perfomancetb";
            this.perfomancetbBindingSource.DataSource = this.perfomanceDataSet;
            // 
            // perfomanceDataSet
            // 
            this.perfomanceDataSet.DataSetName = "perfomanceDataSet";
            this.perfomanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customergroupBox
            // 
            this.customergroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customergroupBox.Controls.Add(this.cust_requestRichTextBox);
            this.customergroupBox.Controls.Add(this.customersNumericUpDown);
            this.customergroupBox.Controls.Add(this.vistorsNumericUpDown);
            this.customergroupBox.Controls.Add(this.dateDateTimePicker);
            this.customergroupBox.Controls.Add(fnameLabel);
            this.customergroupBox.Controls.Add(addressLabel);
            this.customergroupBox.Controls.Add(contact1Label);
            this.customergroupBox.Controls.Add(contact2Label);
            this.customergroupBox.Location = new System.Drawing.Point(138, 116);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(335, 272);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "PERFOMANCE FORM";
            // 
            // cust_requestRichTextBox
            // 
            this.cust_requestRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfomancetbBindingSource, "cust_request", true));
            this.cust_requestRichTextBox.Location = new System.Drawing.Point(130, 117);
            this.cust_requestRichTextBox.Name = "cust_requestRichTextBox";
            this.cust_requestRichTextBox.Size = new System.Drawing.Size(126, 124);
            this.cust_requestRichTextBox.TabIndex = 34;
            this.cust_requestRichTextBox.Text = "";
            // 
            // customersNumericUpDown
            // 
            this.customersNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perfomancetbBindingSource, "customers", true));
            this.customersNumericUpDown.Location = new System.Drawing.Point(130, 91);
            this.customersNumericUpDown.Name = "customersNumericUpDown";
            this.customersNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.customersNumericUpDown.TabIndex = 32;
            // 
            // vistorsNumericUpDown
            // 
            this.vistorsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perfomancetbBindingSource, "vistors", true));
            this.vistorsNumericUpDown.Location = new System.Drawing.Point(130, 61);
            this.vistorsNumericUpDown.Name = "vistorsNumericUpDown";
            this.vistorsNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.vistorsNumericUpDown.TabIndex = 31;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perfomancetbBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(130, 26);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 24;
            // 
            // perfomancetbTableAdapter
            // 
            this.perfomancetbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.perfomancetbTableAdapter = this.perfomancetbTableAdapter;
            this.tableAdapterManager.UpdateOrder = sofstoreInventorySystem.perfomanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // perfomancetbBindingNavigator
            // 
            this.perfomancetbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.perfomancetbBindingNavigator.BindingSource = this.perfomancetbBindingSource;
            this.perfomancetbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.perfomancetbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.perfomancetbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.perfomancetbBindingNavigatorSaveItem});
            this.perfomancetbBindingNavigator.Location = new System.Drawing.Point(0, 72);
            this.perfomancetbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.perfomancetbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.perfomancetbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.perfomancetbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.perfomancetbBindingNavigator.Name = "perfomancetbBindingNavigator";
            this.perfomancetbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.perfomancetbBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.perfomancetbBindingNavigator.TabIndex = 9;
            this.perfomancetbBindingNavigator.Text = "bindingNavigator1";
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
            // perfomancetbBindingNavigatorSaveItem
            // 
            this.perfomancetbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perfomancetbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("perfomancetbBindingNavigatorSaveItem.Image")));
            this.perfomancetbBindingNavigatorSaveItem.Name = "perfomancetbBindingNavigatorSaveItem";
            this.perfomancetbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.perfomancetbBindingNavigatorSaveItem.Text = "Save Data";
            this.perfomancetbBindingNavigatorSaveItem.Click += new System.EventHandler(this.perfomancetbBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.logopicbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 72);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 446);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Expenses";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Creditors ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // perfomancefm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 446);
            this.Controls.Add(this.perfomancetbBindingNavigator);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "perfomancefm";
            this.Load += new System.EventHandler(this.perfomancefm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomanceDataSet)).EndInit();
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistorsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfomancetbBindingNavigator)).EndInit();
            this.perfomancetbBindingNavigator.ResumeLayout(false);
            this.perfomancetbBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custlbl;
        private System.Windows.Forms.PictureBox logopicbox;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.GroupBox customergroupBox;
        private perfomanceDataSet perfomanceDataSet;
        private System.Windows.Forms.BindingSource perfomancetbBindingSource;
        private perfomanceDataSetTableAdapters.perfomancetbTableAdapter perfomancetbTableAdapter;
        private perfomanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator perfomancetbBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton perfomancetbBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView perfomancetbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.RichTextBox cust_requestRichTextBox;
        private System.Windows.Forms.NumericUpDown customersNumericUpDown;
        private System.Windows.Forms.NumericUpDown vistorsNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}