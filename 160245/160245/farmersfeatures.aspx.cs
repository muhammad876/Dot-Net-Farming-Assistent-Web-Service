using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class farmersfeatures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Advertisment(object sender, EventArgs e)
        {
            Response.Redirect("Advertisment.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Advertisment.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("farmerlogin.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("farmerlogin.aspx");
        }

        protected void Complain(object sender, EventArgs e)
        {
            Response.Redirect("complainform.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("complainform.aspx");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Model.aspx");
        }

        protected void CropModel(object sender, EventArgs e)
        {
            Response.Redirect("Model.aspx");
        }
    }
}