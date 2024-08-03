using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbframework1;
using StudentsManagment.Screens.Templates;
using StudentsManagment.Utilities;

namespace StudentsManagment.Screens.Branches
{
    public partial class branchInfoForm1 : TemplateForm
    {
        public branchInfoForm1()
        {
            InitializeComponent();
        }
        public int branchid { get; set; }

        private void branchInfoForm1_Load(object sender, EventArgs e)
        {
            loaddataintoformisupdated();
            //SqlConnection conn = new SqlConnection(appsetting.connectionstring());

            //SqlCommand cmd = new SqlCommand("usp_getcountries", conn);

            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    citycomboBox.Items.Add(dr["name"]);
            //}
        }                           








        //private void loaddataintocombobox1()
        //{
        //    //DataTable dt= new DataTable();
        //    //dbsqlserver db =new dbsqlserver(appsetting.connectionstring());
        //    //SqlDataReader dr =(SqlDataReader)db.getcountry("usp_getcountries");
        //    //while (dr.Read())
        //    //{
        //    //    citycomboBox.Items.Add(dr["name"]);
        //    //}
        //    SqlConnection conn = new SqlConnection(appsetting.connectionstring());

        //    SqlCommand cmd = new SqlCommand("usp_getcountries", conn);
            
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //    conn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        citycomboBox.Items.Add(dr["name"]);
        //    }
        //}
        

        

        private void loaddataintoformisupdated()
        {   
            DataTable dt=new DataTable();
            dbsqlserver db = new dbsqlserver(Utilities.appsetting.connectionstring());
            dbparameter para= new dbparameter();
            para.parameter = "@branch_id";
            para.value =this.branchid;
            dt=db.getlist("usp_loadbranchestoform",para);
            DataRow dr = dt.Rows[0];
            branchnametextBox.Text = dr["branch_name"].ToString();
            emailtextBox.Text = dr["email"].ToString();
            telephonetextBox.Text = dr["telephone"].ToString();
            websitetextBox.Text = dr["website"].ToString();
            posttextBox.Text = dr["post"].ToString();
            addresstextBox.Text = dr["address"].ToString();
            citycomboBox.SelectedValue = dr["city"];
            districtcomboBox.SelectedValue = dr["district"];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Logo";
            ofd.Filter = "Logo Files(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                logopictureBox.Image=new Bitmap(ofd.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void branchnametextBox_TextChanged(object sender, EventArgs e)
        {
            branchnamelabel.Text = branchnametextBox.Text;
        }
    }
}
