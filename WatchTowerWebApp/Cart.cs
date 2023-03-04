using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;

namespace WatchTowerWebApp
{
    public class Cart
    {
        static public double total;
        static public List<Watch> cartList = new List<Watch>();
        


        public static void addToTotal(double c)
        {
            //double a = 0;            
            total = total + c;
            
        }

        public static void reset()
        {
            total = 0;
            cartList.Clear();
        }

        public static void getCart()
        {
            //for (int i = 0; i <= cartList.IndexOf(""); i++) ;

        }





    }
}