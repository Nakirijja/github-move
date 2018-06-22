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
    public partial class perfomancefm : Form
    {
        public perfomancefm()
        {
            InitializeComponent();
        }

        private void perfomancetbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.perfomancetbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perfomanceDataSet);

        }

        private void perfomancefm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perfomanceDataSet.perfomancetb' table. You can move, or remove it, as needed.
            this.perfomancetbTableAdapter.Fill(this.perfomanceDataSet.perfomancetb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mainfm = new mainform();
            mainfm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            creditorsrecordsfm crerec = new creditorsrecordsfm();
            crerec.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            expense exp = new expense();
            exp.ShowDialog();
        } 
    }
}
