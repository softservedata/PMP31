using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbDemo.DAL;


namespace DbDemo
{
    class DemoConsole
    {
        public void DemoCons(DeviceCategoryContext DeviceCategory)
        {
            
            Console.WriteLine("Do you want to see a list of categories? Input yes/no.  ");
            string showList = Convert.ToString(Console.ReadLine());
            List<string> categoryL = (new CategoryDAL().categoryList());
            List<int> itemsL = (new ItemsDAL().itemsList());
            if (showList == "yes")
            {
                Console.WriteLine();
                foreach (var name1 in categoryL)
                    Console.WriteLine(name1);
            }
            Console.WriteLine("-------------------------------------------------");
            string a = "";
            Console.WriteLine("Search category name. Input name. ");
            string name = (new CategoryDAL().serchCategory(categoryL, ref a));
            if (a == "is found")
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Do you want to delete this category ? Input yes/no. ");
                string categoryDelete = Convert.ToString(Console.ReadLine());
                if (categoryDelete == "yes")
                {
                    int tempId = (new CategoryDAL().indefDeleteCategory(ref a, name));
                    new ItemsDAL().deleteItems(tempId);
                    new CategoryDAL().deleteCategory(name);

                }
                Console.WriteLine("-------------------------------------------------");
                if (categoryDelete == "no")
                {
                    Console.WriteLine("Do you want to edit this category ? Input yes/no. ");
                    string categoryEdit = Convert.ToString(Console.ReadLine());
                    if (categoryEdit == "yes")
                    {
                        Console.WriteLine("Input new category name: ");
                        string nameEdit = Convert.ToString(Console.ReadLine());
                        new CategoryDAL().editCategory(nameEdit, name);

                    }
                }
            }
            if (a == "is not found")
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Do you want to add this category ? Input yes/no. ");
                string categoryAdd = Convert.ToString(Console.ReadLine());
                if (categoryAdd == "yes")
                {
                    Console.WriteLine("Input category id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string temp=(new CategoryDAL().ifIdIsDefinite(id));
                    if (temp == "is not used")
                    {
                        int id_categ = (new CategoryDAL().addCategory(name, id));
                        List<int> listId = (new CategoryDAL().categoryIdList());
                        new ItemsDAL().addItem(id_categ);
                    }
                    else
                    {
                        while (temp == "is used")
                        {
                            Console.WriteLine("id is used for another category.Select new id:");
                            id = Convert.ToInt32(Console.ReadLine());
                            temp = (new CategoryDAL().ifIdIsDefinite(id));
                        }
                        int id_categ = (new CategoryDAL().addCategory(name, id));
                        List<int> listId = (new CategoryDAL().categoryIdList());
                        new ItemsDAL().addItem(id_categ);
                    }
                }
            }
            Console.WriteLine("Sort items by price:");
            new ItemsDAL().sortItemByPrice();
        }
    }
}
