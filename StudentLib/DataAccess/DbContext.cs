using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace StudentLib.DataAccess
{
    public class DbContext
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter adp = new SqlDataAdapter();
        //DataTable dt = new DataTable();

        public void Openconnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = conn;
                cmd.Connection = con;
                con.Open();
            }
        }
        public void Closeconnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //to retrieve the data in dataset
        public DataSet GetDataSet(string query)
        {
            Openconnection();
            DataSet ds = new DataSet();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            Closeconnection();
            return ds;
        }
        //to retrieve the data in datatable
        public DataTable GetdataTable(string Query)
        {
            DataTable dt = new DataTable();
            Openconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query;
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            Closeconnection();
            return dt;
        }

        //to retrieve the data in dataset without paramater as procedure
        public DataSet GetProc(string query)
        {
            Openconnection();
            DataSet ds = new DataSet();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            Closeconnection();
            return ds;

        }
        //to retrieve the data in dataset with paramater as procedure
        public DataSet GetDataProc(string query, SqlParameter[] Param)
        {
            Openconnection();
            DataSet ds = new DataSet();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            foreach (SqlParameter Param1 in Param)
            {
                cmd.Parameters.Add(Param1);
            }
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            Closeconnection();
            return ds;

        }
        // procedure to insert/update/delte
        public int ExecuteProc(string query, SqlParameter[] Param)
        {
            Openconnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            foreach (SqlParameter Param1 in Param)
            {
                cmd.Parameters.Add(Param1);
            }
            int i = cmd.ExecuteNonQuery();
            Closeconnection();
            return i;
        }
        public int ExecuteNonQuery(string query)
        {
            Openconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            int i = cmd.ExecuteNonQuery();
            Closeconnection();
            return i;

        }

    }
}
