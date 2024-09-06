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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VendingMachineForm
{
    public partial class FrmGuest : Form
    {
        Dictionary<int, (Product product, int quantity)> cart = new Dictionary<int, (Product product, int quantity)>();
        private CategoryService categoryService;
        private ProductService productService;
        public FrmGuest()
        {
            categoryService = new CategoryService();
            productService = new ProductService();
            InitializeComponent();
        }

        private void LoadCategories()
        {
            // Fetch all categories using the service
            List<Category> categories = categoryService.GetAllCategories();

            // Clear any existing controls in the FlowLayoutPanel to prevent duplicates
            flowLayoutPanelCategories.Controls.Clear();

            // Loop through each category and create a panel with image and label
            foreach (var category in categories)
            {
                // Create a new panel for the category
                Panel categoryPanel = new Panel
                {
                    Width = 64,  // Adjust width as needed
                    Height = 64, // Adjust height as needed
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = category.CategoryId
                };

                // Create a PictureBox for the category image
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(category.ImagePath), // Ensure the path is correct and accessible
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Width = 32,  // Adjust width as needed
                    Height = 32, // Adjust height as needed
                    Dock = DockStyle.Top
                };

                // Add the PictureBox to the category panel
                categoryPanel.Controls.Add(pictureBox);

                // Create a Label for the category name
                Label label = new Label
                {
                    Text = category.Name,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Add the Label to the category panel
                categoryPanel.Controls.Add(label);

                // Attach click event handlers to both PictureBox and Label
                pictureBox.Click += CategoryPanel_Click;
                label.Click += CategoryPanel_Click;
                categoryPanel.Click += CategoryPanel_Click;

                // Add the category panel to the FlowLayoutPanel
                flowLayoutPanelCategories.Controls.Add(categoryPanel);
            }
        }


        private void FrmGuest_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void CategoryPanel_Click(object sender, EventArgs e)
        {
            Panel categoryPanel = sender as Panel;
            if (categoryPanel != null)
            {
                int categoryId = (int)categoryPanel.Tag;
                LoadProductsByCategoryId(categoryId);
                //MessageBox.Show(categoryId.ToString());
            }
        }

        private void LoadProductsByCategoryId(int categoryId)
        {
            flowLayoutPanelProducts.Controls.Clear(); // Clear existing products

            List<Product> products = productService.GetProductsByCategoryId(categoryId);

            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 220,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(product.ImagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 80,
                    Height = 80,
                    Location = new Point(10, 10)
                };

                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(100, 10),
                    Width = 100
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {product.Price:C}",
                    Location = new Point(100, 40),
                    Width = 100
                };

                Button addToCartButton = new Button
                {
                    Image = (Image)Properties.Resources.shopping_bag16x16,
                    Location = new Point(100, 70),
                    Tag = product.ProductId
                };
                addToCartButton.Click += AddToCartButton_Click;

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(addToCartButton);

                flowLayoutPanelProducts.Controls.Add(productPanel);
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Button addToCartButton = (Button)sender;
            int productId = (int)addToCartButton.Tag;

            // Find the product by its ID
            Product selectedProduct = productService.GetProductById(productId);

            // Check if the product is already in the cart
            if (cart.ContainsKey(productId))
            {
                // If it's already in the cart, increment the quantity
                cart[productId] = (selectedProduct, cart[productId].quantity + 1);
            }
            else
            {
                // Otherwise, add it to the cart with a quantity of 1
                cart[productId] = (selectedProduct, 1);
            }
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(cart);
            cartForm.ShowDialog();
        }
    }
}
