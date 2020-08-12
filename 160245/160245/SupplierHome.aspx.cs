using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class SupplierHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AddAdvertisment.aspx");
        }

        protected void Advertisment(object sender, EventArgs e)
        {
            Response.Redirect("AddAdvertisment.aspx");
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CropModels.aspx");
        }

        protected void Models(object sender, EventArgs e)
        {
            Response.Redirect("CropModels.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SupplierLogin.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("SupplierLogin.aspx");
        }

      
    }
}