using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineForm
{
    public partial class ItPanelProduct : Form
    {
        private ProductService productService;
        public ItPanelProduct()
        {
            productService = new ProductService();
            InitializeComponent();
        }
        private void FillDataGridView(string name)
        {
            List<Product> products;
            products = productService.GetAllProducts();
            dgvProducts.AutoGenerateColumns = true;
            if (products != null && products.Any())
            {
                dgvProducts.DataSource = products;
            }
            else
            {
                MessageBox.Show("No product found");
            }
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void ItPanelProduct_Load(object sender, EventArgs e)
        {
            FillDataGridView("");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddOrUpdateProduct frmAddOrUpdate = new FrmAddOrUpdateProduct();
            frmAddOrUpdate.checkAdd = true;
            frmAddOrUpdate.ShowDialog();
            FillDataGridView("");
        }
    }
}
