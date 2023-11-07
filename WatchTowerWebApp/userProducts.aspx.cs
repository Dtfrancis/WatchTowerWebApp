using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WatchTowerWebApp
{
    public partial class userProducts : System.Web.UI.Page
    {
        Cart cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Watch> pList = new List<Watch>();

            Watch apple1 = new Watch("Wt02", "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task", 70, 0);
            cat1_lb.Text = apple1.category;
            name1_lb.Text = apple1.name;
            info1_lb.Text = apple1.description;
            price1_lb.Text = apple1.unitPrice.ToString();
            apple1.quantity = 0;

            Watch amaz1 = new Watch("Wt01", " Apple watch ", "Series 8 Ultra", "Apple's latest smart watch", 800, 0);
            cat2_lb.Text = amaz1.category;
            name2_lb.Text = amaz1.name;
            info2_lb.Text = amaz1.description;
            price2_lb.Text = amaz1.unitPrice.ToString();
            amaz1.quantity = 0;

            Watch samsung1 = new Watch("Wt03", "Samsung Watch ", "Galaxy Watch 5", "Latest Samsung watch", 350, 0);
            cat3_lb.Text = samsung1.category;
            name3_lb.Text = samsung1.name;
            info3_lb.Text = samsung1.description;
            price3_lb.Text = samsung1.unitPrice.ToString();
            samsung1.quantity = 0;


        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = (int)Application["amaze"];
            int subtotal= 70;
            //int grandtotal = subtotal * 
            i++;
            Application["amaze"] = i;
            Cart.amazeQuantity = i;
            Cart.amazesubtotal = subtotal * i;
            Cart.grandtotal = Cart.amazesubtotal + Cart.applesubtotal + Cart.samsungsubtotal;
            Cart.cartList.Add(70);

            Watch amaze1 = new Watch("Wt01", "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task", 70, 0);
            cat1_lb.Text = amaze1.category;
            name1_lb.Text = amaze1.name;
            info1_lb.Text = amaze1.description;
            price1_lb.Text = amaze1.unitPrice.ToString();
            amaze1.quantity = (int)Application["amaze"];
            Cart.addWatch(amaze1);

            SqlDataSource1.InsertParameters["userId"].DefaultValue = Application["userId"].ToString();
            SqlDataSource1.InsertParameters["grandtotal"].DefaultValue = Cart.grandtotal.ToString();
            SqlDataSource1.InsertParameters["amazeQuant"].DefaultValue = Cart.amazeQuantity.ToString();
            SqlDataSource1.InsertParameters["amazeSub"].DefaultValue = Cart.amazesubtotal.ToString();
            try
            {
                SqlDataSource1.Insert();
            }
            catch (Exception tx)
            {
                Response.Redirect("CustomError1.aspx");
            }
            //            insertIntoCart();
            /*
            Watch amaze1 = new Watch(001, "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task", 70.00, 0);
            int a = (int)Session["p1Quantity"];
            if (a <= 0)
            {
                Cart.addToTotal(70);
                Session["p1Quantity"] = amaze1.quantity++;
                a++;
                Cart.cartList.Add(amaze1);
            }
            else
            {
                amaze1.quantity++;
                Session["p1Quantity"] = amaze1.quantity++;
                a++;
            }
            */




        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = (int)Application["apple"];
            int subtotal = 800;
            x++;
            Application["apple"] = x;
            Cart.appleQuantity = x;
            Cart.applesubtotal = subtotal * x;
            Cart.grandtotal = Cart.amazesubtotal + Cart.applesubtotal + Cart.samsungsubtotal;
            Cart.cartList.Add(800);

            Watch apple1 = new Watch("Wt02", "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task", 70, 0);
            cat1_lb.Text = apple1.category;
            name1_lb.Text = apple1.name;
            info1_lb.Text = apple1.description;
            price1_lb.Text = apple1.unitPrice.ToString();
            apple1.quantity = 0;
            Cart.addWatch(apple1);
            SqlDataSource2.InsertParameters["userId"].DefaultValue = Application["userId"].ToString();
            SqlDataSource2.InsertParameters["grandtotal"].DefaultValue = Cart.grandtotal.ToString();
            SqlDataSource2.InsertParameters["appleQuant"].DefaultValue = Cart.appleQuantity.ToString();
            SqlDataSource2.InsertParameters["appleSub"].DefaultValue = Cart.applesubtotal.ToString();
            try
            {
                SqlDataSource2.Insert();
            }
            catch (Exception px)
            {
                Response.Redirect("CustomError1.aspx");
            }
            //insertIntoCart();

            

            /*
            Watch apple1 = new Watch(002," Apple watch ", "Series 8 Ultra", "Apple's latest smart watch", 800.00,0);
            Cart.cartList.Add(apple1);
            Cart.addToTotal(800);
            int quantityTotal = apple1.quantity++;
            
            
            
            */
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int k = (int)Application["samsung"];
            int subtotal = 800;
            k++;
            Application["samsung"] = k;
            Cart.samsungQuantity = k;
            Cart.samsungsubtotal = subtotal * k;
            Cart.grandtotal = Cart.amazesubtotal + Cart.applesubtotal + Cart.samsungsubtotal;
            Cart.cartList.Add(350);


            Watch samsung1 = new Watch("Wt03", "Samsung Watch ", "Galaxy Watch 5", "Latest Samsung watch", 350, 0);
            cat3_lb.Text = samsung1.category;
            name3_lb.Text = samsung1.name;
            info3_lb.Text = samsung1.description;
            price3_lb.Text = samsung1.unitPrice.ToString();
            samsung1.quantity = 0;
            Cart.addWatch(samsung1);

            SqlDataSource3.InsertParameters["userId"].DefaultValue = Application["userId"].ToString();
            SqlDataSource3.InsertParameters["grandtotal"].DefaultValue = Cart.grandtotal.ToString();
            SqlDataSource3.InsertParameters["samsungQuant"].DefaultValue = Cart.samsungQuantity.ToString();
            SqlDataSource3.InsertParameters["samsungeSub"].DefaultValue = Cart.samsungsubtotal.ToString();
            try
            {
                SqlDataSource3.Insert();
            }
            catch (Exception px)
            {
                Response.Redirect("CustomError1.aspx");
            }
            //insertIntoCart();
            /*
            Watch samsung1 = new Watch(003,"Samsung Watch ", "Galaxy Watch 5", "Latest Samsung watch", 350.00, 0);
            Cart.addToTotal(350);
            int quantityTotal = samsung1.quantity++;
            Cart.cartList.Add(samsung1);
         */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {





            /*  
            string a = Cart.total.ToString();
            Session["grandTotal"] = a;
             */


            Server.Transfer("userCart.aspx");
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedItem.Text == "Alpine orange")
            {
                Image5.ImageUrl = "~/Assets/apple.jfif";
            }
            if (RadioButtonList2.SelectedItem.Text == "Ocean White")
            {
                Image5.ImageUrl = "~/Assets/Amaze fit.jfif";
            }
        }

        protected void insertIntoCart()
        {

            SqlDataSource1.InsertParameters["userId"].DefaultValue = (string)Session["currentUser"];
            SqlDataSource1.InsertParameters["grandtotal"].DefaultValue = Cart.grandtotal.ToString();
            SqlDataSource1.InsertParameters["amazeQuant"].DefaultValue = Cart.amazeQuantity.ToString();
            SqlDataSource1.InsertParameters["appleQuant"].DefaultValue = Cart.appleQuantity.ToString();
            SqlDataSource1.InsertParameters["samsungQuant"].DefaultValue = Cart.samsungQuantity.ToString();
            SqlDataSource1.InsertParameters["amazeSub"].DefaultValue = Cart.amazesubtotal.ToString();
            SqlDataSource1.InsertParameters["appleSub"].DefaultValue = Cart.applesubtotal.ToString();
            SqlDataSource1.InsertParameters["samsungSub"].DefaultValue = Cart.samsungsubtotal.ToString();

            try
            {
                SqlDataSource1.Insert();
            }catch(Exception ex) 
            {
                Response.Redirect("CustomError1.aspx");
            }

            /*
            string uId = (string)Session["currentUser"];
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "insert into cart (cartId, grandtotal, amazeQuantity,appleQuantity,samsungQuantity,amazeSubtotal, appleSubtotal,samsungSubtotal values('" + uId + "', '" + Cart.cartId + "', '" + Cart.grandtotal + "','" + Cart.amazeQuantity + "','" + Cart.appleQuantity + "', '" + Cart.samsungQuantity + "','" + Cart.amazesubtotal + "','" + Cart.applesubtotal + "', '" + Cart.samsungsubtotal + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();   
            */
        }
    }
}
   