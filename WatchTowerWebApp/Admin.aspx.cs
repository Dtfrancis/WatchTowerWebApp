using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WatchTowerWebApp
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["AdminName"];
            Display();
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql2 = "select * from Order_";
            SqlCommand cmd = new SqlCommand(sql2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try {
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }catch(Exception n)
            {
                Server.Transfer("CustomError1.aspx");
            }
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string cmd = "INSERT INTO PRODUCT VALUES ('" + TextBox1.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')";
            SqlCommand cmd2 = new SqlCommand(cmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
                        
            try
            {
                da.Fill(dt);
                Label11.Text = "Product added";
                Display();
                TextBox1.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";

            }
            catch(Exception oh)
            {
                Response.Redirect("CustomError1.aspx");
            }
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string cmd = "update product  set productName = '"+ TextBox6.Text +"',category ='"+ TextBox7.Text + "',descript = '"+ TextBox8.Text + "', price = '"+ TextBox9.Text + "'  where productId = '"+ TextBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(cmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
           
            try
            {
                da.Fill(dt);
                Label11.Text = "Product updated";
                Display();
                TextBox1.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
            }
            catch (Exception oh)
            {
                Response.Redirect("CustomError1.aspx");
            }
            con.Close();
            /*
            SqlDataSource3.InsertParameters["productId"].DefaultValue = TextBox1.Text;
            SqlDataSource3.InsertParameters["productName"].DefaultValue = TextBox6.Text;
            SqlDataSource3.InsertParameters["category"].DefaultValue = TextBox7.Text;
            SqlDataSource3.InsertParameters["descript"].DefaultValue = TextBox8.Text;
            SqlDataSource3.InsertParameters["price"].DefaultValue = TextBox9.Text;
            try
            {
                SqlDataSource3.Update();
                TextBox1.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                Label11.Text = "Product updated";
                Display();
            }
            catch(Exception xe)
            {
                Response.Redirect("CustomError1");
            }*/

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            string cmd = "delete from product where productId ='"+TextBox1.Text+"'";
            SqlCommand cmd2 = new SqlCommand(cmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            con.Open();

            try
            {
                da.Fill(dt);
                Label11.Text = "Product deleted";
                Display();
                TextBox1.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
            }
            catch (Exception oh)
            {
                Response.Redirect("CustomError1.aspx");
            }
            con.Close();
            /*
            SqlDataSource2.InsertParameters["productId"].DefaultValue = TextBox1.Text;
            SqlDataSource2.InsertParameters["productName"].DefaultValue = TextBox6.Text;
            SqlDataSource2.InsertParameters["category"].DefaultValue = TextBox7.Text;
            SqlDataSource2.InsertParameters["descript"].DefaultValue = TextBox8.Text;
            SqlDataSource2.InsertParameters["price"].DefaultValue = TextBox9.Text;
            try
            {
                SqlDataSource2.Delete();
                TextBox1.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                Label11.Text = "Product deleted";
                Display();
            }catch(Exception ye)
            {
                Response.Redirect("CustomError1");
            }*/
        }
        protected void Display()
        {
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql2 = "select * from product";
            SqlCommand cmd = new SqlCommand(sql2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            catch (Exception se)
            {
                Response.Redirect("CustomError1");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Application["userId"] = 0;
            Session["AdminName"] = "";
            Server.Transfer("Default.aspx");
        }
    }
}