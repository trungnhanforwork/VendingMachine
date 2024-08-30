using Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetAllCategories();

            categories.ForEach(category => Console.WriteLine(category.CategoryId + " " + category.Name + " " + category.ImagePath));
        }
    }
}
