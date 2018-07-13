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
                .OrderBy(p=>p.Category.Brand.BrandId)
                .ThenBy(p=>p.Category.ProductCategoryId)
                .ThenBy(p=>p.ProductId)
                .ToList();
            return products;
        }

        public List<Product> GetActiveProducts()
        {
            var products = _Context.Products
                .Include(p => p.Category)
                .Include("Category.Brand")
                .Where(p=>p.Active == true)
                .OrderBy(p => p.Category.Brand.BrandId)
                .ThenBy(p => p.Category.ProductCategoryId)
                .ThenBy(p => p.ProductId)
                .ToList();
            return products;
        }

        public List<Product> GetActiveProductsbyBrand(int Brandid)
        {
            var products = _Context.Products
                .Include(p => p.Category)
                .Include("Category.Brand")
                .Where(p => p.Active == true && p.Category.Brand.BrandId == Brandid)
                .OrderBy(p => p.Category.Brand.BrandId)
                .ThenBy(p => p.Category.ProductCategoryId)
                .ThenBy(p => p.ProductId)
                .ToList();
            return products;
        }

        public Product GetLastProduct()
        {
            var product = _Context.Products
                .Include(p => p.Category)
                .Include("Category.Brand")
                .OrderByDescending(p => p.ProductId)
                .FirstOrDefault();
            return product;
        }

        public Product GetproductById(int id)
        {
            var product = _Context.Products
                .Include(p => p.Category)
                .Include("Category.Brand")
                .Where(p=>p.ProductId == id)
                .FirstOrDefault();
            return product;
        }

        public void CreateOrEditProduct(Product prod)
        {
            if (prod.ProductId == 0)
                _Context.Products.Add(prod);

            // if id is not 0, it means that we are editing a product, so only rest save the changes.
            var x = _Context.ChangeTracker.HasChanges();
            _Context.SaveChanges();
        }

        public Product GetProductBySKU(string SKU)
        {
            return _Context.Products.Where(p => p.SKU == SKU).Include(p => p.Category).FirstOrDefault();
        }
            
        #endregion

        #region orders
        public List<Order> GetOrders()
        {
            return _Context.Orders
                .Where(o=>o.OrderStatus != OrderState.Deleted)
                .Include(o => o.OrderDetails)
                .OrderByDescending(o=>o.OrderId)
                .ToList();
        }

        public void CreateOrder(Order order)
        {
            _Context.Orders.Add(order);
            _Context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _Context.Orders.Where(o => o.OrderId == id).FirstOrDefault();
            order.OrderStatus = OrderState.Deleted;
            _Context.SaveChanges();
        }

        public void ChangeOrderStatusToSent(int id)
        {
            var order = _Context.Orders.Where(o => o.OrderId == id).FirstOrDefault();
            order.OrderStatus = OrderState.Sent;
            _Context.SaveChanges();
        }
        #endregion

        #region brands
        public List<Brand> Getbrands()
        {
            var brands = _Context.Brands
                //.Where(b=>b.Active == true)
                .ToList();
            return brands;
        }

        public List<Brand> GetActivebrands()
        {
            var brands = _Context.Brands
                .Where(b=>b.Active == true)
                .ToList();
            return brands;
        }

        public void addBrand(Brand b)
        {
            _Context.Brands.Add(b);
            _Context.SaveChanges();
        }

        public void EditBrand(int id, string name, bool active)
        {
            var brand = _Context.Brands.Where(b => b.BrandId == id).FirstOrDefault();
            brand.Name = name;
            brand.Active = active;
            _Context.SaveChanges();
        }
        #endregion

        #region category

        public List<ProductCategory> GetCategoryByBrandId(int id)
        {
            var categories = _Context.ProductCategories
                .Where(c=>c.Brand.BrandId == id && c.active == true)
                .Include(c => c.Brand)
                .ToList();
            return categories;
        }

        public List<ProductCategory> GetCategoryById(int id)
        {
            var categories = _Context.ProductCategories
                .Where(c => c.ProductCategoryId == id)
                .Include(c => c.Brand)
                .ToList();
            return categories;
        }

        public void addCategory(ProductCategory pc)
        {
            _Context.ProductCategories.Add(pc);
            _Context.SaveChanges();
        }

        public void EditCategory(int id, string name, bool active)
        {
            var category = _Context.ProductCategories.Where(c => c.ProductCategoryId == id).FirstOrDefault();
            category.Name = name;
            category.active = active;
            _Context.SaveChanges();
        }

        #endregion

        #region suppliers

        public List<Supplier> GetSuppliers()
        {
            return _Context.Suppliers.ToList();
        }

        public List<Supplier> GetActiveSuppliers()
        {
            return _Context.Suppliers.Where(s=>s.Active == true).ToList();
        }

        public void createSupplier(Supplier supp)
        {
            _Context.Suppliers.Add(supp);
            _Context.SaveChanges();
        }

        public void EditSupplier(int id, string name, string email, bool active)
        {
            var supp = _Context.Suppliers.Where(s => s.SupplierId == id).FirstOrDefault();
            supp.Name = name;
            supp.Email = email;
            supp.Active = active;

            _Context.SaveChanges();
        }
        #endregion

        #region SupplierProduct

        public List<Product> GetProductsbySupplier(int supplierId)
        {
            return _Context.SupplierProducts.Where(sp => sp.Supplier.SupplierId == supplierId).Select(sp => sp.Product).ToList();
        }

        public void CreateSupplierProduct(int supplierId, int productId)
        {
            SupplierProduct sp = _Context.SupplierProducts
                .Where(s => s.Supplier.SupplierId == supplierId && s.Product.ProductId == productId).FirstOrDefault();

            if (sp == null)
            {
                var newsp = new SupplierProduct
                {
                    Product = _Context.Products.Where(p => p.ProductId == productId).FirstOrDefault(),
                    Supplier = _Context.Suppliers.Where(s => s.SupplierId == supplierId).FirstOrDefault()
                };
                _Context.SupplierProducts.Add(newsp);
                _Context.SaveChanges();
            }

            
        }

        public void DeleteSupplierProduct(int supplierId, int productId)
        {
            SupplierProduct sp = _Context.SupplierProducts
                .Where(s => s.Supplier.SupplierId == supplierId && s.Product.ProductId == productId).FirstOrDefault();

            _Context.SupplierProducts.Remove(sp);
            _Context.SaveChanges();
        }

        

        #endregion
    }


}
