using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManagment.Screens.Templates;
using StudentsManagment.Screens.Branches;
using StudentsManagment.Utilities.lists;

namespace StudentsManagment.Screens
{
    public partial class branches : TemplateForm
    {
        public branches()
        {
            InitializeComponent();
        }

        private void branches1_Load(object sender, EventArgs e)
        {
            loaddataintodatagridview();
        }

        private void loaddataintodatagridview()
        {
            datagridviewclass1.loaddataintodatagridview(branchesdataGridView, "usp_branches");
        }

        private void cLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBraanchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getbranchinfoform(0,false);
        }

        private static void getbranchinfoform(int branch_id,bool isupdated)
        {
            branchInfoForm1 bif = new branchInfoForm1();
            bif.branchid = branch_id;
            bif.Isupdate = isupdated;
            bif.ShowDialog();
        }

        private void branchesdataGridView_DoubleClick(object sender, EventArgs e)
        {   
            int rowindex=branchesdataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int branch_id = Convert.ToInt32(branchesdataGridView.Rows[rowindex].Cells["branch_id"].Value);
            getbranchinfoform(branch_id,true);

        }
    }
}
