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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            //new mainform().IsMdiContainer = true;
        }
        private void pURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchasesfm purcfm = new purchasesfm();
            //purcfm.MdiParent = this;
            purcfm.Show();
        }

        private void aGVAILABLESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock availstock = new stock();
            //availstock.MdiParent = this;
            availstock.Show();

        }

        private void sALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sales salesfm = new sales();
           // salesfm.MdiParent = this;
            salesfm.Show();
        }

        private void aDDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierfm suppfm = new supplierfm();
            //suppfm.MdiParent = this;
            suppfm.Show();
        }

        private void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords supprec = new supplierrecords();
            //supprec.MdiParent = this;
            supprec.Show();
        }

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            category catfm = new category();
            //catfm.MdiParent = this;
            catfm.Show();
        }

        private void tRANSACTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction transfm = new transaction();
            //transfm.MdiParent = this;
            transfm.Show();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerfm custfm = new customerfm();
            //custfm.MdiParent = this;
            custfm.Show();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerRecordsfm custrec = new customerRecordsfm();
           // custrec.MdiParent = this;
            custrec.Show();
        }

        private void dEBTORSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            debtors debtfm = new debtors();
            //debtfm.MdiParent = this;
            debtfm.Show();
        }

        private void vIEWToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            debtorsrecords debtrec = new debtorsrecords();
           // debtrec.MdiParent = this;
            debtrec.Show();
        }

        private void dAILYPERFORMANEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfomancefm perffm = new perfomancefm();
            //perffm.MdiParent = this;
            perffm.Show();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creditorfm credfm = new creditorfm();
            //credfm.MdiParent = this;
            credfm.Show();
        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creditorsrecordsfm credrec = new creditorsrecordsfm();
           // credrec.MdiParent = this;
            credrec.Show();
        }

        private void aDDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userfm admin = new userfm();
            //admin.MdiParent = this;
            admin.Show();
        }

        private void vIEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminregisterfm admfm = new adminregisterfm();
            //admfm.MdiParent = this;
            admfm.Show();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Aboutsof abtsof = new Aboutsof();
            //abtsof.MdiParent = this;
            abtsof.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform main = new mainform();
            main.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminregisterfm adm = new adminregisterfm();
            adm.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerRecordsfm custrec = new customerRecordsfm();
            custrec.Show();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplierrecords supprec = new supplierrecords();
            supprec.Show();
        }

        private void stoCk_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock stfm = new stock();
            stfm.Show();
        }

        private void store_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfomancefm perffm = new perfomancefm();
            perffm.Show(); 

        }

        private void eXPENSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            expense exp = new expense();
           // exp.MdiParent = this;
            exp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            mainform mainfm = new mainform();
            mainfm.ShowDialog();
        }

       
    }
}
