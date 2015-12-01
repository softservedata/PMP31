using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPZ.DAL
{
    class CategoriesDAL
    {
            public List<CategoryDTO> GetCategoriesSortedById(int start,int take)
            {
                var categories = new List<CategoryDTO>();
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    categories = context.Categories.
                        Select(c => new CategoryDTO
                        {
                            id_categ = c.id_categ,
                            categ_name = c.categ_name
                        }
                    ).OrderBy(c => c.id_categ).Skip(start).Take(take).ToList();
                }
                return categories;
            }
            public List<CategoryDTO> GetCategoriesSortedByName(int start, int take)
            {
                var categories = new List<CategoryDTO>();
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    categories = context.Categories.
                        Select(c => new CategoryDTO
                        {
                            id_categ = c.id_categ,
                            categ_name = c.categ_name
                        }
                    ).OrderBy(c => c.categ_name).Skip(start).Take(take).ToList();
                }
                return categories;
            }
            public CategoryDTO GetCategoryByID(int id_categ)
            {
                var category = new CategoryDTO();
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    category = context.Categories.Select(c => new CategoryDTO
                    {
                        id_categ = c.id_categ,
                        categ_name = c.categ_name
                    }).FirstOrDefault(c => c.id_categ == id_categ);
                }
                return category;
            }
            public CategoryDTO GetCategoryByName(string categ_name)
            {
                var category = new CategoryDTO();
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    category = context.Categories.Select(c => new CategoryDTO
                    {
                        id_categ = c.id_categ,
                        categ_name = c.categ_name
                    }).FirstOrDefault(c => c.categ_name == categ_name);
                }
                return category;
            }
            public void updateCategory(CategoryDTO updatedCategory)
            {
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    var category = context.Categories.FirstOrDefault(c => c.id_categ == updatedCategory.id_categ);
                    category.categ_name = updatedCategory.categ_name;
                    context.SaveChanges();
                }
            }
            public void deleteCategory(CategoryDTO deletedCategory)
            {
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    var category = (from c in context.Categories
                                    where c.categ_name == deletedCategory.categ_name
                                    select c).First();
                    context.Categories.Remove(category);

                    context.SaveChanges();
                }
            }
            public void insertCategory(CategoryDTO insertedCategory)
            {
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    Categories category = new Categories();
                    category.categ_name = insertedCategory.categ_name;
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
            }
            public int CountCateg()
            {
                int count;
                using (DeviceCategoryContext context = new DeviceCategoryContext())
                {
                    count = context.Categories.Count();
                }
                return count;
            }
        }
    }
