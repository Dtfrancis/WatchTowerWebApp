using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WatchTowerWebApp
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url = ConfigurationManager.AppSettings["SecurePath"] + "Login.aspx";
                Response.Redirect(url);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql2 = "select Count(*) from User_ where username='" + TextBox1.Text + "' and userPassword='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Close();
            if (dt.Rows.Count == 1)
            {
                string sql1 = "select type_ from User_ where userEmail ='" + TextBox1.Text + "' and userPassword='" + TextBox2.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sql1, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                //con.Close();
                if (dt2.Rows.Count == 1)
                {
                    if (dt2.Rows[0][0].ToString() == "admin")
                    {
                        string sql3 = "select username from User_ where userEmail ='" + TextBox1.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                        DataTable dt3 = new DataTable();
                        da3.Fill(dt3);
                        con.Close();
                        Session["AdminName"] = dt3.Rows[0][0];
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        
                        string sql3 = "select username from User_ where userEmail ='" + TextBox1.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                        DataTable dt3 = new DataTable();
                        da3.Fill(dt3);
                        string sql4 = "select userId from User_ where userEmail ='" + TextBox1.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                        DataTable dt4 = new DataTable();
                        da4.Fill(dt4);
                        Application["userId"] = dt4.Rows[0][0];
                       insertIntoCart();                        
                        Session["Username"] = dt3.Rows[0][0];
                        con.Close();
                        Response.Redirect("userCart.aspx");
                    }

                }
                else
                {
                    Label1.Text = "Wrong email or password";
                }
            }
            else
            {
                Label1.Text = "Wrong email or password";
            }

            
        }
        protected void insertIntoCart()
        {


            SqlDataSource1.InsertParameters["userId"].DefaultValue = Application["userId"].ToString();           
            SqlDataSource1.InsertParameters["grandtotal"].DefaultValue = Cart.grandtotal.ToString();
            SqlDataSource1.InsertParameters["amazeQuant"].DefaultValue = Cart.amazeQuantity.ToString();
            SqlDataSource1.InsertParameters["appleQuant"].DefaultValue = Cart.appleQuantity.ToString();
            SqlDataSource1.InsertParameters["samsungQuant"].DefaultValue = Cart.samsungQuantity.ToString();
            SqlDataSource1.InsertParameters["amazeSub"].DefaultValue = Cart.amazesubtotal.ToString();
            SqlDataSource1.InsertParameters["appleSub"].DefaultValue = Cart.applesubtotal.ToString();
            SqlDataSource1.InsertParameters["samsungSub"].DefaultValue = Cart.samsungsubtotal.ToString();

            try { SqlDataSource1.Insert(); } catch(Exception e) { Response.Redirect("CustomError1"); }
            
            
        }
    }
}