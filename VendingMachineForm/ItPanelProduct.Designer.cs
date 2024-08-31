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
            panel4.Size = new Size(658, 548);
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
            panel3.Size = new Size(658, 368);
            panel3.TabIndex = 10;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Top;
            btnDeleteProduct.Location = new Point(545, 182);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(89, 29);
            btnDeleteProduct.TabIndex = 6;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Anchor = AnchorStyles.Top;
            btnUpdateProduct.Location = new Point(545, 112);
            btnUpdateProduct.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(89, 29);
            btnUpdateProduct.TabIndex = 5;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top;
            btnAddProduct.Location = new Point(547, 42);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(89, 32);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(3, 3);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(522, 362);
            dgvProducts.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnSearchProduct);
            panel2.Controls.Add(txtSearcProduct);
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 81);
            panel2.TabIndex = 9;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Anchor = AnchorStyles.Top;
            btnSearchProduct.Location = new Point(547, 22);
            btnSearchProduct.Margin = new Padding(3, 4, 3, 4);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(87, 36);
            btnSearchProduct.TabIndex = 5;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearcProduct
            // 
            txtSearcProduct.Anchor = AnchorStyles.Top;
            txtSearcProduct.Location = new Point(3, 27);
            txtSearcProduct.Margin = new Padding(3, 4, 3, 4);
            txtSearcProduct.Name = "txtSearcProduct";
            txtSearcProduct.Size = new Size(508, 26);
            txtSearcProduct.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 81);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 35);
            label1.TabIndex = 0;
            label1.Text = "Product Data";
            // 
            // ItPanelProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(660, 557);
            Controls.Add(panel4);
            Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItPanelProduct";
            Text = "ItPanelProduct";
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