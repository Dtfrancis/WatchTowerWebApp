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
       // List<String> pList = new List<String>();
       // List<String> cartList = new List<String>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Watch> pList = new List<Watch>();            

            Watch apple1 = new Watch(001, "Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task",  70,0);
            cat1_lb.Text = apple1.category;
            name1_lb.Text = apple1.name;
            info1_lb.Text = apple1.description;
            price1_lb.Text = apple1.unitPrice.ToString();
            apple1.quantity = 0;

            Watch amaz1 = new Watch(002, " Apple watch ", "Series 8 Ultra", "Apple's latest smart watch", 800, 0);
            cat2_lb.Text = amaz1.category;
            name2_lb.Text = amaz1.name;
            info2_lb.Text = amaz1.description;
            price2_lb.Text = amaz1.unitPrice.ToString();
            amaz1.quantity = 0;

            Watch samsung1 = new Watch(003, "Samsung Watch ", "Galaxy Watch 5", "Latest Samsung watch", 350, 0);
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
            Watch amaze1 = new Watch(001,"Amazfit Watch ", "AmazeFit BIP S ", "fit to aid in your day to day task", 70.00,0);           
            Cart.addToTotal(70);
            int quantityTotal = amaze1.quantity++;
            Cart.cartList.Add(amaze1);
            



        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Watch apple1 = new Watch(002," Apple watch ", "Series 8 Ultra", "Apple's latest smart watch", 800.00,0);
            Cart.cartList.Add(apple1);
            Cart.addToTotal(800);
            int quantityTotal = apple1.quantity++;
            
            
            /*
            */
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Watch samsung1 = new Watch(003,"Samsung Watch ", "Galaxy Watch 5", "Latest Samsung watch", 350.00, 0);
            Cart.addToTotal(350);
            int quantityTotal = samsung1.quantity++;
            Cart.cartList.Add(samsung1);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
              
            string a = Cart.total.ToString();
            Session["grandTotal"] = a;

           

            /*  
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