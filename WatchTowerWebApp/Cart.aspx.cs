using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WatchTowerWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindList();
            //Gridview1.DataSource = Cart.cartList;
            //Cart.loadCart()
            //string total = string.Empty;
            //Application["grandTotal"] = total;

            //TextBox1.Text = total;
            //Label1.Text = (String)Session["p1"];
            //Label2.Text = (string)Session["cart"];
            /*
            
            Label3.Text = (string)Session["p1quan"];

            Label4.Text = (string)Session["p2name"];
            Label5.Text = (string)Session["p2price"];
            Label6.Text = (string)Session["p2quan"];

            Label7.Text = (string)Session["p3name"];
            Label8.Text = (string)Session["p3price"];
            Label9.Text = (string)Session["p3quan"];
            */

        }

        protected void toProductPage_Click(object sender, EventArgs e)
        {
            Server.Transfer("Products.aspx");
        }
       

        protected void deleteAll_Click(object sender, EventArgs e)
        {
            if (Cart.cartList.Count == 0)
            {
                Response.Redirect("CustomError1.aspx");
            }
            else
            {
                Session["p1"] = "";
                Session["p1name"] = "";
                Session["p2name"] = "";
                Session["p3name"] = "";
                Session["p1price"] = "";
                Session["p2price"] = "";
                Session["p3price"] = "";
                Application["quantity1"] = 0;
                Application["quantity2"] = 0;
                Application["quantity3"] = 0;

                Cart.reset();

                Server.Transfer("Products.aspx");
            }
        }

        protected void toCheckout_Click(object sender, EventArgs e)
        {
            if (Cart.total == 0)
            {
                Response.Redirect("CustomError1.aspx");
            }
            else
            {
                Label13.Text = "Your grand total is " + Session["grandTotal"];
                //Cart.reset();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       protected void bindList()
        {
            GridView1.DataSource = Cart.cartList;
            GridView1.DataBind();
        }
    }
}