using dbframework1;
using StudentsManagment.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagment.Screens
{
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            dbsqlserver db = new dbsqlserver(Utilities.appsetting.connectionstring());
            if (isvalid())
            {
                bool islogincorrect =Convert.ToBoolean( db.getscalarvalue("usp_logincheak",get_parameter()));
                if (islogincorrect)
                {
                    this.Hide();
                    DashboardForm df = new DashboardForm();
                    df.Show();
                }else 
                {
                    MessageBox.Show("Invalid ! Record not Found", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private dbparameter[] get_parameter()
        {
            List<dbparameter> parameters = new List<dbparameter>();
            dbparameter para1 = new dbparameter();
            para1.parameter = "@username";
            para1.value=usernamebox.Text;
            parameters.Add(para1);
            dbparameter para2 = new dbparameter();
            para2.parameter = "@password";
            para2.value=passwordbox.Text;
            parameters.Add(para2);

            return parameters.ToArray();    
        }

        private bool isvalid()
        {   
            if(usernamebox.Text.Trim()==string.Empty) 
            {
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK);
                usernamebox.Clear();
                usernamebox.Focus();
                return false;
            }
            if (passwordbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK);
                passwordbox.Clear();
                passwordbox.Focus();
                return false;
            }
            return true;
        }
    }
}
