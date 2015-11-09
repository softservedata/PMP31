using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;
using UsersDAL;
using ItemsDAL;
using CartsDAL;
using OrdersDAL;
using Carts_ItemsDAL;
using Orders_ItemsDAL;

namespace ShopBL
{
    public class UserT
    {
        internal long userID;
        public string name;
        public string login;
        public string password;
        public double balanse;

        public long UserID
        {
            get { return userID; }
        }
        public static User ToUser(UserT usert) // return null ?
        {
            if (usert != null)
            {
                User user = new User();
                user.userID = usert.userID;
                user.name = usert.name;
                user.login = usert.login;
                user.password = usert.password;
                user.balanse = usert.balanse;
                return user;
            }
            else { return null; }
        }
        public static UserT ToUserT(User user)  // return null ?
        {
            if (user != null)
            {
                UserT usert = new UserT();
                usert.userID = user.userID;
                usert.name = user.name;
                usert.login = user.login;
                usert.password = user.password;
                usert.balanse = user.balanse;
                return usert;
            }
            else { return null; }
        }

        public UserT getById(long userID)
        {
            User user = new UserDAL().getById(userID);
            return UserT.ToUserT(user);
        }
        public UserT getByLogin(string login)
        {
            User user = new UserDAL().getByLogin(login);
            return UserT.ToUserT(user);
        }

        public void insert(UserT usert)
        {
            new UserDAL().insert(UserT.ToUser(usert));
        }

        public void delete(UserT usert)
        {
            new UserDAL().delete(UserT.ToUser(usert));
        }

        public void delete(long userID)
        {
            new UserDAL().delete(userID);
        }

        public List<UserT> getAll()
        {
            var query = new UserDAL().getAll();
            List<UserT> users = new List<UserT>();
            foreach (var item in query)
            {
                users.Add(UserT.ToUserT(item));
            }
            return users;
        }

        public void updateUser(UserT updateUsert)
        {
            new UserDAL().updateUser(UserT.ToUser(updateUsert));
        }

        public void changeName(UserT usert, string name)
        {
            new UserDAL().changeName(UserT.ToUser(usert), name);
        }

        public void changeName(long userID, string name)
        {
            new UserDAL().changeName(userID, name);
        }

        public void changePassword(UserT usert, string password)
        {
            new UserDAL().changePassword(UserT.ToUser(usert), name);
        }

        public void changePassword(long userID, string password)
        {
            new UserDAL().changePassword(userID, name);
        }

        public void changeBalanse(UserT usert, double balanse)
        {
            new UserDAL().changeBalanse(UserT.ToUser(usert), balanse);
        }

        public void changeBalanse(long userID, double balanse)
        {
            new UserDAL().changeBalance(userID, balanse);
        }

    }

    public class ItemT
    {
        internal long itemID;
        public string name;
        public double price;
        public int count;
        public string category;

        public long ItemID
        {
            get { return itemID; }
        }
        public static Item ToItem(ItemT itemt) // return null?
        {
            if (itemt != null)
            {
                Item item = new Item();
                item.itemID = itemt.itemID;
                item.name = itemt.name;
                item.price = itemt.price;
                item.count = itemt.count;
                item.category = itemt.category;
                return item;
            }
            else { return null; }
        }
        public static ItemT ToItemT(Item item) // return null?
        {
            if (item != null)
            {
                ItemT itemt = new ItemT();
                itemt.itemID = item.itemID;
                itemt.name = item.name;
                itemt.price = item.price;
                itemt.count = item.count;
                itemt.category = item.category;
                return itemt;
            }
            else { return null; }
        }

        public ItemT getById(long itemID)
        {
            Item item = new ItemDAL().getById(itemID);
            return ItemT.ToItemT(item);
        }

        public void insert(ItemT itemt)
        {
            new ItemDAL().insert(ItemT.ToItem(itemt));
        }

        public void delete(ItemT itemt)
        {
            new ItemDAL().delete(ItemT.ToItem(itemt));
        }

        public void delete(long itemID)
        {
            new ItemDAL().delete(itemID);
        }

        public List<ItemT> getAll()
        {
            var query = new ItemDAL().getAll();
            List<ItemT> items = new List<ItemT>();
            foreach (var item in query)
            {
                items.Add(ItemT.ToItemT(item));
            }
            return items;
        }

        public List<ItemT> getItemsByCategory(string category)
        {
            List<Item> itemList = new ItemDAL().getItemsByCategory(category);
            List<ItemT> itemListT = new List<ItemT>();
            foreach (var s in itemList)
            {
                itemListT.Add(ItemT.ToItemT(s));
            }
            return itemListT;
        }

        public void updateItem(ItemT updateItemt)
        {
            new ItemDAL().updateItem(ItemT.ToItem(updateItemt));
        }

        public void changeName(ItemT itemt, string name)
        {
            new ItemDAL().changeName(ItemT.ToItem(itemt), name);
        }

        public void changeName(long itemID, string name)
        {
            new UserDAL().changeName(itemID, name);
        }

        public void changePrice(ItemT itemt, double price)
        {
            new ItemDAL().changePrice(ItemT.ToItem(itemt), price);
        }

        public void changePrice(long itemID, double price)
        {
            new ItemDAL().changePrice(itemID, price);
        }

        public void changeCount(ItemT itemt, int count)
        {
            new ItemDAL().changeCount(ItemT.ToItem(itemt), count);
        }

        public void changeCount(long itemID, int count)
        {
            new ItemDAL().changeCount(itemID, count);
        }

        public void changeCategory(ItemT itemt, string category)
        {
            new ItemDAL().changeCategory(ItemT.ToItem(itemt), category);
        }

        public void changeCategory(long itemID, string category)
        {
            new ItemDAL().changeCategory(itemID, category);
        }

    }

    public class OrderT
    {
        internal long orderID;
        public long userID;

        public long OrderID
        {
            get { return orderID; }
        }

        public static Order ToOrder(OrderT ordert) // return null?
        {
            if (ordert != null)
            {
                Order order = new Order();
                order.orderID = ordert.orderID;
                order.userID = ordert.userID;
                return order;
            }
            else { return null; }
        }
        public static OrderT ToOrderT(Order order) // return null?
        {
            if (order != null)
            {
                OrderT ordert = new OrderT();
                ordert.orderID = order.orderID;
                ordert.userID = order.userID;
                return ordert;
            }
            else { return null; }
        }

        public OrderT getById(long orderID)
        {
            Order order = new OrderDAL().getById(orderID);
            return OrderT.ToOrderT(order);
        }

        public OrderT getByUserId(long userID)
        {
            Order order = new OrderDAL().getByUserId(userID);
            return OrderT.ToOrderT(order);
        }

        public void insert(OrderT ordert)
        {
            new OrderDAL().insert(OrderT.ToOrder(ordert));
        }

        public void delete(OrderT ordert)
        {
            new OrderDAL().delete(OrderT.ToOrder(ordert));
        }

        public void delete(long orderID)
        {
            new OrderDAL().delete(orderID);
        }

        public List<OrderT> getAll()
        {
            var query = new OrderDAL().getAll();
            List<OrderT> orders = new List<OrderT>();
            foreach (var item in query)
            {
                orders.Add(OrderT.ToOrderT(item));
            }
            return orders;
        }

    }

    public class CartT
    {
        internal long cartID;
        public long userID;

        public long CartID
        {
            get { return cartID; }
        }

        public static Cart ToCart(CartT cartT) // return null?
        {
            if (cartT != null)
            {
                Cart cart = new Cart();
                cart.cartID = cartT.cartID;
                cart.userID = cartT.userID;
                return cart;
            }
            else { return null; }
        }
        public static CartT ToCartT(Cart cart) // return null?
        {
            if (cart != null)
            {
                CartT cartT = new CartT();
                cartT.cartID = cart.cartID;
                cartT.userID = cart.userID;
                return cartT;
            }
            else { return null; }
        }

        public CartT getById(long cartID)
        {
            Cart cart = new CartDAL().getById(cartID);
            return CartT.ToCartT(cart);
        }

        public CartT getByUserId(long userID)
        {
            Cart cart = new CartDAL().getByUserId(userID);
            return CartT.ToCartT(cart);
        }

        public void insert(CartT cartT)
        {
            new CartDAL().insert(CartT.ToCart(cartT));
        }

        public void delete(CartT cartT)
        {
            new CartDAL().delete(CartT.ToCart(cartT));
        }

        public void delete(long cartID)
        {
            new CartDAL().delete(cartID);
        }

        public List<CartT> getAll()
        {
            var query = new CartDAL().getAll();
            List<CartT> carts = new List<CartT>();
            foreach (var item in query)
            {
                carts.Add(CartT.ToCartT(item));
            }
            return carts;
        }
    }

    public class Orders_ItemsT
    {
        public long orderID;
        public long itemID;
        public int count;

        public static Orders_Items ToOrders_Items(Orders_ItemsT order_itemT) // return null?
        {
            if (order_itemT != null)
            {
                Orders_Items order_item = new Orders_Items();
                order_item.orderID = order_itemT.orderID;
                order_item.itemID = order_itemT.itemID;
                order_item.count = order_itemT.count;
                return order_item;
            }
            else { return null; }
        }
        public static Orders_ItemsT ToOrders_ItemsT(Orders_Items order_item) // return null?
        {
            if (order_item != null)
            {
                Orders_ItemsT order_itemT = new Orders_ItemsT();
                order_itemT.orderID = order_item.orderID;
                order_itemT.itemID = order_item.itemID;
                order_itemT.count = order_item.count;
                return order_itemT;
            }
            else { return null; }
        }

        public Orders_ItemsT getById(long orderID, long itemID)
        {
            Orders_Items order_item = new Order_ItemDAL().getById(orderID, itemID);
            return Orders_ItemsT.ToOrders_ItemsT(order_item);
        }

        public List<Orders_ItemsT> getOrdersByID(long orderID)
        {
            List<Orders_Items> orderList = new Order_ItemDAL().getOrdersByID(orderID);
            List<Orders_ItemsT> orderListT = new List<Orders_ItemsT>();
            foreach (var s in orderList)
            {
                orderListT.Add(Orders_ItemsT.ToOrders_ItemsT(s));
            }
            return orderListT;
        }

        public void insert(Orders_ItemsT order_itemt)
        {
            new Order_ItemDAL().insert(Orders_ItemsT.ToOrders_Items(order_itemt));
        }

        public void delete(Orders_ItemsT order_itemt)
        {
            new Order_ItemDAL().delete(Orders_ItemsT.ToOrders_Items(order_itemt));
        }

        public void delete(long orderID, long itemID)
        {
            new Order_ItemDAL().delete(orderID, itemID);
        }

        public List<Orders_ItemsT> getAll()
        {
            List<Orders_Items> orderList = new Order_ItemDAL().getAll();
            List<Orders_ItemsT> orderListT = new List<Orders_ItemsT>();
            foreach (var s in orderList)
            {
                orderListT.Add(Orders_ItemsT.ToOrders_ItemsT(s));
            }

            return orderListT;
        }

        public void changeCount(Orders_ItemsT order_itemt, int count)
        {
            new Order_ItemDAL().changeCount(Orders_ItemsT.ToOrders_Items(order_itemt), count);
        }

        public void changeCount(long orderID, long itemID, int count)
        {
            new Order_ItemDAL().changeCount(orderID, itemID, count);
        }
    }

    public class Carts_ItemsT
    {
        public long cartID;
        public long itemID;
        public int count;

        public static Carts_Items ToCarts_Items(Carts_ItemsT cart_itemT) // return null?
        {
            if (cart_itemT != null)
            {
                Carts_Items cart_item = new Carts_Items();
                cart_item.cartID = cart_itemT.cartID;
                cart_item.itemID = cart_itemT.itemID;
                cart_item.count = cart_itemT.count;
                return cart_item;
            }
            else { return null; }
        }
        public static Carts_ItemsT ToCarts_ItemsT(Carts_Items cart_item) // return null?
        {
            if (cart_item != null)
            {
                Carts_ItemsT cart_itemT = new Carts_ItemsT();
                cart_itemT.cartID = cart_item.cartID;
                cart_itemT.itemID = cart_item.itemID;
                cart_itemT.count = cart_item.count;
                return cart_itemT;
            }
            else { return null; }
        }

        public Carts_ItemsT getById(long cartID, long itemID)
        {
            Carts_Items cart_item = new Cart_ItemDAL().getById(cartID, itemID);
            return Carts_ItemsT.ToCarts_ItemsT(cart_item);
        }

        public List<Carts_ItemsT> getCartsByID(long cartID)
        {
            List<Carts_Items> cartList = new Cart_ItemDAL().getCartsByID(cartID);
            List<Carts_ItemsT> cartListT = new List<Carts_ItemsT>();
            foreach (var s in cartList)
            {
                cartListT.Add(Carts_ItemsT.ToCarts_ItemsT(s));
            }
            return cartListT;
        }

        public void insert(Carts_ItemsT cart_itemt)
        {
            new Cart_ItemDAL().insert(Carts_ItemsT.ToCarts_Items(cart_itemt));
        }

        public void delete(Carts_ItemsT cart_itemt)
        {
            new Cart_ItemDAL().delete(Carts_ItemsT.ToCarts_Items(cart_itemt));
        }

        public void delete(long cartID, long itemID)
        {
            new Cart_ItemDAL().delete(cartID, itemID);
        }

        public List<Carts_ItemsT> getAll()
        {
            List<Carts_Items> cartList = new Cart_ItemDAL().getAll();
            List<Carts_ItemsT> cartListT = new List<Carts_ItemsT>();
            foreach (var s in cartList)
            {
                cartListT.Add(Carts_ItemsT.ToCarts_ItemsT(s));
            }

            return cartListT;
        }

        public void changeCount(Carts_ItemsT cart_itemt, int count)
        {
            new Cart_ItemDAL().changeCount(Carts_ItemsT.ToCarts_Items(cart_itemt), count);
        }

        public void changeCount(long cartID, long itemID, int count)
        {
            new Cart_ItemDAL().changeCount(cartID, itemID, count);
        }
    }


    public class ShopBLClass
    {
    }
}
