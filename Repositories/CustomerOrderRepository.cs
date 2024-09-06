using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repositories
{
    public class CustomerOrderRepository
    {
        //Nhan
        private string _connectionString = "Data Source=DESKTOP-KG5LI9R;Initial Catalog=VendingMachine;Integrated Security=True";
        //Yen private string _connectionString = @"Data Source=ACER\MYSQL2022;Initial Catalog=VendingMachine;Integrated Security=True";
        //Khuong private string _connectionString = "Server=KHUONGDAVIDPC; Database=VendingMachine; Integrated Security=True;";
        public CustomerOrderRepository()
        {
        }

        public List<CustomerOrder> GetAllOrders()
        {
            var orders = new List<CustomerOrder>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT OrderId, OrderDate, TotalAmount, Status FROM CustomerOrder";
                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new CustomerOrder
                        {
                            OrderId = reader.GetInt32(0),
                            OrderDate = reader.GetDateTime(1),
                            TotalAmount = reader.GetDecimal(2),
                            Status = reader.GetString(3)
                        };
                        orders.Add(order);
                    }
                }
            }
            return orders;
        }

        public int Create(CustomerOrder order)
        {
            int orderId;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO CustomerOrder (OrderDate, TotalAmount, Status) " +
                    "OUTPUT INSERTED.OrderId " +
                    "VALUES (@OrderDate, @TotalAmount, @Status)", connection))
                {
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                    command.Parameters.AddWithValue("@Status", order.Status);

                    // Execute the command and get the inserted OrderId
                    orderId = (int)command.ExecuteScalar();
                }
            }
            return orderId;
        }
    }
}
