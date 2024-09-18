namespace VendingMachineForm
{
    partial class ItPanelOrder
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
            label1 = new Label();
            panel1 = new Panel();
            dgvOrder = new DataGridView();
            panel2 = new Panel();
            btnShowPending = new Button();
            btnShowCompleted = new Button();
            btnShowAll = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 43);
            label1.TabIndex = 0;
            label1.Text = "ORDER DATA";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Yellow;
            panel1.Location = new Point(96, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 67);
            panel1.TabIndex = 0;
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top;
            dgvOrder.BackgroundColor = SystemColors.ButtonHighlight;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(3, 0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(777, 434);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            dgvOrder.CellMouseDoubleClick += dgvOrder_CellMouseDoubleClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(dgvOrder);
            panel2.Location = new Point(55, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 434);
            panel2.TabIndex = 1;
            // 
            // btnShowPending
            // 
            btnShowPending.Anchor = AnchorStyles.Top;
            btnShowPending.BackColor = Color.Yellow;
            btnShowPending.Location = new Point(105, 99);
            btnShowPending.Name = "btnShowPending";
            btnShowPending.Size = new Size(215, 61);
            btnShowPending.TabIndex = 2;
            btnShowPending.Text = "Show Pending Orders";
            btnShowPending.UseVisualStyleBackColor = false;
            btnShowPending.Click += btnShowPending_Click;
            // 
            // btnShowCompleted
            // 
            btnShowCompleted.Anchor = AnchorStyles.Top;
            btnShowCompleted.BackColor = Color.FromArgb(255, 255, 128);
            btnShowCompleted.Location = new Point(359, 99);
            btnShowCompleted.Name = "btnShowCompleted";
            btnShowCompleted.Size = new Size(216, 61);
            btnShowCompleted.TabIndex = 3;
            btnShowCompleted.Text = "Show Completed Orders";
            btnShowCompleted.UseVisualStyleBackColor = false;
            btnShowCompleted.Click += btnShowCompleted_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Anchor = AnchorStyles.Top;
            btnShowAll.BackColor = Color.FromArgb(255, 255, 128);
            btnShowAll.Location = new Point(611, 99);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(178, 61);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All Orders";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ItPanelOrder
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(895, 645);
            ControlBox = false;
            Controls.Add(btnShowAll);
            Controls.Add(btnShowCompleted);
            Controls.Add(btnShowPending);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItPanelOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order";
            TopMost = true;
            Load += ItPanelOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvOrder;
        private Panel panel2;
        private Button btnShowPending;
        private Button btnShowCompleted;
        private Button btnShowAll;
    }
}