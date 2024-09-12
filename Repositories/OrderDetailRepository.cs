using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository
    {
        //Nhan
        private string _connectionString = "Data Source=DESKTOP-KG5LI9R;Initial Catalog=VendingMachine;Integrated Security=True";
        //Yen private string _connectionString = @"Data Source=ACER\MYSQL2022;Initial Catalog=VendingMachine;Integrated Security=True";
        //Khuong private string _connectionString = "Server=KHUONGDAVIDPC; Database=VendingMachine; Integrated Security=True;";
        public OrderDetailRepository()
        {
            
        }
        public void Create(OrderDetail orderDetail)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO OrderDetail (OrderId, ProductId, Quantity, UnitPrice) " +
                    "VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice)", connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
                    command.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
                    command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                    command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
