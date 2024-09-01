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
    public partial class FrmAddOrUpdateProduct : Form
    {
        private ProductService productService;
        private CategoryService categoryService;

        public bool checkAdd;
        public bool checkUpdate;
        public Product product;
        private string imagePath = null; // imagePath lay khi nhan upload button
        private void FrmAddOrUpdateProduct_Load(object sender, EventArgs e)
        {
            if (checkAdd)
            {
                lblHeading.Text = "ADD PRODUCT";
                lblProductID.Hide();
                txtId.Hide();
                cboCategory.DataSource = categoryService.GetAllCategories();
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "CategoryId";
            }
            else
            {
                lblHeading.Text = "UPDATE PRODUCT";
                txtId.Text = product.ProductId.ToString();
                txtId.Enabled = false;
            }
        }
        public FrmAddOrUpdateProduct()
        {
            productService = new ProductService();
            categoryService = new CategoryService();
            InitializeComponent();
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

                    // Display the image in the PictureBox for product
                    pictureBoxProductImage.Image = Image.FromFile(imagePath);
                }
            }
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkAdd)
            {
                string productName = txtName.Text.Trim();
                string productPriceText = txtPrice.Text.Trim();
                string productStockText = txtStock.Text.Trim();
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Please enter a product name.");
                    return;
                }
                if (!decimal.TryParse(productPriceText, out decimal productPrice) || productPrice <= 0)
                {
                    MessageBox.Show("Please enter a valid product price.");
                    return;
                }

                if (!int.TryParse(productStockText, out int productStock) || productStock < 0)
                {
                    MessageBox.Show("Please enter a valid stock quantity.");
                    return;
                }
                if (imagePath == null)
                {
                    MessageBox.Show("Please upload an image.");
                    return;
                }

                // Save the image to the project folder and get the path
                string savedImagePath = imagePath;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    savedImagePath = SaveImageToProjectFolder(imagePath, "Product Images");
                }

                // Create a new Product object
                var product = new Product
                {
                    Name = productName,
                    Price = productPrice,
                    Stock = productStock,
                    ImagePath = savedImagePath
                };

                // Save the product using the service
                productService.AddProduct(product);

                MessageBox.Show("Product added successfully.");
            }
            
            this.Close();
        }
        private string SaveImageToProjectFolder(string filePath, string subDirectory)
        {
            // Determine the path of the Images folder within your project
            string imagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", subDirectory);

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
            return Path.Combine("Images", subDirectory, fileName);
        }
    }
}
