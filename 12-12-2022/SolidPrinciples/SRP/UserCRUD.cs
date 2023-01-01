using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class UserCRUD
    {
        public void Create(User user)
        {
            Database.UserDataBase.Add(user);
        }

        public void Delete(User user)
        {
            Database.UserDataBase.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return Database.UserDataBase;
        }
    }
}
