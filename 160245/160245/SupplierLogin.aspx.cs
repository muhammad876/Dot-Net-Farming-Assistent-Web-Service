using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _160245
{
    public partial class SupplierLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from registration", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {

                    //  int i = 0;
                    while (reader.Read())
                    {
                        string email = reader.GetString(1);
                        string password = reader.GetString(2);
                        string a = T1.Text;
                        string b = T3.Text;
                        if (a.Equals(email))
                        {
                            if (b.Equals(password))
                            {
                                Response.Redirect("SupplierHome.aspx");
                            }
                            else
                            {
                                password1.Text = "Wrong password";
                            }

                        }
                        else
                        {
                            name.Text = " Email Not Exist";
                        }
                    }
                    reader.NextResult();
                }
            }
            catch (Exception ex)
            {
                T1.Text = ex + "";
                Console.WriteLine(ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}