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
    public partial class CurrentlyComplained : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                DataTable dt = this.GetData();
                gv.DataSource = dt;
                gv.DataBind();
            }
        }

        private DataTable GetData()
        {
            string constr = "Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Complain"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            return dt;
                        }
                    }
                }
            }
        }

        protected void MyButtonClick(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            LinkButton btn = (LinkButton)sender;
            
           
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            int row = gvr.RowIndex;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True");
            try
            {

                SqlCommand cmd = new SqlCommand("Update Complain set status = @status where ID = @id", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", row+1);
                cmd.Parameters.AddWithValue("@status", "Read");
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("SupplierHome.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.Message);
                btn.Text = "Exception: " + ex.Message;
            }
        }
    }
}