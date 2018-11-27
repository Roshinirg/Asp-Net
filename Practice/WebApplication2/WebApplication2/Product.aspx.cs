using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.ProductDAL;

namespace WebApplication2
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            ProdDAL product = new ProdDAL();
            TextBox1.Text = product.Name;
            product.Selectrecord();
        }
    }
}