using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_DB_Model;

namespace ItemsDAL
{
    public class ItemDAL
    {
        ShopDBEntities Shop = new ShopDBEntities();

        public Item getById(long itemID)
        {
            try
            {
                Item item = (from c in Shop.Items where c.itemID == itemID select c).First();
                return item;
            }
            catch { return null; }
        }

        public void insert(Item item)
        {
            Shop.Items.Add(item);
            Shop.SaveChanges();
        }

        public void delete(Item item)
        {
            try
            {
                Shop.Items.Remove(item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public void delete(long itemID)
        {
            try
            {
                Item item = getById(itemID);
                Shop.Items.Remove(item);
                Shop.SaveChanges();
            }
            catch { }
        }

        public List<Item> getAll()
        {
            var query = from b in Shop.Items
                        orderby b.itemID
                        select b;

            return query.ToList<Item>();
        }

        public void updateItem(Item updateItem)
        {
            try
            {
                Item item = getById(updateItem.itemID);
                item.name = updateItem.name;
                item.price = updateItem.price;
                item.count = updateItem.count;
                item.category = updateItem.category;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeName(Item item, string name)
        {
            try
            {
                item.name = name;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeName(long itemID, string name)
        {
            try
            {
                Item item = getById(itemID);
                item.name = name;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changePrice(Item item, double price)
        {
            try
            {
                item.price = price;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changePrice(long itemID, double price)
        {
            try
            {
                Item item = getById(itemID);
                item.price = price;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCount(Item item, int count)
        {
            try
            {
                item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCount(long itemID, int count)
        {
            try
            {
                Item item = getById(itemID);
                item.count = count;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCategory(Item item, string category)
        {
            try
            {
                item.category = category;
                Shop.SaveChanges();
            }
            catch { }
        }

        public void changeCategory(long itemID, string category)
        {
            try
            {
                Item item = getById(itemID);
                item.category = category;
                Shop.SaveChanges();
            }
            catch { }
        }
    }
}
