using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace UsersDAL
{
    public class UserDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public User getById(long userID)
        {
            try
            {
                User user = (from c in Shop.Users where c.userID == userID select c).First();
                return user;
            }
            catch { return null; }
        }

        public User getByLogin(string login)
        {
            try
            {
                User user = (from c in Shop.Users where c.login == login select c).First();
                return user;
            }
            catch { return null; }
        }

        public void insert(User user)
        {
            bool IfAlredyExist = false;
            List<User> list = getAll();
            foreach (var s in list)
            {
                if (s.login == user.login)
                {
                    IfAlredyExist = true;
                    break;
                }
            }
            if (!IfAlredyExist)
            {
                Shop.Users.Add(user);
                Shop.SaveChanges();
            }
        }

        public void delete(User user)
        {
            try
            {
                Shop.Users.Remove(user);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long userID)
        {
            try
            {
                User user = getById(userID);
                Shop.Users.Remove(user);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<User> getAll()
        {
            var query = from b in Shop.Users
                        orderby b.userID
                        select b;
            
            return query.ToList<User>();
        }

        public void updateUser(User updateUser)
        {
            try
            {
                User user = getById(updateUser.userID);
                user.name = updateUser.name;
                user.password = updateUser.password;
                user.balanse = updateUser.balanse;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeName(User user, string name)
        {
            try
            {
                user.name = name;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeName(long userID, string name)
        {
            try
            {
                User user = getById(userID);
                user.name = name;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changePassword(User user, string password)
        {
            try
            {
                user.password = password;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changePassword(long userID, string password)
        {
            try
            {
                User user = getById(userID);
                user.password = password;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeBalanse(User user, double balanse)
        {
            try 
            {
                user.balanse = balanse;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeBalance(long userID, double balanse)
        {
            try 
            {
                User user = getById(userID);
                user.balanse = balanse;
                Shop.SaveChanges();
            }
            catch { }
        }
    }
}
