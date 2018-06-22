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
    public partial class creditorfm : Form
    {
        public creditorfm()
        {
            InitializeComponent();
        }

        private void creditortbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creditortbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditorsDataSet);

        }

        private void creditorfm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditorsDataSet.creditortb' table. You can move, or remove it, as needed.
            this.creditortbTableAdapter.Fill(this.creditorsDataSet.creditortb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform main = new mainform();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            creditorsrecordsfm crerec = new creditorsrecordsfm();
            crerec.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfomancefm perfm = new perfomancefm();
            perfm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            expense exp = new expense();
            exp.ShowDialog();
        }
    }
}
