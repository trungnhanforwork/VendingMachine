namespace VendingMachineForm
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panel1 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            button4 = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 58);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 5);
            label2.Name = "label2";
            label2.Size = new Size(337, 39);
            label2.TabIndex = 0;
            label2.Text = "Vending Machine Manager";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(-3, 639);
            panel4.Name = "panel4";
            panel4.Size = new Size(1151, 47);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(508, 23);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 0;
            label1.Text = "© 2024 KYN Company";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 51);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(btnOrders);
            splitContainer1.Panel1.Controls.Add(btnProducts);
            splitContainer1.Panel1.Controls.Add(btnCategories);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(1130, 582);
            splitContainer1.SplitterDistance = 374;
            splitContainer1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Gold;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(25, 525);
            button4.Name = "button4";
            button4.Size = new Size(314, 45);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Red;
            btnOrders.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.Gold;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(22, 146);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(314, 45);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Red;
            btnProducts.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Gold;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(22, 89);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(314, 45);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Red;
            btnCategories.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.Gold;
            btnCategories.Image = (Image)resources.GetObject("btnCategories.Image");
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(21, 31);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(314, 45);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += button3_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1142, 688);
            Controls.Add(splitContainer1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vending Machine Manager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private SplitContainer splitContainer1;
        private Button button4;
        private Button btnOrders;
        private Button btnProducts;
        private Button btnCategories;
    }
}
