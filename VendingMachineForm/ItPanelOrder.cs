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
        public ItPanelOrder()
        {
            InitializeComponent();
        }
        private string _connectionString = "Data Source=ACER\\MYSQL2022;Initial Catalog=VendingMachine;Integrated Security=True";
        private void LoadOrderData()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM OrderDetail"; 
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Đổ dữ liệu vào DataGridView
                    dgvOrder.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrderData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
