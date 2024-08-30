using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        private CategoryRepository categoryRepository;
        public CategoryService() {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }
        public void CreateCategory(Category category) 
        {
            categoryRepository.AddCategory(category);
        }
        public void UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
