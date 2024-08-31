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
    public partial class FrmAddOrUpdateCategory : Form
    {
        public bool checkAdd;
        public bool checkUpdate;
        public Category category;
        private string imagePath = null; // imagePath lay khi nhan upload button
        private CategoryService categoryService;
        public FrmAddOrUpdateCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkAdd)
            {
                string categoryName = txtName.Text.Trim();

                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("Please enter a category name.");
                    return;
                }
                if (imagePath == null)
                {
                    MessageBox.Show("Please upload an image.");
                    return;
                }
                string savedImagePath = imagePath; // savedImagePath: Lưu trữ tạm thời imagePath của người dùng gửi lên

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    savedImagePath = SaveImageToProjectFolder(imagePath); // savedImagePath: cập nhập lại địa chỉ của máy đã lưu imagePath trong bin
                }

                var category = new Category
                {
                    Name = categoryName,
                    ImagePath = savedImagePath
                };
                categoryService.CreateCategory(category);
                this.Close();
            } else if (checkUpdate) {
                string categoryName = txtName.Text.Trim();

                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("Please enter a category name.");
                    return;
                }

                string savedImagePath = category.ImagePath; // Lưu trữ tạm thời imagePath của Category

                // Kiểm tra người dùng có upload mới hình ảnh hay không
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Xóa image cũ trong folder nếu có imagePath mới
                    if (!string.IsNullOrEmpty(category.ImagePath) && File.Exists(category.ImagePath))
                    {
                        File.Delete(category.ImagePath);
                    }

                    // Save the new image to the project folder
                    savedImagePath = SaveImageToProjectFolder(imagePath); // savedImagePath: cập nhập lại địa chỉ của máy đã lưu imagePath trong bin
                }

                // Cập nhập lại category
                category.Name = categoryName;
                category.ImagePath = savedImagePath;

                 categoryService.UpdateCategory(category);
                this.Close();

            }
        }

        private void FrmAddOrUpdateCategory_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            if (checkUpdate)
            {
                lblHeading.Text = "UPDATE CATEGORY";
                txtId.Text = category.CategoryId.ToString();
                txtId.Enabled = false;
                txtName.Text = category.Name;
                // Feature: Picture Box still not show
                pictureBoxCategoryImage.Image = Image.FromFile(category.ImagePath);
            }
            else if (checkAdd)
            {
                lblHeading.Text = "ADD CATEGORY";
                txtId.Hide();
                lblCategoryId.Hide();
                txtName.Text = "";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file and set it to the variable
                    imagePath = openFileDialog.FileName;

                    // Display the image in the PictureBox
                    pictureBoxCategoryImage.Image = Image.FromFile(imagePath);
                }
            }
        }


        private string SaveImageToProjectFolder(string filePath)
        {
            // Determine the path of the Images folder within your project
            string imagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            // Ensure the directory exists
            if (!Directory.Exists(imagesDirectory))
            {
                Directory.CreateDirectory(imagesDirectory);
            }

            // Get the file name from the uploaded path
            string fileName = Path.GetFileName(filePath);

            // Define the target path within the project folder
            string targetPath = Path.Combine(imagesDirectory, fileName);

            // Copy the file to the Images folder in your project
            File.Copy(filePath, targetPath, true); // The 'true' flag will overwrite if the file already exists

            // Return the relative path to store in the database
            return $"Images\\{fileName}";
        }

        private void pictureBoxCategoryImage_Click(object sender, EventArgs e)
        {

        }
    }
}
