using dbframework1;
using StudentsManagment.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagment.Screens
{
    public partial class combobox : Templates.TemplateForm
    {
        public combobox()
        {
            InitializeComponent();
        }
        int country_id = 167;
        int state_id=3176;

        private void combobox_Load(object sender, EventArgs e)
        {
            intocombobox();

        }

        private void intocombobox()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(appsetting.connectionstring());
            SqlCommand cmd = new SqlCommand("usp_allcountry", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow dr2 = dt.NewRow();
            dr2[0] = -1;
            dr2[1] = "--Select Country--";
            dt.Rows.InsertAt(dr2,0);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = dt;   
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotextBox.Text = comboBox1.Text;
            statetextBox1.Clear();
            textBox3.Clear();
            dbparameter para = new dbparameter();
            
            try
            {
                country_id = int.Parse(comboBox1.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            para.parameter = "@id";
            para.value =country_id;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(appsetting.connectionstring());
            SqlCommand cmd = new SqlCommand("usp_allstates", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            cmd.Parameters.AddWithValue(para.parameter, para.value);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow dr2 = dt.NewRow();
            dr2[0] = 0;
            dr2[1] = "--Select state--";
            dr2[2] = -1;
            dt.Rows.InsertAt(dr2, 0);

            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "name";
            comboBox2.DataSource = dt;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
           
            

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled=true;
            statetextBox1.Text = comboBox2.Text;
            dbparameter para1 = new dbparameter();
            dbparameter para2 = new dbparameter();

            try
            {
                state_id = int.Parse(comboBox2.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            para1.parameter = "@country_id";
            para1.value = country_id;
            para2.parameter = "@state_id";
            para2.value = state_id;
            
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(appsetting.connectionstring());
            SqlCommand cmd = new SqlCommand("usp_cities", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            cmd.Parameters.AddWithValue(para1.parameter, para1.value);
            cmd.Parameters.AddWithValue(para2.parameter, para2.value);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow dr2 = dt.NewRow();
            dr2[0] = 0;
            dr2[1] = "--Select City--";
            dt.Rows.InsertAt(dr2, 0);
            comboBox3.ValueMember = "id";
            comboBox3.DisplayMember = "name";
            comboBox3.DataSource = dt;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox3.Text;
            state_id = -1;
        }
    }
}
