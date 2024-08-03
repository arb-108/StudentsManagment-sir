using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagment.Utilities
{
    public class appsetting
    {
        public static string connectionstring()
        {
            return ConfigurationManager.ConnectionStrings["StudentsManagment.Properties.Settings.studentmanagerConnectionString"].ConnectionString;
        }
    }
}
