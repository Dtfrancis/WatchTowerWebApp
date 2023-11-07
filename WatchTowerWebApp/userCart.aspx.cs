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
    public partial class cartUser : System.Web.UI.Page
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
            Server.Transfer("userProducts.aspx");
        }


        protected void deleteAll_Click()
        {

           

        }

        protected void toCheckout_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Application["orderId"] = (int)Application["orderId"] + 1;
            order.OrderID = (int)Application["orderId"];
            foreach(Watch item in Cart.cartObjList)
            {
                order.ProductID = item.id;
                order.Quantity = item.quantity;
                order.username = (string)Session["Username"];
                order.Subtotal =  Cart.grandtotal;
                order.OrderDate = DateTime.Now;

                string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string sql = "insert into order_ values ('" + order.ProductID + "','" + order.Quantity + "', '" + order.username + "', '" + order.Subtotal + "', '" + order.OrderDate + "' ";//select cast (getdate() as Date) as Order_date, p.ProductId, c.grandtotal, User_.username from Product as p Inner join cart as c on p.ProductId = c.ProductId inner join  User_ on User_.userId = c.userId 

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception q)
                {
                    Server.Transfer("CustomError2.aspx");
                }

            }
            //deleteAll_Click();
           // order.ProductID = Cart.cartObjList.[0];

           /*
            if (dt.Rows.Count > 0)
            {
                string sql2 = "select User_.username from User_ inner join cart on User_.userId = cart.userId";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                try
                {
                    da2.Fill(dt2);
                }
                catch (Exception q)
                {
                    Server.Transfer("CustomError2.aspx");
                }
            }
            Response.Redirect("Order.aspx");

            order.Quantity = Cart.amazeQuantity + Cart.appleQuantity + Cart.samsungQuantity;
            order.Subtotal = Convert.ToInt32(Label8.Text);
           */
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
            string sql ="update cart set appleSubtotal = '" + Application["apple"] + "', appleQuantity= '" + Application["apple"] + "', grandtotal = '" + Cart.grandtotal + "' where userId='" + Application["userId"] + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception q)
            {
                Server.Transfer("CustomError2.aspx");
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
            string sql = "update cart set amazeSubtotal = '" + Application["amaze"] + "', amazeQuantity= '" +Application["amaze"] + "', grandtotal = '" + Cart.grandtotal + "' where userId='" + Application["userId"] + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception q)
            {
                Server.Transfer("CustomError2.aspx");
            }
            con.Close();
            // Cart.applesubtotal = 0;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["samsung"] = 0;
            Cart.grandtotal = Cart.grandtotal - 350 * Cart.samsungQuantity;
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "update cart set samsungSubtotal = '" + Application["samsung"] + "', samsungQuantity= '" + Application["samsung"] + "', grandtotal = '" + Cart.grandtotal + "' where userId='" + Application["userId"] + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }catch(Exception q)
            {
                Server.Transfer("CustomError2.aspx");
                //g.printStackTrace();
            }
           
            con.Close();
            //Cart.samsungsubtotal = 0;


        }

        protected void deleteAll_Click(object sender, EventArgs e)
        {
            Application["amaze"] = 0;
            Application["apple"] = 0;
            Application["samsung"] = 0;

            Cart.samsungsubtotal = 0;
            Cart.amazesubtotal = 0;
            Cart.applesubtotal = 0;

            Server.Transfer("userProducts.aspx");
        }
    }
}
