using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace Carts_ItemsDAL
{
    public class Cart_ItemDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public Carts_Items getById(long cartID, long itemID)
        {
            try
            {
                Carts_Items cart_item = (from c in Shop.Carts_Items where (c.cartID == cartID) && (c.itemID == itemID) select c).First();
                return cart_item;
            }
            catch { return null; }
        }

        public List<Carts_Items> getCartsByID(long cartID)
        {
            List<Carts_Items> cartList = new List<Carts_Items>();
            var query = from b in Shop.Carts_Items
                        orderby b.cartID
                        select b;
            foreach (var s in query)
            {
                if (s.cartID == cartID)
                {
                    cartList.Add(s);
                }
            }
            return cartList;
        }

        public void insert(Carts_Items cart_item)
        {
            Shop.Carts_Items.Add(cart_item);
            Shop.SaveChanges();
        }

        public void delete(Carts_Items cart_item)
        {
            try
            {
                Shop.Carts_Items.Remove(cart_item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long cartID, long itemID)
        {
            try
            {
                Carts_Items cart_item = getById(cartID, itemID);
                Shop.Carts_Items.Remove(cart_item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<Carts_Items> getAll()
        {
            var query = from b in Shop.Carts_Items
                        orderby b.cartID
                        select b;

            return query.ToList<Carts_Items>();
        }

        public void changeCount(Carts_Items cart_item, int count)
        {
            try
            {
                cart_item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCount(long cartID, long itemID, int count)
        {
            try
            {
                Carts_Items cart_item = getById(cartID, itemID);
                cart_item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }
    }
}
