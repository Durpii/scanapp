using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ScanApp.DAO
{
    public class CheckInDAO
    {
        //location of "ConnStr" is located in Web.config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);

        public void InsertUser(string name, string rank)
        {
            string query = "INSERT into Users1(name, rank, opreadydate, datein, timein, timeout, role, accountenabled) values (@paraName, @paraRank, @paraOpReadyDate, @paraDateIn, @paraTimeIn, @paraTimeOut, @paraRole, @paraAccountEnabled)";

            string opreadydate = null;
            string datein = DateTime.Today.ToString("ddMMyyyy");
            string timein = DateTime.Now.ToString("HHmm");
            string timeout = null;

            conn.Open();

            SqlCommand InsertConn = new SqlCommand(query, conn);
            InsertConn.Parameters.AddWithValue("@paraName", name);
            InsertConn.Parameters.AddWithValue("@paraRank", rank);

            if (String.IsNullOrEmpty(opreadydate))
            {
                InsertConn.Parameters.AddWithValue("@paraOpReadyDate", DBNull.Value);
            } else
            {
                InsertConn.Parameters.AddWithValue("@paraOpReadyDate", opreadydate);
            }
            //InsertConn.Parameters.AddWithValue("@paraOpReadyDate", opreadydate);
            //change ORD date parameters when i figure out how to add them properly
            InsertConn.Parameters.AddWithValue("@paraDateIn", datein);
            InsertConn.Parameters.AddWithValue("@paraTimeIn", timein);

            if (String.IsNullOrEmpty(timeout))
            {
                InsertConn.Parameters.AddWithValue("@paraTimeOut", DBNull.Value);
            } else
            {
                InsertConn.Parameters.AddWithValue("@paraTimeOut", timeout);
            }
            //InsertConn.Parameters.AddWithValue("@paraTimeOut", timeout);
            InsertConn.Parameters.AddWithValue("@paraRole", "User");
            InsertConn.Parameters.AddWithValue("@paraAccountEnabled", 1);

            InsertConn.ExecuteNonQuery();
            conn.Close();
        }

        public string GetUserDateIn(string name, string rank)
        {
            string query = "SELECT datein FROM Users1 WHERE name = '@paraName' AND rank = '@paraRank'";
            User u = new User();
            //string datein;

            conn.Open();

            SqlCommand RetrieveConn = new SqlCommand(query, conn);
            RetrieveConn.Parameters.AddWithValue("@paraName", name);
            RetrieveConn.Parameters.AddWithValue("@paraRank", rank);

            SqlDataReader reader = RetrieveConn.ExecuteReader();

            while (reader.Read())
            {
                u.datein = reader["DateIn"].ToString();
            }

            //datein = RetrieveConn.ExecuteScalar().ToString();

            conn.Close();

            return u.datein;
        }

        public string GetUserTimeIn(string name, string rank)
        {
            string query = "SELECT TimeIn FROM Users1 WHERE name = '@paraName' AND rank = '@paraRank'";
            User u = new User();

            conn.Open();

            SqlCommand RetrieveConn = new SqlCommand(query, conn);
            RetrieveConn.Parameters.AddWithValue("@paraName", name);
            RetrieveConn.Parameters.AddWithValue("@paraRank", rank);

            using (SqlDataReader reader = RetrieveConn.ExecuteReader())
            {
                while (reader.Read())
                {
                    u.timein = reader["TimeIn"].ToString();
                }
            }

            //timein = RetrieveConn.ExecuteScalar().ToString();

            conn.Close();

            return u.timein;
        }
    }
}