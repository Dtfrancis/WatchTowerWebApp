using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Services.Description;
using System.Text;

namespace WatchTowerWebApp
{
    public class Cart
    {
        static public int cartId;
        static public string productId = "";
        static public double total;
        
        static public int amazeQuantity ;

        static public int appleQuantity;

        static public int samsungQuantity;

        static public double amazesubtotal;

        static public double applesubtotal;

        static public double samsungsubtotal;

        static public double grandtotal;
        

        static public List<double> cartList = new List<double>();
        static public List<Watch> cartObjList = new List<Watch>();// list of products



        public Cart ()
        {
            
            total = 0;
            amazeQuantity = 0;
            appleQuantity = 0;
            samsungQuantity = 0;
            amazesubtotal = 0;
            applesubtotal = 0;
            samsungsubtotal = 0;
            grandtotal = 0;
            productId = "";
            
            
        }
        public Cart( string Id, int Total, int AmazeQuantity, int AppleQuantity, int SamsungQuantity, int Amazesubtotal, int Applesubtotal, int Samsungsubtotal, int Grandtotal, string ProductId)
        {
            productId = Id;
            total = Total;
            amazeQuantity = AmazeQuantity;
            appleQuantity = AppleQuantity;
            samsungQuantity = SamsungQuantity;
            amazesubtotal = Amazesubtotal;
            applesubtotal = Applesubtotal;
            samsungsubtotal = Samsungsubtotal;
            grandtotal = Grandtotal;
            productId = ProductId;
        }
        public Cart (string Id, int CartId, int Total, int AmazeQuantity, int AppleQuantity, int SamsungQuantity, int Amazesubtotal, int Applesubtotal, int Samsungsubtotal, int Grandtotal, string ProductId)
        {
            productId = Id;
            cartId = CartId;
            total = Total;
            amazeQuantity = AmazeQuantity;
            appleQuantity = AppleQuantity;
            samsungQuantity = SamsungQuantity;
            amazesubtotal = Amazesubtotal;
            applesubtotal = Applesubtotal;
            samsungsubtotal = Samsungsubtotal;
            grandtotal = Grandtotal;
            productId = ProductId;
        }
        public static string calAmazeSubtotal(double price)
        {
            string message = string.Empty;
            amazesubtotal = amazeQuantity * price;
            message = amazesubtotal.ToString();
            //Application["amaze"] = 0;
            return message;
        }
        public static string calAppleSubtotal(double price)
        {
            string message = string.Empty;
            applesubtotal = appleQuantity * price;
            message = applesubtotal.ToString();
            //Application["apple"].DefaultValue = 0;
            return message;
        }

        public static string calSamaungSubtotal(double price)
        {
            string message = string.Empty;
            samsungsubtotal = samsungQuantity * price;
            message = samsungsubtotal.ToString();
           
            
            //Application["samsung"] = 0;
            return message;
        }

        public static string calGrandtotal()
        {
            string message = string.Empty;
            grandtotal = amazesubtotal + applesubtotal + samsungsubtotal;
            message = grandtotal.ToString();
            return message;
        }

        public  void reset()
        {
            
        }

        public static string displayCart()
        {
            string message = "Amaze Subtotal : " + Cart.amazesubtotal.ToString() + " " + " Apple Subtotal : " + Cart.applesubtotal.ToString() + " " + " Samsung Subtotal : " + Cart.samsungsubtotal.ToString();
            return message;
        }

        public static Watch addWatch (Watch a)
        {
            cartObjList.Add(a);
            return a;
        }




    }
}