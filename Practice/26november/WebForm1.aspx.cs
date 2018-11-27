using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _26november.DAL;

namespace _26november
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!(User.IsInRole("Finance Manager")|| User.IsInRole("Admin"))) 

            {
                Response.Redirect("Unauthorisied.aspx");
            }
           
        }

    

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProductDAL product = new ProductDAL();
            product.Name = TextBox1.Text;
            if (!product.Addrecord())
            {
                Response.Write("Product name is not saved");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProductDAL product = new ProductDAL();
            product.Name = TextBox2.Text;
            if (!product.Deleterecord())
            {
                Response.Write("Product name is not saved");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ProductDAL product = new ProductDAL();
            product.Name = TextBox3.Text;
            product.Update_Name = TextBox4.Text;
            if (!product.Updaterecord())
            {
                Response.Write("Product name is not deleted");
            }
        }
    }
}