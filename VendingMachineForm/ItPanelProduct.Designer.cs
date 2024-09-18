namespace VendingMachineForm
{
    partial class ItPanelProduct
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
            panel4 = new Panel();
            panel3 = new Panel();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            panel2 = new Panel();
            btnSearchProduct = new Button();
            txtSearcProduct = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(1, 7);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(993, 675);
            panel4.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnDeleteProduct);
            panel3.Controls.Add(btnUpdateProduct);
            panel3.Controls.Add(btnAddProduct);
            panel3.Controls.Add(dgvProducts);
            panel3.Location = new Point(0, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(993, 489);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Top;
            btnDeleteProduct.BackColor = Color.Yellow;
            btnDeleteProduct.Location = new Point(865, 274);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(109, 61);
            btnDeleteProduct.TabIndex = 6;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Anchor = AnchorStyles.Top;
            btnUpdateProduct.BackColor = Color.Yellow;
            btnUpdateProduct.Location = new Point(865, 154);
            btnUpdateProduct.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(109, 64);
            btnUpdateProduct.TabIndex = 5;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top;
            btnAddProduct.BackColor = Color.Yellow;
            btnAddProduct.Location = new Point(865, 32);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(109, 62);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(839, 471);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnSearchProduct);
            panel2.Controls.Add(txtSearcProduct);
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 81);
            panel2.TabIndex = 9;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Anchor = AnchorStyles.Top;
            btnSearchProduct.BackColor = Color.Yellow;
            btnSearchProduct.Location = new Point(777, 11);
            btnSearchProduct.Margin = new Padding(3, 4, 3, 4);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(111, 50);
            btnSearchProduct.TabIndex = 5;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // txtSearcProduct
            // 
            txtSearcProduct.Anchor = AnchorStyles.Top;
            txtSearcProduct.Location = new Point(56, 30);
            txtSearcProduct.Margin = new Padding(3, 4, 3, 4);
            txtSearcProduct.Name = "txtSearcProduct";
            txtSearcProduct.Size = new Size(664, 31);
            txtSearcProduct.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 81);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(369, 13);
            label1.Name = "label1";
            label1.Size = new Size(217, 49);
            label1.TabIndex = 0;
            label1.Text = "Product Data";
            // 
            // ItPanelProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1001, 694);
            Controls.Add(panel4);
            Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItPanelProduct";
            Text = "ItPanelProduct";
            Load += ItPanelProduct_Load;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel2;
        private Button btnSearchProduct;
        private TextBox txtSearcProduct;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvProducts;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
    }
}