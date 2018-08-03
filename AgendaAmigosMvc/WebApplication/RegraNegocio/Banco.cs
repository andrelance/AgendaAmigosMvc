using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication.Resources
{
    public class Banco
    {
        public string str_conn { get; set; }
        public string err { get; set; }

        private SqlConnection conn;
        private SqlCommand comm;
        private SqlDataReader datareader;

        public bool conectar()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection();
                }
                conn.ConnectionString = str_conn;

                conn.Open();

                return conn.State ==
                       System.Data.ConnectionState.Open;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }

        public bool desconectar()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn = null;
            return true;
        }

        public bool Executar(string comando, bool select)
        {
            comm = conn.CreateCommand();
            comm.CommandText = comando;
            comm.CommandType = CommandType.Text;

            if (select)
            {
                datareader = comm.ExecuteReader();
                return datareader != null;
            }
            else
            {
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public DataTable Get_Values(string dt_name)
        {
            DataTable datatable = new DataTable(dt_name);
            datatable.Load(datareader);
            return datatable;
        }
    }
}