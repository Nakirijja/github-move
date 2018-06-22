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
    public partial class purchasesfm : Form
    {
        public purchasesfm()
        {
            InitializeComponent();
        }

        private void stock_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stock_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchasesDataSet);

        }

        private void purchasesfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryDataSet.categorytb' table. You can move, or remove it, as needed.
            this.categorytbTableAdapter.Fill(this.categoryDataSet.categorytb);
            // TODO: This line of code loads data into the 'supplierDataSet.supplier_details' table. You can move, or remove it, as needed.
            this.supplier_detailsTableAdapter.Fill(this.supplierDataSet.supplier_details);
            // TODO: This line of code loads data into the 'purchasesDataSet.stock_details' table. You can move, or remove it, as needed.
            this.stock_detailsTableAdapter.Fill(this.purchasesDataSet.stock_details);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords rec = new supplierrecords();
            rec.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            category catfm = new category();
            catfm.ShowDialog();
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
            sales salfm = new sales();
            salfm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction tranfm = new transaction();
            tranfm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }
    }
}
