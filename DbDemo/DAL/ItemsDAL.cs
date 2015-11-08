using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.DAL
{
    class ItemsDAL
    {
        DeviceCategoryContext DeviceCategory = new DeviceCategoryContext();
        public Items item = new Items();
        public List<int> itemsList()
        {
            List<int> idCategInItemsL = (from c in DeviceCategory.Items
                                         select c.id_category).ToList();
            return idCategInItemsL;
        }
        public void deleteItems( int id)
        {
            {
                var deleteL= (from c in DeviceCategory.Items
                              where c.id_category == id
                              select c).First();
                DeviceCategory.Items.Remove(deleteL);
                DeviceCategory.SaveChanges();
            }
        }
        public void addItem(int id_categ)
        {
            item.id_item = id_categ;
            Console.WriteLine("Input item name: ");
            string name1 = Convert.ToString(Console.ReadLine());
            item.i_name = name1;
            Console.WriteLine("Input item price: ");
            int price1 = Convert.ToInt32(Console.ReadLine());
            item.price = price1;
            item.id_category = id_categ;
            DeviceCategory.Items.Add(item);
            DeviceCategory.SaveChanges();
        }

        //-------sorting by price---------------
        public void sortItemByPrice()
        {
            var sortL = DeviceCategory.Items.OrderBy(p => p.price);
            foreach (Items p in sortL)
                Console.WriteLine(p.i_name + " " + p.price);
        }
      
    }
}
