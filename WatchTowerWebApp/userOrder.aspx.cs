using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WatchTowerWebApp
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql2 = "select order_.orderDate, order_.orderId, order_.productId, order_.username, order_.quantity, order_.subtotal from Order_ inner join cart on order_.productId = cart.productId "; //where userId = '" + Application["userId"]+ "'
            SqlCommand cmd = new SqlCommand(sql2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception n)
            {
                Server.Transfer("CustomError2.aspx");
            }
        }
    }
}