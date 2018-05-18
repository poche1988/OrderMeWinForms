using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMe.Services
{
    public static class CSVCreator
    {
        public static bool OrdersBackupCreator(List<Order> _orders, string filenameSubstring)
        {
            string path = pathCreator(filenameSubstring);

            if (!File.Exists(path))
            {

                using (TextWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("ORDERS");
                    sw.WriteLine("Order Id, Company, Contact, Date");
                    foreach (Order or in _orders)
                    {
                        List<String> lineItems = new List<String>();
                        lineItems.Add(or.OrderId.ToString());
                        lineItems.Add(or.Company);
                        lineItems.Add(or.Contact);
                        lineItems.Add(or.Date.ToString("dd-MM-yyyy"));

                        sw.WriteLine(String.Join(",", lineItems.ToArray()));
                    }
                    sw.WriteLine("");
                    sw.WriteLine("ORDERS DETAILS");
                    sw.WriteLine("OrderDetail Id, Order Id, Brand, Product, Size, SKU, Quantity");
                    foreach (Order or in _orders)
                    {
                        foreach (OrderDetail od in or.OrderDetails)
                        {
                            List<String> lineItems = new List<String>();
                            lineItems.Add(od.OrderDetailId.ToString());
                            lineItems.Add(od.Order.OrderId.ToString());
                            lineItems.Add(od.Product.Category.Brand.Name);
                            lineItems.Add(od.Product.Category.Name);
                            lineItems.Add(od.Product.ProductName);
                            lineItems.Add(od.Product.SKU);
                            lineItems.Add(od.Quantity.ToString());
                            sw.WriteLine(String.Join(",", lineItems.ToArray()));
                        }
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Error creating Back up");
                return false;
            }
        }

        public static bool ProductsBackupCreator(List<Product> _products)
        {
            string path = pathCreator("Products");

            if (!File.Exists(path))
            {

                using (TextWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("PRODUCTS");
                    sw.WriteLine("Product Id, Brand, Category, Product, SKU");
                    foreach (Product pr in _products)
                    {
                        List<String> lineItems = new List<String>();
                        lineItems.Add(pr.ProductId.ToString());
                        lineItems.Add(pr.Category.Brand.Name);
                        lineItems.Add(pr.Category.Name);
                        lineItems.Add(pr.ProductName);
                        lineItems.Add(pr.SKU);

                        sw.WriteLine(String.Join(",", lineItems.ToArray()));
                    }
                   
                    
                }
                return true;
            }
            else
            {
                MessageBox.Show("Error creating Back up");
                return false;
            }
        }

        private static string pathCreator(string stName)
        {
            string folderName = @"c:\";
            string pathString = System.IO.Path.Combine(folderName, "OrderMe");
            Directory.CreateDirectory(pathString);
            string fileName = stName + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            pathString = System.IO.Path.Combine(pathString, fileName);
            return pathString;
        }
    }
}
