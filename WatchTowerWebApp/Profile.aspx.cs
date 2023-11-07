using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WatchTowerWebApp
{
    public partial class UserCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url = ConfigurationManager.AppSettings["SecurePath"] + "Profile.aspx";
                Response.Redirect(url);
            }

            Label1.Text = "Welcome " + Session["Username"].ToString();

            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "Select * from cart where userId='" + (int)Application["userId"]+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            try
            {
                Label1.Text = Session["Username"].ToString();
               GridView1.DataSource = dt;
                GridView1.DataBind();
            }catch(Exception l)
            {
                Response.Redirect("CustomError1.aspx");
            }
            con.Close();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Application["userId"] = 0;
            Session["currentUser"] = "";
            Server.Transfer("Default.aspx");
        }
    }
}