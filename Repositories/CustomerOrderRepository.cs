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
        private string _connectionString = "Data Source=DESKTOP-KG5LI9R;Initial Catalog=VendingMachine;Integrated Security=True";
        // private string _connectionString = @"Data Source=ACER\MYSQL2022;Initial Catalog=VendingMachine;Integrated Security=True";

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
    }
}
