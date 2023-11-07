using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchTowerWebApp
{
    public class WTEntityFunctions
    {
        public List<Order> GetOrders()
        {
            WatchTowerRepo wte = new WatchTowerRepo();
            return wte.Order.Include("Order").ToList();
        }
    }
}