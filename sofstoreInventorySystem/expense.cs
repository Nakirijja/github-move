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
    public partial class expense : Form
    {
        public expense()
        {
            InitializeComponent();
        }

        private void expensetbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expensetbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expenseDataSet);

        }

        private void expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenseDataSet.expensetb' table. You can move, or remove it, as needed.
            this.expensetbTableAdapter.Fill(this.expenseDataSet.expensetb);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfomancefm perfm = new perfomancefm();
            perfm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            creditorsrecordsfm cre = new creditorsrecordsfm();
            cre.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mnfm = new mainform();
            mnfm.ShowDialog();
        }
    }
}
