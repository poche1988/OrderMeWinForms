using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMe.Services
{
    public static class EmailSender
    {
        public static bool SendEmail(Order order, string emailAddress, string comments)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("accounts@otiasandlouie.com");
                message.To.Add(new MailAddress(emailAddress));
                message.Subject = "New Order - Otis & Louie - " + order.Date.ToString("dd-MM-yyyy");

                string content = "Company: " + order.Company + "<br />" +
                    "Contact: " + order.Contact + "<br />" +
                    "Date: " + order.Date.ToString("dd-MM-yyyy") + "<br /><br />" +
                    "Order Details: <br />";
                foreach (OrderDetail od in order.OrderDetails)
                {
                    content += od.Product.Category.Brand.Name + " "
                        + od.Product.Category.Name + " " +
                        od.Product.ProductName + "- Quantity: " + od.Quantity.ToString() + "<br />";
                }

                if (!string.IsNullOrEmpty(comments))
                    content += "<br />Comments:" + comments; 

                message.Body = content;
                message.IsBodyHtml = true;
                smtp.Port = 587;
                smtp.Host = "103.250.119.215";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("accounts@otiasandlouie.com", "money1");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email is NOT sent - Connection Error");
                return false;
            }
        }
    }
}
