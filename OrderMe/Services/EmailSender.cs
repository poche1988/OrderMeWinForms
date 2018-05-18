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
        public static bool SendEmail(Order order)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("gonzaloamado88@gmail.com");
                message.To.Add(new MailAddress("futbolcracks.agentes@gmail.com"));
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

                message.Body = content;
                message.IsBodyHtml = true;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gonzaloamado88@gmail.com", "poche1988");
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
