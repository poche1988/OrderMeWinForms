using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.DAL
{
    public class Repository
    {

        private readonly ApplicationDbContext _Context;

        private Repository()
        {
            _Context = new ApplicationDbContext();
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

        #endregion
    }


}
