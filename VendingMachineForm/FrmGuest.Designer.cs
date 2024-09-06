namespace VendingMachineForm
{
    partial class FrmGuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelCategories = new FlowLayoutPanel();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            btnCart = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelCategories
            // 
            flowLayoutPanelCategories.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCategories.Location = new Point(13, 20);
            flowLayoutPanelCategories.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            flowLayoutPanelCategories.Size = new Size(184, 595);
            flowLayoutPanelCategories.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanelProducts.Location = new Point(205, 20);
            flowLayoutPanelProducts.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(857, 640);
            flowLayoutPanelProducts.TabIndex = 1;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(13, 624);
            btnCart.Margin = new Padding(4);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(184, 36);
            btnCart.TabIndex = 2;
            btnCart.Text = "My Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // FrmGuest
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1079, 711);
            Controls.Add(btnCart);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(flowLayoutPanelCategories);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmGuest";
            Text = "FrmGuest";
            Load += FrmGuest_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelCategories;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private Button btnCart;
    }
}