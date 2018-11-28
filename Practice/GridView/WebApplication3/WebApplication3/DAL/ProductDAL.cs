using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.DAL
{
    public class ProductDAL
    {
        public string Name { get; set; }
        public static string ConnectionString { get; set; }
        public DataSet GetProducts()
        {
           string Query = "select Id,Name from Newproduct";
            SQLManager manager = new SQLManager();
          //  return manager.GetDataSet(Query);
        }
        /*public bool UpdateProduct(Product product)
        {
            bool isSuccess;

            List<ProcParameters> procParams = new List<ProcParameters>();

            procParams.Add(new ProcParameters("@ProductId", product.Id.ToString(), DbType.Int32, ParameterDirection.Input));

            procParams.Add(new ProcParameters("@Name", product.Name, DbType.String, ParameterDirection.Input));
            SQLManager manager = new SQLManager();
            isSuccess = manager.UpdateRecord("Products_CRUD", procParams);
            return isSuccess;

        }*/
    }
}