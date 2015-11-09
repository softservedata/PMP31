using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace OrdersDAL
{
    public class OrderDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public Order getById(long orderID)
        {
            try
            {
                Order order = (from c in Shop.Orders where c.orderID == orderID select c).First();
                return order;
            }
            catch { return null; }
        }

        public Order getByUserId(long userID)
        {
            try
            {
                Order order = (from c in Shop.Orders where c.userID == userID select c).Last();
                return order;
            }
            catch { return null; }
        }

        public void insert(Order order)
        {
            Shop.Orders.Add(order);
            Shop.SaveChanges();
        }

        public void delete(Order order)
        {
            try
            {
                Order orderr = getById(order.orderID);
                Shop.Orders.Remove(orderr);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long orderID)
        {
            try
            {
                Order order = getById(orderID);
                Shop.Orders.Remove(order);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<Order> getAll()
        {
            var query = from b in Shop.Orders
                        orderby b.orderID
                        select b;

            return query.ToList<Order>();
        }
    }
}
