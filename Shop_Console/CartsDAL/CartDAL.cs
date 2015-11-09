using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace CartsDAL
{
    public class CartDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public Cart getById(long cartID)
        {
            try
            {
                Cart cart = (from c in Shop.Carts where c.cartID == cartID select c).First();
                return cart;
            }
            catch { return null; }
        }

        public Cart getByUserId(long userID)
        {
            try
            {
                Cart cart = (from c in Shop.Carts where c.userID == userID select c).Last();
                return cart;
            }
            catch { return null; }
        }

        public void insert(Cart cart)
        {
            Shop.Carts.Add(cart);
            Shop.SaveChanges();
        }

        public void delete(Cart cart)
        {
            try
            {
                Cart cartt = getById(cart.cartID);
                Shop.Carts.Remove(cartt);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long cartID)
        {
            try
            {
                Cart cart = getById(cartID);
                Shop.Carts.Remove(cart);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<Cart> getAll()
        {
            var query = from b in Shop.Carts
                        orderby b.cartID
                        select b;

            return query.ToList<Cart>();
        }
    }
}
