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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VendingMachineForm
{
    public partial class ItPanelProduct : Form
    {
        private Product? selectedProduct = null;
        private ProductService productService;
        public ItPanelProduct()
        {
            productService = new ProductService();
            InitializeComponent();
        }
        private void FillDataGridView(string name)
        {
            List<Product> products;
            dgvProducts.AutoGenerateColumns = true;


            if (name != null && name != "") 
            {
                products = productService.GetProductsByCondition(name);
            }
            else
            {
                products = productService.GetAllProducts();
            }
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
            selectedProduct = null;
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

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                selectedProduct = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
            }
            else
            {
                selectedProduct = null;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please choose one product to update", "Error");
                return;
            }
            FrmAddOrUpdateProduct f = new FrmAddOrUpdateProduct();
            f.product = selectedProduct;
            f.checkUpdate = true;
            f.ShowDialog();
            FillDataGridView("");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please choose one product to delete");
                return;
            }
            var comfirmResult = MessageBox.Show($"Are you sure deleting {selectedProduct.Name}", "Warning", MessageBoxButtons.YesNo);
            if (comfirmResult == DialogResult.Yes)
            {
                productService.DeleteProduct(selectedProduct.ProductId);
                FillDataGridView("");
            }

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string name = txtSearcProduct.Text.ToLower();
            if (name == "")
            {
                FillDataGridView("");
                return;
            }
            FillDataGridView(name);

        }
    }
}
