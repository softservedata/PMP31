using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.DAL
{
    class OrdersDAL
    {
        orderManagerEntities order = new orderManagerEntities();
        public List<int> ItemsList(int id_u)
        {
            List<int> orderL = (from c in order.Orders
                                where c.id_user==id_u
                                select c.id_item).ToList();
            
            return orderL;
        }
        public List<int> UsersList(int id_i)
        {
            List<int> orderL = (from c in order.Orders
                                where c.id_item==id_i
                                select c.id_user).ToList();
            return orderL;
        }
        public void deleteOrder(int id_o)
        {
            var delete = (from c in order.Orders
                          where c.id_order == id_o
                          select c).First();
            order.Orders.Remove(delete);
            order.SaveChanges();
            Console.WriteLine("Order is delete");
        }
        public void addOrder(int id_u, int id_i, int id_s)
        {
            Orders orders = new Orders();
            orders.id_item = id_i;
            orders.id_user = id_u;
            orders.status = id_s;
            order.Orders.Add(orders);
            order.SaveChanges();
            Console.WriteLine("Order is add");
        }
    }
}
