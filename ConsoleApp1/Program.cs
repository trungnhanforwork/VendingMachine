using Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            var products = productService.GetProductsByCategoryId(11);

            products.ForEach(product => Console.WriteLine(product.CategoryId + " " + product.Name + " " + product.ImagePath));
        }
    }
}
