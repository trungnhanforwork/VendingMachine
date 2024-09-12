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
        //private string _connectionString = "Server=KHUONGDAVIDPC; Database=VendingMachine; Integrated Security=True;";
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

        public CustomerOrder GetOrderById(int orderId)
        {
            CustomerOrder order = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT OrderId, OrderDate, TotalAmount, Status FROM CustomerOrder WHERE OrderId = @OrderId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            order = new CustomerOrder
                            {
                                OrderId = reader.GetInt32(0),
                                OrderDate = reader.GetDateTime(1),
                                TotalAmount = reader.GetDecimal(2),
                                Status = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return order;
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
        public List<CustomerOrder> GetOrdersByMonth(int month)
        {
            var orders = new List<CustomerOrder>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT OrderId, OrderDate, TotalAmount, Status FROM CustomerOrder WHERE MONTH(OrderDate) = @Month";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm tham số cho câu lệnh SQL
                    command.Parameters.AddWithValue("@Month", month);

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
            }
            return orders;
        }

        
        public bool UpdateOrderStatus(int orderId, string newStatus)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE CustomerOrder SET Status = @Status WHERE OrderId = @OrderId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@Status", newStatus);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if at least one row was updated
                }
            }
            
        }
    }
}
