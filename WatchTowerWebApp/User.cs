using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchTowerWebApp
{
    public  class User
    {
       
        public int userId { get; set; }
        public  string fname { get; set; }
        public  string lname { get; set; }
        public string email { get; set; }
        public  int age { get; set; }
        public  string username { get; set; }
        private  string password { get; set; }
        public  string type { get; set; }

        public Cart cart { get; set; }
        public Order order { get; set; }


        public User()
        {
            cart = new Cart();
            fname = "";
            lname = "";
            email = "";
            age = 0;
            username = "";
            password = "";
            type = "";            
            
        }

        public User ( int UserId, Cart userCart, string firstname, string lastname, string userEmail, int userAge, string userName, string userPassword, string userType)
        {
            userId = UserId;
            cart = userCart;
            fname = firstname;
            lname = lastname;
            email = userEmail;
            age = userAge;
            username = userName;
            password = userPassword;
            type = userType;
        }
       

       

    }
}