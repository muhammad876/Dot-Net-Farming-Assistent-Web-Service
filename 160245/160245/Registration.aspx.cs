using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class RegisterAdmin : System.Web.UI.Page
    {

     
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True");
            try
            {
             
                SqlCommand cmd = new SqlCommand("INSERT INTO registration (name,password,email) VALUES (@Name,@Password,@Email);",con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = t1.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = TextBox1.Text;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = TextBox3.Text;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
               Response.Redirect("FrontPage.aspx");
            }
            catch (Exception ex)
            {
            
                Console.WriteLine("Exception: " + ex.Message);
                t1.Text = "Exception: " + ex.Message;
            }
          
           
        }
    }
}