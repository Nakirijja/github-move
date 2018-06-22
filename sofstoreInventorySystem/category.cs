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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        private void categorytbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorytbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoryDataSet);

        }

        private void category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryDataSet.categorytb' table. You can move, or remove it, as needed.
            this.categorytbTableAdapter.Fill(this.categoryDataSet.categorytb);
            // TODO: This line of code loads data into the 'categoryDataSet.categorytb' table. You can move, or remove it, as needed.
            this.categorytbTableAdapter.Fill(this.categoryDataSet.categorytb);

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void stoCk_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock st = new stock();
            st.ShowDialog();
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

        private void categorytbBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categorytbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoryDataSet);

        }
    }
}
