using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class FrontPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SupplierLogin.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("farmerlogin.aspx");
        }

        protected void Admin(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        protected void Farmer(object sender, EventArgs e)
        {
            Response.Redirect("farmerlogin.aspx");
        }
        protected void Supplier(object sender, EventArgs e)
        {
            Response.Redirect("SupplierLogin.aspx");
        }
    }
}