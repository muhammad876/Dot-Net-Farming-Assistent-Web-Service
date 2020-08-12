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
    public partial class CropModels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                DataTable dt = this.GetData();

                foreach (DataRow dr in dt.Rows) // search whole table
                {

                    dr["Image"] = dr["Image"].ToString().TrimEnd();

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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CropModel"))
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
    }
}