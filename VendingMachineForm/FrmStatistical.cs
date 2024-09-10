using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;
namespace VendingMachineForm
{
    public partial class FrmStatistical : Form
    {
        private CustomerOrderService customerOrderService;
        public FrmStatistical()
        {
            customerOrderService = new CustomerOrderService();
            InitializeComponent();
        }
        public void loadMonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                // Tạo một panel cho từng tháng
                Panel MonthPanel = new Panel
                {
                    Width = 80,  // Điều chỉnh chiều rộng
                    Height = 35, // Điều chỉnh chiều cao
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i // Gán giá trị tháng vào thuộc tính Tag
                };

                // Tạo một label cho tháng
                Label label = new Label
                {
                    Text = "Tháng " + i.ToString(),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Thêm label vào panel
                MonthPanel.Controls.Add(label);

                // Gắn sự kiện Click, MouseHover, và MouseLeave
                label.Click += MonthPanel_Click;
                label.MouseHover += MonthPanel_Hover;
                label.MouseLeave += MonthPanel_Leave;

                MonthPanel.Click += MonthPanel_Click;
                MonthPanel.MouseHover += MonthPanel_Hover;
                MonthPanel.MouseLeave += MonthPanel_Leave;

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanelMonth.Controls.Add(MonthPanel);
            }
            List<CustomerOrder> customerOrders = customerOrderService.GetAllOrders();
            dvgOrder.DataSource = customerOrders;
            AddTotalRow();
        }

        // Handle the click event
        private void MonthPanel_Click(object sender, EventArgs e)
        {
            // Get the panel that triggered the event
            if (sender is Panel clickedPanel)
            {
                // Change the background color of the panel
                clickedPanel.BackColor = Color.LightBlue;
                int selectedMonth = (int)clickedPanel.Tag; // Retrieve the month number from Tag
                List<CustomerOrder> customerOrders = customerOrderService.GetOrdersByMonth(selectedMonth);
                dvgOrder.DataSource = customerOrders;
            }
            else if (sender is Label clickedLabel)
            {
                Panel parentPanel = clickedLabel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.BackColor = Color.LightBlue;
                    int selectedMonth = (int)parentPanel.Tag;
                    List<CustomerOrder> customerOrders = customerOrderService.GetOrdersByMonth(selectedMonth);
                    dvgOrder.DataSource = customerOrders;
                }
            }
            AddTotalRow();

        }

        // Handle the hover event
        // Sự kiện khi chuột hover vào panel hoặc label
        private void MonthPanel_Hover(object sender, EventArgs e)
        {
            if (sender is Panel hoveredPanel)
            {
                hoveredPanel.BackColor = Color.LightGreen; // Đổi màu khi chuột vào
            }
            else if (sender is Label hoveredLabel)
            {
                Panel parentPanel = hoveredLabel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.BackColor = Color.LightGreen;
                }
            }
        }

        // Sự kiện khi chuột rời khỏi panel hoặc label (hết hover)
        private void MonthPanel_Leave(object sender, EventArgs e)
        {
            if (sender is Panel leftPanel)
            {
                leftPanel.BackColor = SystemColors.Highlight; // Trả về màu ban đầu khi chuột ra
            }
            else if (sender is Label leftLabel)
            {
                Panel parentPanel = leftLabel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.BackColor = SystemColors.Highlight;
                }
            }
        }
        private void AddTotalRow()
        {
            // Giả sử dvgOrder.DataSource là một List<CustomerOrder>
            var customerOrders = dvgOrder.DataSource as List<CustomerOrder>;
            if (customerOrders != null)
            {
                // Tính tổng của cột TotalAmount
                decimal sum = customerOrders.Sum(order => order.TotalAmount);

                // Tạo một danh sách mới với hàng tổng
                var updatedList = new List<CustomerOrder>(customerOrders)
        {
            new CustomerOrder
            {
                Status = "Tổng", // Đặt giá trị "Tổng:" cho OrderId
                OrderDate = DateTime.MinValue,
                TotalAmount = sum
            }
        };

                // Cập nhật DataGridView
                dvgOrder.DataSource = null; // Xóa dữ liệu hiện tại
                dvgOrder.DataSource = updatedList;
            }
        }



        private void FrmStatistical_Load(object sender, EventArgs e)
        {
            loadMonth();
        }

    }
}
