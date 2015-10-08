using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.DAL
{
    class RolesDAL
    {
        p31shopEntities p31shop = new p31shopEntities();
        
        //public RolesDAL(p31shopEntities p31shop)
        //{
        //    this.p31shop = p31shop;
        //}

        public Roles getById(long id)
        {
            return (from c in p31shop.Roles where c.IdRole == id select c).First();
        }

        public Roles getByName(string name)
        {
            Roles result = null;
            foreach (Roles roles in p31shop.Roles)
            {
                if (roles.Name.Equals(name))
                {
                    Console.WriteLine("roles.Name" + roles.Name);
                    result = roles;
                    break;
                }
            }
            return result;
        }
    }
}
