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
    public partial class ItPanelCategory : Form
    {
        private CategoryService categoryService;
        private Category selected;
        public ItPanelCategory()
        {
            InitializeComponent();
        }

        private void ItPanelCategory_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            var categories = categoryService.GetAllCategories();
            dataGridView1.AutoGenerateColumns = true;
            if (categories != null && categories.Any())
            {

                dataGridView1.DataSource = categories;
            }
            else
            {
                MessageBox.Show("No data found to display in DataGridView.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = null;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmAddOrUpdateCategory frmAddOrUpdate = new FrmAddOrUpdateCategory();
            frmAddOrUpdate.checkAdd = true;
            frmAddOrUpdate.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Please choose one category to update.", "Warning");
                return;
            } 

            FrmAddOrUpdateCategory frmAddOrUpdate = new FrmAddOrUpdateCategory();
            frmAddOrUpdate.category = selected;
            frmAddOrUpdate.checkUpdate = true;
            frmAddOrUpdate.ShowDialog();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selected = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
