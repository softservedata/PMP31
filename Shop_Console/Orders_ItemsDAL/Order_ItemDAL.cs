using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace Orders_ItemsDAL
{
    public class Order_ItemDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public Orders_Items getById(long orderID, long itemID)
        {
            try
            {
                Orders_Items order_item = (from c in Shop.Orders_Items where (c.orderID == orderID) && (c.itemID == itemID) select c).First();
                return order_item;
            }
            catch { return null; }
        }

        public List<Orders_Items> getOrdersByID(long orderID)
        {
            List<Orders_Items> orderList = new List<Orders_Items>();
            var query = from b in Shop.Orders_Items
                        orderby b.orderID
                        select b;
            foreach (var s in query)
            {
                if (s.orderID == orderID)
                {
                    orderList.Add(s);
                }
            }
            return orderList;
        }

        public void insert(Orders_Items order_item)
        {
            Shop.Orders_Items.Add(order_item);
            Shop.SaveChanges();
        }

        public void delete(Orders_Items order_item)
        {
            try
            {
                Shop.Orders_Items.Remove(order_item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long orderID, long itemID)
        {
            try
            {
                Orders_Items order_item = getById(orderID, itemID);
                Shop.Orders_Items.Remove(order_item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<Orders_Items> getAll()
        {
            var query = from b in Shop.Orders_Items
                        orderby b.orderID
                        select b;

            return query.ToList<Orders_Items>();
        }

        public void changeCount(Orders_Items order_item, int count)
        {
            try
            {
                order_item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCount(long orderID, long itemID, int count)
        {
            try
            {
                Orders_Items order_item = getById(orderID, itemID);
                order_item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }
    }
}
