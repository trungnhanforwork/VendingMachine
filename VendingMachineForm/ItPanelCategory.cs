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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void FillDataGridView(string name)
        {
            List<Category> categories;
            if (name == null || name == "")
            {
               categories = categoryService.GetAllCategories();
                
            }
            else
            {
                categories = categoryService.GetCategoriesByCondition(name);
            }
            dataGridView1.AutoGenerateColumns = true;
            if (categories != null && categories.Any())
            {
                dataGridView1.DataSource = categories;
            }
            else
            {
                MessageBox.Show("No category found");
            }
        }

        private void ItPanelCategory_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            FillDataGridView("");
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
            FillDataGridView("");
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
            FillDataGridView("");

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selected = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
            }
            else
            {
                selected = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Please choose one catgory to delete!");
            }
            else
            {
                var comfirmResult = MessageBox.Show($"Are you sure deleting category {selected.Name}", "Comfirm Delete", MessageBoxButtons.YesNo);
                if (comfirmResult == DialogResult.Yes)
                {
                    
                    if (!string.IsNullOrEmpty(selected.ImagePath) && File.Exists(selected.ImagePath))
                    {
                        File.Delete(selected.ImagePath);
                    }
                    categoryService.DeleteCategory(selected.CategoryId);
                    MessageBox.Show("Category deleted successfully.");
                   
                }
            }
            FillDataGridView("");
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.ToLower();
            if (name == "")
            {
                FillDataGridView("");
                return;
            }
            FillDataGridView(name);

        }
    }
}
