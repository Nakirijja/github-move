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
    public partial class adminregisterfm : Form
    {
        public adminregisterfm()
        {
            InitializeComponent();
        }

        private void admintbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.admintbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adminDataSet);

        }

        private void adminregisterfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDataSet.admintb' table. You can move, or remove it, as needed.
            this.admintbTableAdapter.Fill(this.adminDataSet.admintb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform main = new mainform();
            main.Show();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userfm sue = new userfm();
            sue.Show();
        }
    }
}
