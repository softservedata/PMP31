using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication2.DAL;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            p31shopEntities p31shop = new p31shopEntities();
            //Roles roles = new Roles();
            //var roles = (from c in p31shop.Roles where c.IdRole == 1 select c).First();
            //
            //Users user = new Users();
            //user.Name = "Max2";
            //user.Login = "SuperMAX2++";
            //user.Password = "qwerty2++";
            //Roles adminRole = (new RolesDAL()).getByName("Admin");
            //user.IdRole = adminRole.IdRole;
            //p31shop.AddToUsers(user);
            //p31shop.SaveChanges();
            //
            Users user = new Users();
            user.Name = "Max2";
            user.Login = "SuperMAX2**";
            user.Password = "qwerty2**";
            new UsersDAL().insert(user, "Admin");
            //
            //Users user = (new UsersDAL()).getById(1);
            //Console.WriteLine("Login=" + user.Login + " Role=" + user.Roles.Name);
            Console.WriteLine("\nend");
        }
    }
}
