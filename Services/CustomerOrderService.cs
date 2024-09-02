﻿using Entities;
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
        public CustomerOrderService()
        {
            customerOrderRepository = new CustomerOrderRepository();
        }
        public List<CustomerOrder> GetAllOrders()
        {
            return customerOrderRepository.GetAllOrders();
        }
    }
}
