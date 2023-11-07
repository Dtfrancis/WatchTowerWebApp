using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WatchTowerWebApp
{
    public partial class userHome : System.Web.UI.Page
    {
        public partial class _Default : Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {

            }


        }

        protected void toApplePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProducts.aspx");
        }

        protected void ToAmazePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProducts.aspx");

        }

        protected void ToSamsungPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProducts.aspx");

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("userProducts.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userAbout.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("userContact.aspx");

        }
    }
}