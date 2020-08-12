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
    public partial class complainform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True");
            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Complain VALUES (@farmerName,@description,@status);", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@farmerName", SqlDbType.NVarChar, 50).Value = name.Text;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar, 50).Value = complain.Text;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar, 6).Value = "Unread";
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

        protected void t3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}