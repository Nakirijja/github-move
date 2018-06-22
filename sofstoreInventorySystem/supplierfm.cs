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
    public partial class supplierfm : Form
    {
        public supplierfm()
        {
            InitializeComponent();
        }

        private void supplier_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplier_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supplierDataSet);

        }

        private void supplierfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplier_details' table. You can move, or remove it, as needed.
            this.supplier_detailsTableAdapter.Fill(this.supplierDataSet.supplier_details);

        }

        private void suppliers_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords rec = new supplierrecords();
            rec.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            category catfm = new category();
            catfm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            stock st = new stock();
            st.ShowDialog();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sales salfm = new sales();
            salfm.ShowDialog();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            purchasesfm purc = new purchasesfm();
            purc.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            transaction tranfm = new transaction();
            tranfm.ShowDialog();
        }
    }
}
