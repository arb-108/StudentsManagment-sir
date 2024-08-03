using StudentsManagment.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagment.Screens
{
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A PUCIT Student Develop this Project", "About", MessageBoxButtons.OK);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            branches brancheslist=new branches();
            brancheslist.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            combobox cb=new combobox();
            cb.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
