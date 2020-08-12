using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class adminfeatures : System.Web.UI.Page
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
            Response.Redirect("adminlogin.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void Complain(object sender, EventArgs e)
        {
            Response.Redirect("CurrentlyComplained.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CurrentlyComplained.aspx");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CropModels.aspx");
        }

        protected void CropModel(object sender, EventArgs e)
        {
            Response.Redirect("CropModels.aspx");
        }
    }
}