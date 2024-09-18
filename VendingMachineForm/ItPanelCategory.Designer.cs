namespace VendingMachineForm
{
    partial class ItPanelCategory
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
            btnDeleteCategory = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnSearchCategory = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(192, 0, 0);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(924, 683);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnDeleteCategory);
            panel3.Controls.Add(btnUpdateCategory);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(3, 186);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 492);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Anchor = AnchorStyles.Top;
            btnDeleteCategory.BackColor = Color.Yellow;
            btnDeleteCategory.Location = new Point(749, 322);
            btnDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(147, 75);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Anchor = AnchorStyles.Top;
            btnUpdateCategory.BackColor = Color.Yellow;
            btnUpdateCategory.Location = new Point(750, 225);
            btnUpdateCategory.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(146, 54);
            btnUpdateCategory.TabIndex = 2;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.Top;
            btnAddCategory.BackColor = Color.Yellow;
            btnAddCategory.Location = new Point(750, 104);
            btnAddCategory.Margin = new Padding(3, 4, 3, 4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(146, 69);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 46);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(687, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnSearchCategory);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 79);
            panel2.TabIndex = 9;
            // 
            // btnSearchCategory
            // 
            btnSearchCategory.Anchor = AnchorStyles.Top;
            btnSearchCategory.BackColor = Color.Yellow;
            btnSearchCategory.Location = new Point(752, 21);
            btnSearchCategory.Margin = new Padding(3, 4, 3, 4);
            btnSearchCategory.Name = "btnSearchCategory";
            btnSearchCategory.Size = new Size(129, 49);
            btnSearchCategory.TabIndex = 5;
            btnSearchCategory.Text = "Search";
            btnSearchCategory.UseVisualStyleBackColor = false;
            btnSearchCategory.Click += btnSearchCategory_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BackColor = SystemColors.HighlightText;
            txtSearch.Location = new Point(75, 28);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(651, 31);
            txtSearch.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 81);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(327, 16);
            label1.Name = "label1";
            label1.Size = new Size(257, 49);
            label1.TabIndex = 0;
            label1.Text = "Categories Data";
            label1.Click += label1_Click;
            // 
            // ItPanelCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(923, 680);
            ControlBox = false;
            Controls.Add(panel4);
            Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItPanelCategory";
            Text = "ItPanelCategory";
            Load += ItPanelCategory_Load;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Button btnDeleteCategory;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panel1;
        private Label label1;
        private Button btnSearchCategory;
    }
}