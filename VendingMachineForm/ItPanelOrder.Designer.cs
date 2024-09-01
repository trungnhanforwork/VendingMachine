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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvOrder = new DataGridView();
            panel3 = new Panel();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "ORDER DATA";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvOrder);
            panel2.Location = new Point(3, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 344);
            panel2.TabIndex = 1;
            // 
            // dgvOrder
            // 
            dgvOrder.BackgroundColor = SystemColors.ControlLight;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(4, 3);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(491, 338);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDel);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(507, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 344);
            panel3.TabIndex = 2;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Red;
            btnDel.ForeColor = Color.Yellow;
            btnDel.Location = new Point(49, 213);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(107, 46);
            btnDel.TabIndex = 0;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.ForeColor = Color.Yellow;
            btnEdit.Location = new Point(49, 119);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 46);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.ForeColor = Color.Yellow;
            btnAdd.Location = new Point(49, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // ItPanelOrder
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(714, 444);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Enabled = false;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItPanelOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvOrder;
        private Panel panel3;
        private Button button4;
        private Button btnDel;
        private Button btnAdd;
        private Button btnEdit;
    }
}