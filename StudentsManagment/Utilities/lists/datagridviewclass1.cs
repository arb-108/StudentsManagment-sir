using dbframework1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagment.Utilities.lists
{
    public class datagridviewclass1
    {
        public static void loaddataintodatagridview(DataGridView dgv,string storeproce)
        {   
            dbsqlserver db= new dbsqlserver(appsetting.connectionstring());
            DataTable dt=new DataTable();
            dt=db.getlist(storeproce);
            dgv.DataSource = dt;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }
    }
}
