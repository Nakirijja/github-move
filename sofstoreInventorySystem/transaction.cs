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
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transationDataSet);

        }

        private void transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier_details' table. You can move, or remove it, as needed.
            this.supplier_detailsTableAdapter.Fill(this.supplierDataSet.supplier_details);
            // TODO: This line of code loads data into the 'transationDataSet.transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transationDataSet.transactions);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();

        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords supprec = new supplierrecords();
            supprec.ShowDialog();
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
            sales slfm = new sales();
            slfm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchasesfm purfm = new purchasesfm();
            purfm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();
        }
    }
}
