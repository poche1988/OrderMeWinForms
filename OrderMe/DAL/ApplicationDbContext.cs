using OrderMe.Models;
using System.Data.Entity;


namespace OrderMe.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
