﻿namespace sofstoreInventorySystem
{
    partial class debtors
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
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debtors));
            this.custlbl = new System.Windows.Forms.Label();
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.headerlbl = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.debtortbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorDataSet = new sofstoreInventorySystem.debtorDataSet();
            this.debtortbTableAdapter = new sofstoreInventorySystem.debtorDataSetTableAdapters.debtortbTableAdapter();
            this.tableAdapterManager = new sofstoreInventorySystem.debtorDataSetTableAdapters.TableAdapterManager();
            this.debtortbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.debtortbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.balanceComboBox = new System.Windows.Forms.ComboBox();
            this.customerDataSet = new sofstoreInventorySystem.customerDataSet();
            this.customerdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_detailsTableAdapter = new sofstoreInventorySystem.customerDataSetTableAdapters.customer_detailsTableAdapter();
            fnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.content.SuspendLayout();
            this.panel2.SuspendLayout();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtortbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtortbBindingNavigator)).BeginInit();
            this.debtortbBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).BeginInit();
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
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(22, 64);
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
            this.custlbl.Location = new System.Drawing.Point(138, 37);
            this.custlbl.Name = "custlbl";
            this.custlbl.Size = new System.Drawing.Size(203, 18);
            this.custlbl.TabIndex = 2;
            this.custlbl.Text = "DEBTORS REGISTERATION FORM";
            // 
            // logopicbox
            // 
            this.logopicbox.Image = global::sofstoreInventorySystem.Properties.Resources.soflogoo;
            this.logopicbox.Location = new System.Drawing.Point(3, 3);
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
            this.headerlbl.Location = new System.Drawing.Point(93, 3);
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
            this.headerpanel.Size = new System.Drawing.Size(503, 72);
            this.headerpanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.logopicbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 72);
            this.panel1.TabIndex = 3;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Purple;
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.customergroupBox);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(503, 237);
            this.content.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 237);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Debtors Records";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customergroupBox
            // 
            this.customergroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customergroupBox.Controls.Add(this.balanceComboBox);
            this.customergroupBox.Controls.Add(this.nameComboBox);
            this.customergroupBox.Controls.Add(fnameLabel);
            this.customergroupBox.Controls.Add(emailLabel);
            this.customergroupBox.Location = new System.Drawing.Point(116, 114);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(343, 112);
            this.customergroupBox.TabIndex = 0;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "REGISTER FORM";
            // 
            // debtortbBindingSource
            // 
            this.debtortbBindingSource.DataMember = "debtortb";
            this.debtortbBindingSource.DataSource = this.debtorDataSet;
            // 
            // debtorDataSet
            // 
            this.debtorDataSet.DataSetName = "debtorDataSet";
            this.debtorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtortbTableAdapter
            // 
            this.debtortbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.debtortbTableAdapter = this.debtortbTableAdapter;
            this.tableAdapterManager.UpdateOrder = sofstoreInventorySystem.debtorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // debtortbBindingNavigator
            // 
            this.debtortbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.debtortbBindingNavigator.BindingSource = this.debtortbBindingSource;
            this.debtortbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.debtortbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.debtortbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.debtortbBindingNavigatorSaveItem});
            this.debtortbBindingNavigator.Location = new System.Drawing.Point(0, 72);
            this.debtortbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.debtortbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.debtortbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.debtortbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.debtortbBindingNavigator.Name = "debtortbBindingNavigator";
            this.debtortbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.debtortbBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.debtortbBindingNavigator.TabIndex = 9;
            this.debtortbBindingNavigator.Text = "bindingNavigator1";
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
            // debtortbBindingNavigatorSaveItem
            // 
            this.debtortbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debtortbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("debtortbBindingNavigatorSaveItem.Image")));
            this.debtortbBindingNavigatorSaveItem.Name = "debtortbBindingNavigatorSaveItem";
            this.debtortbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.debtortbBindingNavigatorSaveItem.Text = "Save Data";
            this.debtortbBindingNavigatorSaveItem.Click += new System.EventHandler(this.debtortbBindingNavigatorSaveItem_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtortbBindingSource, "name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerdetailsBindingSource, "customer_name", true));
            this.nameComboBox.DataSource = this.customerdetailsBindingSource;
            this.nameComboBox.DisplayMember = "customer_name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(104, 28);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(193, 21);
            this.nameComboBox.TabIndex = 14;
            this.nameComboBox.ValueMember = "customer_name";
            // 
            // balanceComboBox
            // 
            this.balanceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtortbBindingSource, "balance", true));
            this.balanceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerdetailsBindingSource, "balance", true));
            this.balanceComboBox.DataSource = this.customerdetailsBindingSource;
            this.balanceComboBox.DisplayMember = "balance";
            this.balanceComboBox.FormattingEnabled = true;
            this.balanceComboBox.Location = new System.Drawing.Point(104, 63);
            this.balanceComboBox.Name = "balanceComboBox";
            this.balanceComboBox.Size = new System.Drawing.Size(193, 21);
            this.balanceComboBox.TabIndex = 15;
            this.balanceComboBox.ValueMember = "balance";
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "customerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerdetailsBindingSource
            // 
            this.customerdetailsBindingSource.DataMember = "customer_details";
            this.customerdetailsBindingSource.DataSource = this.customerDataSet;
            // 
            // customer_detailsTableAdapter
            // 
            this.customer_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // debtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 237);
            this.Controls.Add(this.debtortbBindingNavigator);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.content);
            this.Name = "debtors";
            this.Load += new System.EventHandler(this.debtors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtortbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtortbBindingNavigator)).EndInit();
            this.debtortbBindingNavigator.ResumeLayout(false);
            this.debtortbBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).EndInit();
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
        private debtorDataSet debtorDataSet;
        private System.Windows.Forms.BindingSource debtortbBindingSource;
        private debtorDataSetTableAdapters.debtortbTableAdapter debtortbTableAdapter;
        private debtorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator debtortbBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton debtortbBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox balanceComboBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private customerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerdetailsBindingSource;
        private customerDataSetTableAdapters.customer_detailsTableAdapter customer_detailsTableAdapter;
    }
}