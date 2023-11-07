using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using Microsoft.AspNet;
using Microsoft.AspNet.Identity.EntityFramework;


namespace WatchTowerWebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            //var manager = Context.GetOwinContext().GetUserManager.ApplicationUserManager> ();


            int i;
            i = (int)Application["userId"];
            string a = username.Text;
            string b = userEmail.Text;
            string c = password.Text;
            string d = userFname.Text;
            string g = userLastname.Text;
            string f =  userage.Text;


            ///need to fix this part about Id
            SqlDataSource1.InsertParameters["userId"].DefaultValue = Application["userId"].ToString(); 
            SqlDataSource1.InsertParameters["username"].DefaultValue = a;
            SqlDataSource1.InsertParameters["email"].DefaultValue = b;
            SqlDataSource1.InsertParameters["userPassword"].DefaultValue =c;
            SqlDataSource1.InsertParameters["firstname"].DefaultValue = d;
            SqlDataSource1.InsertParameters["lastname"].DefaultValue = g;
            SqlDataSource1.InsertParameters["age"].DefaultValue = f;
            SqlDataSource1.InsertParameters["type"].DefaultValue = "user";
            i++;
            Application["userId"] = i;

            try
            {
                SqlDataSource1.Insert();
                UserCreated.Text = "User created";
                username.Text = "";
                userEmail.Text = ""; 
                password.Text = "";
                confirmEmail.Text = "";
                userFname.Text = "";
                userLastname.Text = "";
                userage.Text = "";
            }
            catch (Exception ex)
            {
                //Response.Redirect("CustomError1.aspx");
            }

            //var manager = Context.getOwin
            /*
            string cs = "Data Source=DESKTOP-1RV8FU9\\SQLEXPRESS;Initial Catalog=WatchTower;Integrated Security=True";
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql2 = "select Count(*) from User_ where userEmail='" + userEmail.Text + "' and userPassword='" + password.Text + "'";
            SqlCommand cmd = new SqlCommand(sql2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Close();
            if (dt.Rows.Count == 0)
            {
                Label8.Text = "User already exists!";
            }
            else 
            {
               
            }
                con.Close();       
            */

        }
    }
}