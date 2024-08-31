using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository
    {
        private string _connectionString = "Data Source=DESKTOP-KG5LI9R;Initial Catalog=VendingMachine;Integrated Security=True";
        //private string _connectionString = "Server=KHUONGDAVIDPC; Database=VendingMachine; Integrated Security=True;";
        public CategoryRepository() { }
        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT CategoryId, Name, ImagePath FROM Category";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var category = new Category
                            {
                                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath"))
                            };
                            categories.Add(category);
                        }
                    }
                }
            }
            return categories;
        }
        public void AddCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Category (Name, ImagePath) VALUES (@Name, @ImagePath)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@ImagePath", category.ImagePath);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Category SET Name = @Name, ImagePath = @ImagePath WHERE CategoryId = @CategoryId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", category.Name);
                    cmd.Parameters.AddWithValue("@ImagePath", category.ImagePath);
                    cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Category WHERE CategoryId = @CategoryId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
