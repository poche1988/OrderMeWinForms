using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace OrderMe.DAL
{
    public class Repository
    {
        //SINGLETON FOR SINGLE THREAD
        private readonly ApplicationDbContext _Context;

        private Repository()
        {
            _Context = new ApplicationDbContext();
            _Context.Configuration.ProxyCreationEnabled = false;
            _Context.Configuration.LazyLoadingEnabled = false;
        }

        private static Repository instance = null;

        public static Repository GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null)
            {
                instance = new Repository();
            }
            // Otherwise return the already existing instance
            return instance;
        }

        #region users

        public User GetUserByUsername(String username)
        {
            var user = new User();
            return _Context.Users.Where(u => u.Username == username).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _Context.Users.ToList();
        }

        #endregion

        #region products
        public List<Product> Getproducts()
        {
            var products = _Context.Products
                .Include(p=>p.Category)
                .Include("Category.Brand")
                //.OrderBy(p=>p.Category.ProductCategoryId)
                .ToList();
            return products;
        }
        #endregion

        #region orders
        public List<Order> GetOrders()
        {
            return _Context.Orders
                .Include(o => o.OrderDetails)
                .OrderByDescending(o=>o.Date)
                .ToList();
        }

        public void CreateOrder(Order order)
        {
            _Context.Orders.Add(order);
            _Context.SaveChanges();
        }
        #endregion

        

    }


}
