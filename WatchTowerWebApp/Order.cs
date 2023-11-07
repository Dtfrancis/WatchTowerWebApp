using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchTowerWebApp
{
    public partial class Order
    {
        public int OrderID;
        public string ProductID;
        public string username;
        public double Subtotal;
        public int Quantity;
        public DateTime OrderDate;
        public Order() 
        {
           this.OrderID = 0;
            this.ProductID = "";
            this.username = "";
            this.Subtotal = 0;
            this.Quantity = 0;
            this.OrderDate = DateTime.Now;
        }

        public Order(DateTime a, int b, string c, string d, int e, double f)
        {
            this.OrderDate = a;
            this.OrderID = b;
            this.ProductID = c;
            this.username = d;
            this.Quantity = e;
            this.Subtotal = f;
        }


    }
}