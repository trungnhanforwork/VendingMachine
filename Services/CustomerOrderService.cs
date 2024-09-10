using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerOrderService
    {
        private  CustomerOrderRepository customerOrderRepository;
        private OrderDetailRepository orderDetailRepository;


        public CustomerOrderService()
        {
            customerOrderRepository = new CustomerOrderRepository();
            orderDetailRepository = new OrderDetailRepository();
        }
        public List<CustomerOrder> GetAllOrders()
        {
            return customerOrderRepository.GetAllOrders();
        }
        public int CreateOrder(CustomerOrder order, List<OrderDetail> orderDetails)
        {
            // Save the order and get the generated OrderId
            int orderId = customerOrderRepository.Create(order);

            // Assign the OrderId to each OrderDetail and save them
            foreach (var detail in orderDetails)
            {
                detail.OrderId = orderId;
                orderDetailRepository.Create(detail);
            }
            return orderId;
        }
        public List<CustomerOrder> GetOrdersByMonth(int month) 
        {
            return customerOrderRepository.GetOrdersByMonth(month);
        }
    }
}
