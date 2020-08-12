using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _160245
{
    public partial class AddAdvertisment : System.Web.UI.Page
    {
        static string filename="";
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

                SqlCommand cmd = new SqlCommand("INSERT INTO Advertisment VALUES (@name,@quantity,@image);", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.NVarChar, 50).Value = quantity.Text;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar, 50).Value = filename;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("SupplierHome.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.Message);
            name.Text = "Exception: " + ex.Message;
            }

        }
    }
}