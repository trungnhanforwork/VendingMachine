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
    public class OrderRepository
    {
        private string _connectionString = @"Data Source=ACER\MYSQL2022;Initial Catalog=VendingMachine;Integrated Security=True";

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "SELECT OrderDetailId, OrderId, ProductId, Quantity, UnitPrice FROM OrderDetails";
                return connection.Query<OrderDetail>(sql);
            }
        }
    }
}
