﻿using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineForm
{
    public partial class ItPanelOrder : Form
    {
        private CustomerOrderService customerOrderService;
        public ItPanelOrder()
        {
            customerOrderService = new CustomerOrderService();
            InitializeComponent();
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillDataGridView(string status)
        {
            List<CustomerOrder> orders;
            if (status == "Completed")
            {
                orders = customerOrderService.GetAllOrders().FindAll(order => order.Status == status).OrderBy(order => order.OrderDate).ToList();
            }
            else if (status == "Pending")
            {
                orders = customerOrderService.GetAllOrders().FindAll(order => order.Status == status).OrderBy(order => order.OrderDate).ToList();
            }
            else
            {
                orders = customerOrderService.GetAllOrders().OrderBy(order => order.OrderDate).ThenBy(order => order.Status).ToList();
            }

            dgvOrder.AutoGenerateColumns = true;
            if (orders != null && orders.Any())
            {
                dgvOrder.DataSource = orders;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillDataGridView("");
        }

        private void ItPanelOrder_Load(object sender, EventArgs e)
        {
            FillDataGridView("");
        }

        private void btnShowCompleted_Click(object sender, EventArgs e)
        {
            FillDataGridView("Completed");
        }

        private void btnShowPending_Click(object sender, EventArgs e)
        {
            FillDataGridView("Pending");

        }
    }
}
