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
    public partial class debtors : Form
    {
        public debtors()
        {
            InitializeComponent();
        }

        private void debtortbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.debtortbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.debtorDataSet);

        }

        private void debtors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.customer_details' table. You can move, or remove it, as needed.
            this.customer_detailsTableAdapter.Fill(this.customerDataSet.customer_details);
            // TODO: This line of code loads data into the 'debtorDataSet.debtortb' table. You can move, or remove it, as needed.
            this.debtortbTableAdapter.Fill(this.debtorDataSet.debtortb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mafm = new mainform();
            mafm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            debtorsrecords debtfm = new debtorsrecords();
            debtfm.ShowDialog();
        }
    }
}
