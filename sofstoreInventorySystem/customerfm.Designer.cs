namespace sofstoreInventorySystem
{
    partial class customerfm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerfm));
            this.headerpanel = new System.Windows.Forms.Panel();
            this.custlbl = new System.Windows.Forms.Label();
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.headerlbl = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new sofstoreInventorySystem.customerDataSet();
            this.customer_addressTextBox = new System.Windows.Forms.TextBox();
            this.customer_contact1MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.customer_contact2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.customer_detailsTableAdapter = new sofstoreInventorySystem.customerDataSetTableAdapters.customer_detailsTableAdapter();
            this.tableAdapterManager = new sofstoreInventorySystem.customerDataSetTableAdapters.TableAdapterManager();
            this.customer_detailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customer_detailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            fnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contact1Label = new System.Windows.Forms.Label();
            contact2Label = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.content.SuspendLayout();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_detailsBindingNavigator)).BeginInit();
            this.customer_detailsBindingNavigator.SuspendLayout();
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
            fnameLabel.Size = new System.Drawing.Size(50, 16);
            fnameLabel.TabIndex = 0;
            fnameLabel.Text = "NAME:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(22, 65);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(77, 16);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "ADDRESS:";
            // 
            // contact1Label
            // 
            contact1Label.AutoSize = true;
            contact1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact1Label.Location = new System.Drawing.Point(22, 91);
            contact1Label.Name = "contact1Label";
            contact1Label.Size = new System.Drawing.Size(91, 16);
            contact1Label.TabIndex = 6;
            contact1Label.Text = "CONTACT(1):";
            // 
            // contact2Label
            // 
            contact2Label.AutoSize = true;
            contact2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact2Label.Location = new System.Drawing.Point(22, 117);
            contact2Label.Name = "contact2Label";
            contact2Label.Size = new System.Drawing.Size(91, 16);
            contact2Label.TabIndex = 8;
            contact2Label.Text = "CONTACT(2):";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(22, 143);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(73, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "BALANCE:";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.headerpanel.Controls.Add(this.panel1);
            this.headerpanel.Controls.Add(this.custlbl);
            this.headerpanel.Controls.Add(this.headerlbl);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(550, 72);
            this.headerpanel.TabIndex = 5;
            // 
            // custlbl
            // 
            this.custlbl.AutoSize = true;
            this.custlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.custlbl.Location = new System.Drawing.Point(191, 50);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(215, 18);
            this.custlbl.TabIndex = 2;
            this.custlbl.Text = "CUSTOMER REGISTERATION FORM";
            // 
            // logopicbox
            // 
            this.logopicbox.Image = global::sofstoreInventorySystem.Properties.Resources.soflogoo;
            this.logopicbox.Location = new System.Drawing.Point(0, 3);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(84, 65);
            this.logopicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopicbox.TabIndex = 1;
            this.logopicbox.TabStop = false;
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.Location = new System.Drawing.Point(106, 9);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(384, 24);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "SISTERS OF FAITH CLOTHING STORE";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Purple;
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.customergroupBox);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(550, 316);
            this.content.TabIndex = 6;
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
            this.customergroupBox.Location = new System.Drawing.Point(131, 116);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(359, 170);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "REGISTER FORM";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_detailsBindingSource, "customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(128, 32);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_nameTextBox.TabIndex = 13;
            // 
            // customer_detailsBindingSource
            // 
            this.customer_detailsBindingSource.DataMember = "customer_details";
            this.customer_detailsBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_addressTextBox
            // 
            this.customer_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_detailsBindingSource, "customer_address", true));
            this.customer_addressTextBox.Location = new System.Drawing.Point(128, 58);
            this.customer_addressTextBox.Name = "customer_addressTextBox";
            this.customer_addressTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_addressTextBox.TabIndex = 15;
            // 
            // customer_contact1MaskedTextBox
            // 
            this.customer_contact1MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_detailsBindingSource, "customer_contact1", true));
            this.customer_contact1MaskedTextBox.Location = new System.Drawing.Point(128, 84);
            this.customer_contact1MaskedTextBox.Mask = "0000-000000";
            this.customer_contact1MaskedTextBox.Name = "customer_contact1MaskedTextBox";
            this.customer_contact1MaskedTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_contact1MaskedTextBox.TabIndex = 17;
            // 
            // customer_contact2MaskedTextBox
            // 
            this.customer_contact2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_detailsBindingSource, "customer_contact2", true));
            this.customer_contact2MaskedTextBox.Location = new System.Drawing.Point(128, 110);
            this.customer_contact2MaskedTextBox.Mask = "0000-000000";
            this.customer_contact2MaskedTextBox.Name = "customer_contact2MaskedTextBox";
            this.customer_contact2MaskedTextBox.Size = new System.Drawing.Size(179, 20);
            this.customer_contact2MaskedTextBox.TabIndex = 19;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_detailsBindingSource, "balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(128, 136);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(179, 20);
            this.balanceTextBox.TabIndex = 21;
            // 
            // customer_detailsTableAdapter
            // 
            this.customer_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_detailsTableAdapter = this.customer_detailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = sofstoreInventorySystem.customerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_detailsBindingNavigator
            // 
            this.customer_detailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customer_detailsBindingNavigator.BindingSource = this.customer_detailsBindingSource;
            this.customer_detailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customer_detailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customer_detailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customer_detailsBindingNavigatorSaveItem});
            this.customer_detailsBindingNavigator.Location = new System.Drawing.Point(0, 72);
            this.customer_detailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customer_detailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customer_detailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customer_detailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customer_detailsBindingNavigator.Name = "customer_detailsBindingNavigator";
            this.customer_detailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customer_detailsBindingNavigator.Size = new System.Drawing.Size(550, 25);
            this.customer_detailsBindingNavigator.TabIndex = 7;
            this.customer_detailsBindingNavigator.Text = "bindingNavigator1";
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
            // customer_detailsBindingNavigatorSaveItem
            // 
            this.customer_detailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customer_detailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customer_detailsBindingNavigatorSaveItem.Image")));
            this.customer_detailsBindingNavigatorSaveItem.Name = "customer_detailsBindingNavigatorSaveItem";
            this.customer_detailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customer_detailsBindingNavigatorSaveItem.Text = "Save Data";
            this.customer_detailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.customer_detailsBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "CUSTOMER RECORDS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logopicbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 72);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 316);
            this.panel2.TabIndex = 4;
            // 
            // customerfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 316);
            this.Controls.Add(this.customer_detailsBindingNavigator);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "customerfm";
            this.Load += new System.EventHandler(this.customerfm_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.content.ResumeLayout(false);
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_detailsBindingNavigator)).EndInit();
            this.customer_detailsBindingNavigator.ResumeLayout(false);
            this.customer_detailsBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label custlbl;
        private System.Windows.Forms.PictureBox logopicbox;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.GroupBox customergroupBox;
        private customerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customer_detailsBindingSource;
        private customerDataSetTableAdapters.customer_detailsTableAdapter customer_detailsTableAdapter;
        private customerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customer_detailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customer_detailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox customer_addressTextBox;
        private System.Windows.Forms.MaskedTextBox customer_contact1MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox customer_contact2MaskedTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}