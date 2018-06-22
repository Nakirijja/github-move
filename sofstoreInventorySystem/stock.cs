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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void stock_availBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_availBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stockavailDataSet);

        }

        private void stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockavailDataSet.stock_avail' table. You can move, or remove it, as needed.
            this.stock_availTableAdapter.Fill(this.stockavailDataSet.stock_avail);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchasesfm purc = new purchasesfm();
            purc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sales salfm = new sales();
            salfm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction tranfm = new transaction();
            tranfm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            category catfm = new category();
            catfm.ShowDialog();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords rec = new supplierrecords();
            rec.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }
    }
}
