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
    public partial class customerfm : Form
    {
        public customerfm()
        {
            InitializeComponent();
        }

        private void customer_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customer_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

        }

        private void customerfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.customer_details' table. You can move, or remove it, as needed.
            this.customer_detailsTableAdapter.Fill(this.customerDataSet.customer_details);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform maifm = new mainform();
            maifm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerRecordsfm cudtrec = new customerRecordsfm();
            cudtrec.ShowDialog();
        }
    }
}
