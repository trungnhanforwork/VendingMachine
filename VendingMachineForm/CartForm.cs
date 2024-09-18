using Entities;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineForm
{
    public partial class CartForm : Form
    {

        private Dictionary<int, (Product product, int quantity)> cart;
        private ProductService productService;

        public CartForm(Dictionary<int, (Product product, int quantity)> cart)
        {
            productService = new ProductService();
            InitializeComponent();
            this.cart = cart;

            // Load the cart items into the form
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            flowLayoutPanelCart.Controls.Clear(); // Clear existing items

            foreach (var item in cart)
            {
                var product = item.Value.product;
                int quantity = item.Value.quantity;

                // Create a panel for the product
                Panel productPanel = new Panel
                {
                    Width = 300,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Firebrick // Optional: background color
                };

                // Add round border to the panel
                productPanel.Paint += (s, e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, productPanel.ClientRectangle, Color.Firebrick, ButtonBorderStyle.Solid);
                };

                // Create a PictureBox for the product image
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(product.ImagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 64,
                    Height = 64,
                    Location = new Point(10, 10)
                };

                // Create a Label for the product name
                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(80, 10),
                    Width = 150,
                    ForeColor = Color.Yellow,
                };

                // Create a Label for the product price
                Label priceLabel = new Label
                {
                    Text = $"Price: {product.Price:C}",
                    ForeColor = Color.Yellow,
                    Location = new Point(80, 30),
                    Width = 100
                };

                // Create a Label for the quantity
                Label quantityLabel = new Label
                {
                    Text = $"Qty: {quantity}",
                    ForeColor = Color.Yellow,
                    Location = new Point(80, 50),
                    Width = 100
                };

                // Create a button to increase quantity
                Button increaseButton = new Button
                {
                    Text = "+",
                    Location = new Point(250, 50),
                    Width = 40
                };

                // Create a button to decrease quantity
                Button decreaseButton = new Button
                {
                    Text = "-",
                    Location = new Point(200, 50),
                    Width = 40
                };

                // Add event handlers to the buttons
                increaseButton.Click += (s, e) => IncreaseQuantity(item.Key, quantityLabel);
                decreaseButton.Click += (s, e) => DecreaseQuantity(item.Key, quantityLabel);

                // Add controls to the product panel
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(quantityLabel);
                productPanel.Controls.Add(increaseButton);
                productPanel.Controls.Add(decreaseButton);

                // Add the product panel to the FlowLayoutPanel
                flowLayoutPanelCart.Controls.Add(productPanel);
            }
        }

        private void IncreaseQuantity(int productId, Label quantityLabel)
        {
            // Increase the quantity in the cart
            cart[productId] = (cart[productId].product, cart[productId].quantity + 1);
            quantityLabel.Text = $"Qty: {cart[productId].quantity}";
        }

        private void DecreaseQuantity(int productId, Label quantityLabel)
        {
            // Decrease the quantity in the cart, remove if quantity is 0
            if (cart[productId].quantity > 1)
            {
                cart[productId] = (cart[productId].product, cart[productId].quantity - 1);
                quantityLabel.Text = $"Qty: {cart[productId].quantity}";
            }
            else
            {
                cart.Remove(productId);
                LoadCartItems(); // Refresh the cart display
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Please choose one product to pay");
                return;
            }
            // Initialize the order service (assume dependencies are injected or created)
            CustomerOrderService orderService = new CustomerOrderService();

            // Create a new CustomerOrder object
            CustomerOrder order = new CustomerOrder
            {
                TotalAmount = cart.Values.Sum(item => item.product.Price * item.quantity)
            };

            // Create a list of OrderDetail objects
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart)
            {
                orderDetails.Add(new OrderDetail
                {
                    ProductId = item.Value.product.ProductId,
                    Quantity = item.Value.quantity,
                    UnitPrice = item.Value.product.Price
                });
            }

            // Save the order and order details
            int orderId = orderService.CreateOrder(order, orderDetails);

            // Clear the cart after saving the order
            cart.Clear();


            // Print the bill
            PrintBill(order, orderDetails, orderId);

            // Optionally, display a message to the user
            DialogResult result = MessageBox.Show($"Order {orderId} created successfully!", "Order Created", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {

                cart.Clear();

                // Clear the flow layout panel
                flowLayoutPanelCart.Controls.Clear();

                // Close the current form
                this.Close();
            }
        }
        private void PrintBill(CustomerOrder order, List<OrderDetail> orderDetails, int orderId)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Graphics graphics = e.Graphics;
                float yPos = 100;
                int leftMargin = e.MarginBounds.Left;

                // Print the header with order information
                graphics.DrawString($"Order Number: {orderId}", new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
                yPos += 25;
                graphics.DrawString($"Total Amount: {order.TotalAmount:C}", new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
                yPos += 40;

                // Print the table header
                graphics.DrawString("Product Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
                graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, leftMargin + 200, yPos);
                graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, leftMargin + 300, yPos);
                graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, leftMargin + 400, yPos);
                yPos += 30;

                // Print each product detail
                foreach (var detail in orderDetails)
                {
                    var product = productService.GetProductById(detail.ProductId); // Fetch the product details from DB or cache
                    graphics.DrawString(product.Name, new Font("Arial", 12), Brushes.Black, leftMargin, yPos);
                    graphics.DrawString(detail.Quantity.ToString(), new Font("Arial", 12), Brushes.Black, leftMargin + 200, yPos);
                    graphics.DrawString(detail.UnitPrice.ToString("C"), new Font("Arial", 12), Brushes.Black, leftMargin + 300, yPos);
                    graphics.DrawString((detail.UnitPrice * detail.Quantity).ToString("C"), new Font("Arial", 12), Brushes.Black, leftMargin + 400, yPos);
                    yPos += 25;
                }
            };

            // Create a print dialog and show it to the user
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
