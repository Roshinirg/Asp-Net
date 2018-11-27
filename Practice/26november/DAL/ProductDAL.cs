using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace _26november.DAL
{
    public class ProductDAL
    {
        public string Name { get; set; }
        public string Update_Name { get; set; }
        public string path = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public bool Addrecord()
        {
            bool isSuccess = true;
            using (SqlConnection conn = new SqlConnection(path))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Products(Name) values('" + Name + "')";
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected < 1)
                    {
                        throw new Exception("Could not save the data");
                    }
                }
                catch (Exception ex)

                {
                    isSuccess = false;
                }
                finally

                {
                    conn.Close();
                }
            return isSuccess;
        }

        public bool Deleterecord()
        {
            bool isSuccess = true;
            using (SqlConnection conn = new SqlConnection(path))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from Products where Name=('" + Name + "')";
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected < 1)
                    {
                        throw new Exception("Could not delete the data");
                    }
                }
                catch (Exception ex)

                {
                    isSuccess = false;
                }
                finally

                {
                    conn.Close();
                }
            return isSuccess;
        }
        public bool Updaterecord()
        {
            bool isSuccess = true;
            using (SqlConnection conn = new SqlConnection(path))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update Products Set Name=('" + Update_Name + "')where Name=('" + Name + "')";
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected < 1)
                    {
                        throw new Exception("Could not update the data");
                    }
                }
                catch (Exception ex)

                {
                    isSuccess = false;
                }
                finally

                {
                    conn.Close();
                }
            return isSuccess;
        }
    }
}