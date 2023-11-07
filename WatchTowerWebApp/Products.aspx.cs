using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;

namespace WatchTowerWebApp
{
    public partial class Products : System.Web.UI.Page
    {

        Cart cart;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Watch> pList = new List<Watch>();            

            Watch apple1 = new Watch("Wt02", "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task",  70,0);
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
            samsung1.quantity= 0;

           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = (int)Application["amaze"];
            i++;
            Application["amaze"] = i;
            Cart.amazeQuantity = i;
            Cart.cartList.Add(70);

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
            x++;
            Application["apple"] = x;
            Cart.appleQuantity = x;
            Cart.cartList.Add(800);

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
            k++;
            Application["samsung"] = k;
            Cart.samsungQuantity = k;
            Cart.cartList.Add(350);

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


            Server.Transfer("Cart.aspx");
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
    }
}