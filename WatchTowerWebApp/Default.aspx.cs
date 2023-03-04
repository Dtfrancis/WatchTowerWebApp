using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WatchTowerWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        protected void toApplePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void ToAmazePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void ToSamsungPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}