using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofstoreInventorySystem
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void salestbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salestbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesDataSet);

        }

        private void sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier_details' table. You can move, or remove it, as needed.
            this.supplier_detailsTableAdapter.Fill(this.supplierDataSet.supplier_details);
            // TODO: This line of code loads data into the 'purchasesDataSet.stock_details' table. You can move, or remove it, as needed.
            this.stock_detailsTableAdapter.Fill(this.purchasesDataSet.stock_details);
            // TODO: This line of code loads data into the 'categoryDataSet.categorytb' table. You can move, or remove it, as needed.
            this.categorytbTableAdapter.Fill(this.categoryDataSet.categorytb);
            // TODO: This line of code loads data into the 'customerDataSet.customer_details' table. You can move, or remove it, as needed.
            this.customer_detailsTableAdapter.Fill(this.customerDataSet.customer_details);
            // TODO: This line of code loads data into the 'adminDataSet.admintb' table. You can move, or remove it, as needed.
            this.admintbTableAdapter.Fill(this.adminDataSet.admintb);
            // TODO: This line of code loads data into the 'salesDataSet.salestb' table. You can move, or remove it, as needed.
            this.salestbTableAdapter.Fill(this.salesDataSet.salestb);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords Suprec = new supplierrecords();
            Suprec.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            category cat = new category();
            cat.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock st = new stock();
            st.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchasesfm pur = new purchasesfm();
            pur.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction tranfm = new transaction();
            tranfm.ShowDialog();
        }
    }
}
