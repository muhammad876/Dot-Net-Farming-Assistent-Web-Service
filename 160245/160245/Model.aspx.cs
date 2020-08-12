using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class Model : System.Web.UI.Page
    {
        static string filename = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                filename = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                Image1.ImageUrl = filename;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True");
            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO CropModel VALUES (@Name,@Price,@Quantity,@Image);", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name.Text;
                cmd.Parameters.Add("@Price", SqlDbType.NVarChar, 50).Value = price.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50).Value = quantity.Text;
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar, 50).Value = filename;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("farmersfeatures.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.Message);
                name.Text = "Exception: " + ex.Message;
            }

        }
    }
}