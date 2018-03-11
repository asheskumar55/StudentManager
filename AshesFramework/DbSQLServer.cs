using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesFramework
{
    public class DbSQLServer
    {
        //ExecuteReader, ExecuteScalar and ExecuteNoQuery
        private string _connstring;

        public DbSQLServer(string connstring)
        {
            _connstring = connstring;

        }

        //Overloading Function
        public object GetScalarValue(string storedProceName)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    value = cmd.ExecuteScalar();
                }
                return value;

            }
        }
        public object GetScalarValue(string storedProceName, DbParameter parameter)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    value = cmd.ExecuteScalar();
                }
                return value;

            }
        }

        public object GetScalarValue(string storedProceName, DbParameter[] parameters)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    foreach (var para in parameters)
                    {

                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    value = cmd.ExecuteScalar();

                }
                
            }
            return value;


        }
    }
}
