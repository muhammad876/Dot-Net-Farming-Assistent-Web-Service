using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
namespace _160245
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
               
                DataTable dt = this.GetData();
           
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    
                        dr["image"] = dr["image"].ToString().TrimEnd();
                  
                }
               
                    gv.DataSource = dt;
                   gv.DataBind();
            }
        }

        private DataTable GetData()
        {
            string constr = "Data Source=DESKTOP-UPJK2PQ;Initial Catalog=Farming;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, name, quantity,image FROM Advertisment"))
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}