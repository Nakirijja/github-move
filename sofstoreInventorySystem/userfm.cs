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
    public partial class userfm : Form
    {
        public userfm()
        {
            InitializeComponent();
        }

        private void admintbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.admintbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adminDataSet);

        }

        private void userfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDataSet.admintb' table. You can move, or remove it, as needed.
            this.admintbTableAdapter.Fill(this.adminDataSet.admintb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminregisterfm admnfm = new adminregisterfm();
            admnfm.Show();
           
        }
    }
}
