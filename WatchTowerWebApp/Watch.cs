using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WatchTowerWebApp
{
    public class Watch
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public double unitPrice { get; set; }
        public Image image { get; set; }
        public int quantity { get; set; }

        

        public Watch (string a, string b, string c, string d, double e, int f)
            {
            this.id = a;
            this.name = b;
            this.description = c;
            this.category = d;
            this.unitPrice = e;
            this.quantity = f;
            }

        public Watch(string a, string b, string c, string d, double e, int f, Image g)
        {
            this.id = a;
            this.name = b;
            this.description = c;
            this.category = d;
            this.unitPrice = e;
            this.quantity = f;
            this.image = g;
        }


        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice (double a)
        {
            a = unitPrice;
        }

    }

}