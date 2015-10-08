using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.DAL
{
    class UsersDAL
    {
        p31shopEntities p31shop = new p31shopEntities();

        public Users getById(long id)
        {
            return (from c in p31shop.Users where c.IdUsers == id select c).First();
        }

        public void insert(Users user, string nameRole)
        {
            Roles adminRole = (new RolesDAL()).getByName("Admin");
            user.IdRole = adminRole.IdRole;
            p31shop.AddToUsers(user);
            p31shop.SaveChanges();
        }

    }
}
