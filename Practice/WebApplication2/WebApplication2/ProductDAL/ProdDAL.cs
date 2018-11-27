using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;

namespace WebApplication2.ProductDAL
{
    public class ProdDAL
    {
        public string Name { get; set; }
      
        public string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public void Selectrecord()
        {
            
            using (SqlConnection conn = new SqlConnection(cs))
                
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "spProd";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();

                    Name = rdr["Name"].ToString();

                }

                finally

                {
                    if (conn != null)

                    {
                        conn.Close();
                    }
                  
                }            
        }

    }
}