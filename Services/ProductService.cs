using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class ProductService
    {
        private ProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _productRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            if (product.ProductId <= 0)
            {
                throw new ArgumentException("Product ID must be greater than 0.", nameof(product.ProductId));
            }
            _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            if (productId <= 0)
            {
                throw new ArgumentException("Product ID must be greater than 0.", nameof(productId));
            }
            _productRepository.DeleteProduct(productId);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public List<Product> GetProductsByCondition(string name)
        {
            var products = _productRepository.GetAllProducts();
            var productsByCondition = products.FindAll(category => category.Name.ToLower().Contains(name));
            return productsByCondition;
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productRepository.GetProductsByCategoryId(categoryId);
        }

        public Product GetProductById(int id)
        {
            var product = _productRepository.GetProductsById(id);
            return product;
        }
    }
}
