using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbframework1
{
    public class dbsqlserver
    {
        private string _connectionstring;
        public dbsqlserver(string connectionstring) 
        {
            _connectionstring = connectionstring;
        }
        public object getscalarvalue(string storedproce)
        {
            object value = null;
            using(SqlConnection conn=new SqlConnection(_connectionstring)) 
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType=System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        //for parameterized stored procedure
        public object getscalarvalue(string storedproce,dbparameter parameters)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                   
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameters.parameter, parameters.value);
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        public object getscalarvalue(string storedproce, dbparameter[] parameters)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.parameter, para.value);
                    }
                        value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        public DataTable getlist(string storedproce)
        {
             DataTable dt =new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }
        public DataTable getlist(string storedproce, dbparameter parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue(parameters.parameter, parameters.value);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }
        public DataTable getlist(string storedproce, dbparameter[] parameters)
        {
            DataTable dt=new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.parameter, para.value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
            }
            return dt;
        }
        public object getcountry(string storedproce)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedproce, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    return dr;

                }
            }
            
        }

    }
}
