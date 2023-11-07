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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart.amazeQuantity = (int)Application["amaze"];
            Cart.appleQuantity = (int)Application["apple"];
            Cart.samsungQuantity = (int)Application["samsung"];

            amaze.Text = Cart.amazeQuantity.ToString();
            apple.Text = Cart.appleQuantity.ToString();
            samsung.Text = Cart.samsungQuantity.ToString();


            Cart.calAmazeSubtotal(70);
            Cart.calAppleSubtotal(800);
            Cart.calSamaungSubtotal(350);

            calGrandtotal();


        }

        protected void toProductPage_Click(object sender, EventArgs e)
        {
            Server.Transfer("Products.aspx");
        }
       

        protected void deleteAll_Click(object sender, EventArgs e)
        {
            
            Application["amaze"] = 0;
            Application["apple"] = 0;
            Application["samsung"] = 0;

            Cart.samsungsubtotal = 0;
            Cart.amazesubtotal = 0;
            Cart.applesubtotal = 0;

            Server.Transfer("Products.aspx");
            
        }

        protected void toCheckout_Click(object sender, EventArgs e)
        {
            Label8.Text = Cart.calGrandtotal();
        }




            protected void calGrandtotal()
        {
            Label8.Text = Cart.calGrandtotal();
            Label7.Text = Cart.displayCart();
            
        }

       

      

       

        protected void Button3_Click(object sender, EventArgs e)
        {
            Application["apple"] = 0;
            Cart.grandtotal = Cart.grandtotal - 800 * Cart.appleQuantity;
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "update cart set appleSubtotal = '" + Application["apple"] + "', appleQuantity= '" + Application["apple"] + "', grandtotal = '" + Cart.grandtotal + "' where userId='" + Application["userId"] + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception q)
            {
                Server.Transfer("CustomError1.aspx");
            }
            con.Close();
            //Cart.applesubtotal = 0;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["amaze"] = 0;
            Cart.grandtotal = Cart.grandtotal - 70 * Cart.amazeQuantity;
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "update cart set amazeSubtotal = '" + Application["amaze"] + "', amazeQuantity= '" + Application["amaze"] + "', grandtotal = '" + Cart.grandtotal + "' where userId='" + Application["userId"] + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception q)
            {
                Server.Transfer("CustomError1.aspx");
            }
            con.Close();
            //Cart.applesubtotal = 0;



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["samsung"] = 0;
            Cart.grandtotal = Cart.grandtotal - 350 * Cart.samsungQuantity;
            //Cart.samsungsubtotal = 0;


        }
    }
}