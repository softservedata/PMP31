using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.DAL
{
    class CategoryDAL
    {
       DeviceCategoryContext DeviceCategory = new DeviceCategoryContext();
       public Category category = new Category();
            
            //--------------list of name category-----------------------
        public List<string> categoryList()
        {
            List<string> categoryL = (from c in DeviceCategory.Category
                              select c.c_name).ToList();
            return categoryL;
        }
        //-----------------list of id categ------------
        public List<int> categoryIdList()
        {
            List<int> idL = (from c in DeviceCategory.Category
                              select c.id_category).ToList();
            return idL;
        }
          //--------------serch 1 category if it is---------------------------
        public string serchCategory(List<string> L,ref string a )
        {
            string name = Convert.ToString(Console.ReadLine());
            a = "is not found";
            foreach (var name1 in L)
            {
                if (name1 == name)
                    a = "is found";      
            }
            Console.WriteLine(name+" "+a);
            return name;
        }
        //---------------------------delete 1 category------------
        public int indefDeleteCategory(ref string a, string name)
        {
            int id=0;
            if (a == "is found")
            {
                var tempName = (from c in DeviceCategory.Category
                              where c.c_name == name
                              select c.c_name).First();
                var id_categor = (from c in DeviceCategory.Category
                                  where c.c_name == name
                                  select c.id_category).First();
                id = id_categor;

                
            }
            return id;
        }
        public void deleteCategory( string name)
        {
                var delete = (from c in DeviceCategory.Category
                                where c.c_name == name
                                select c).First();
            DeviceCategory.Category.Remove(delete);
            DeviceCategory.SaveChanges();
        }
        public int addCategory(string name,int inputId)
        {
            category.c_name = name;
            category.id_category = inputId;
            DeviceCategory.Category.Add(category);
            DeviceCategory.SaveChanges();
            return inputId;
        }
        public void editCategory(string newName, string name)
        {
            foreach (var order in DeviceCategory.Category)
            {
                if (order.c_name == name)
                {
                    order.c_name = newName;
                }
            }

            DeviceCategory.SaveChanges();
        }
        public string ifIdIsDefinite(int inputId)
        {
           string temp="is not used"; 
           List<int>  list =categoryIdList();
           foreach (int id in list)
           {
               if (inputId == id)
               {
                   temp="is used";
               }
           }
           return temp;
        }
        
    }
}
