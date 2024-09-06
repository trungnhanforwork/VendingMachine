using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Repositories
{
    public class ProductRepository
    {
        private string _connectionString = "Data Source=DESKTOP-KG5LI9R;Initial Catalog=VendingMachine;Integrated Security=True";
        // Khuong private string _connectionString = "Server=KHUONGDAVIDPC; Database=VendingMachine; Integrated Security=True;";
        public ProductRepository()
        {

        }
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Product";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath")),
                                Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            Console.WriteLine(products.Count);
            return products;
        }
        public void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Product (Name, Price, Stock, ImagePath, CategoryId) VALUES (@Name, @Price, @Stock, @ImagePath, @CategoryId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@ImagePath", product.ImagePath);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "UPDATE Product SET Name = @Name, Price = @Price, Stock = @Stock, ImagePath = @ImagePath, CategoryId = @CategoryId WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@ImagePath", product.ImagePath);
                    command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    command.Parameters.AddWithValue("@ProductId", product.ProductId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Product WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@ProductId", productId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Product WHERE CategoryId = @CategoryId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductId = (int)reader["ProductId"],
                                Name = reader["Name"].ToString(),
                                Price = (decimal)reader["Price"],
                                Stock = (int)reader["Stock"],
                                ImagePath = reader["ImagePath"].ToString(),
                                CategoryId = (int)reader["CategoryId"]
                            });
                        }
                    }
                }
            }

            return products;
        }

        public Product? GetProductsById(int id)
        {
            Product product = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Product WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product = new Product
                            {
                                ProductId = (int)reader["ProductId"],
                                Name = reader["Name"].ToString(),
                                Price = (decimal)reader["Price"],
                                Stock = (int)reader["Stock"],
                                ImagePath = reader["ImagePath"].ToString(),
                                CategoryId = (int)reader["CategoryId"]
                            };
                        }
                    }
                }
            }

            return product;
        }
    }
}
